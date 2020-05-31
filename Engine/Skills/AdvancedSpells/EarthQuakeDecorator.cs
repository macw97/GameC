using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.AdvancedSpells
{
    class EarthQuakeDecorator:SkillDecorator
    {
        public EarthQuakeDecorator(Skill skill):base("Earthquake",25,6,skill)
        {
            MinimumLevel = Math.Max(6, skill.MinimumLevel);
            PublicName = "COMBO - Earthquake: chance to land your spell with 0.8*MP dmg and -0.15*Precision [earth] AND " + decoratedSkill.PublicName.Replace("COMBO - ","");
            RequiredItem = "Staff";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage move = new StatPackage("earth");
            Random rnd = new Random();
            if (rnd.Next(0, player.Precision) < (0.85 * player.Precision))
            {
                move.HealthDmg = (int)(0.8 * player.MagicPower);
                move.CustomText = "You use Earthquake! (" + move.HealthDmg + " earth damage)";
            }
            else
            {
                move.HealthDmg = 0;
                move.CustomText = "You try to use Earthquake but it misses!";
            }
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(move);
            return combo;
        }
    }
}
