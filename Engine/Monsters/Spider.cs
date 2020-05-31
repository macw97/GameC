using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    class Spider:Monster
    {
        // example monster: Spider
        public Spider(int spiderLevel)
        {
            Health = 40 + 3 * spiderLevel;
            Strength = 15 + spiderLevel;
            Armor = 0;
            Precision = 30;
            MagicPower = 0;
            Stamina = 40;
            XPValue = 30 + spiderLevel;
            Name = "monster0003";
            BattleGreetings = null; 
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                
                return new List<StatPackage>() { new StatPackage("stab", Strength, "Spider uses Bite technic! (" + (Strength) + " stab damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Spider has no energy to attack anymore!") };
            }
        }
    }
}
