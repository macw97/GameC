using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.AdvancedWeaponMoves
{
    class JumpCutDecorator:SkillDecorator
    {
        public JumpCutDecorator(Skill skill) : base("Jump Cut", 20, 5, skill)
        {
            MinimumLevel = Math.Max(5, skill.MinimumLevel);
            PublicName = "COMBO - Jump Cut[requires sword]: 0.2*Str+0.1*Pr damage [cut] AND " + decoratedSkill.PublicName.Replace("COMBO - ", "");
            RequiredItem = "Sword";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage move1 = new StatPackage("cut");
            move1.HealthDmg = (int)(0.2 * player.Strength + 0.1 * player.Precision);
            move1.CustomText = "You use Jump Cut(" + move1.HealthDmg + " cut dmg )";
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(move1);
            return combo;
        }
    }
}
