using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.BasicWeaponMoves
{
    class SwordSlashDecorator:SkillDecorator
    {
        public SwordSlashDecorator(Skill skill) : base("Sword Slash", 20, 1,skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel);
            PublicName = "Basic sword slash [requires sword]: 0.1*Str + 0.1*Pr damage [stab] and then 0.1*Str + 0.1*Pr damage [incised]";
            RequiredItem = "Sword";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage response1 = new StatPackage("stab");
            response1.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            StatPackage response2 = new StatPackage("incised");
            response2.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            response2.CustomText = "You use Sword Slash! (" + ((int)(0.1 * player.Strength) + (int)(0.1 * player.Precision)) + " stab damage, " + ((int)(0.1 * player.Strength) + (int)(0.1 * player.Precision)) + " incised damage)";
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response1);
            combo.Add(response2);
            return combo;
        }
    }
}
