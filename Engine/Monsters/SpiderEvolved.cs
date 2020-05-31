using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    class SpiderEvolved:Monster
    {
        
        public SpiderEvolved(int spiderLevel)
        {
            Health = 50 + 6 * spiderLevel;
            Strength = 20 + spiderLevel;
            Armor = 0;
            Precision = 40;
            MagicPower = 0;
            Stamina = 50;
            XPValue = 40 + spiderLevel;
            Name = "monster0004";
            BattleGreetings =null; 
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>()
                { 
                   
                    new StatPackage("stab", Strength, "Tarantula uses Bite technic! ("+ (Strength) +" stab damage)"),
                    new StatPackage("poison", 10, "Venom burns in your veins (10 poison damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Tarantula has no energy to attack anymore!") };
            }
        }
    }
}
