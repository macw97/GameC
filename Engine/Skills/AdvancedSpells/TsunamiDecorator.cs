using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.AdvancedSpells
{
    class TsunamiDecorator:SkillDecorator
    {
        public TsunamiDecorator(Skill skill) : base("Tsunami", 30, 6,skill)
        {
            MinimumLevel = Math.Max(15, skill.MinimumLevel);
            PublicName = "COMBO - Tsunami spell: low chance (50%) to make dmg but powerfull spell - 1.1*MP damage [water] AND "+ decoratedSkill.PublicName.Replace("COMBO - ", "");
            RequiredItem = "Staff";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage move = new StatPackage("water");
            Random rnd = new Random();
            if (rnd.Next(0, player.Precision) <= 0.5 * player.Precision)
            {
                move.HealthDmg = (int)(1.1 * player.MagicPower);
                move.CustomText = "You use Tsunami! (" + move.HealthDmg + " water damage)";
            }
            else
            {
                move.HealthDmg = 0;
                move.CustomText = "You try to use Tsunami but it misses!";
            }
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(move);
            return combo;
        }
    }
}
