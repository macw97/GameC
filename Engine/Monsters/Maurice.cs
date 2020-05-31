using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    class Maurice:Monster
    {
        public Maurice(int Level)
        {
            Health = 180 + 10 * Level;
            Strength = 50 + Level;
            Armor = 100;
            Precision = 60;
            MagicPower = 0;
            Stamina = 100;
            XPValue = 700;
            Name = "monster0007";
            BattleGreetings = "Prepare to die!!! No one will say that I am a thief!";
        }
        public override List<StatPackage> BattleMove()
        {
            List<StatPackage> attacks = new List<StatPackage>();
            if (Stamina >= 60)
            {
                Stamina -= 10;
                attacks.Add(new StatPackage("Cut", Strength / 3, "Maurice use double dagger(" + Strength / 3 + ") physical dmg"));
                return attacks;
            }
            else if (Stamina >= 40 && Stamina < 60)
            {
                Stamina -= 5;
                attacks.Add(new StatPackage("Cut", Strength / 3 + 15, "Maurice throws shurikens in you(" + (Strength / 3 + 15) + ") physical dmg"));
                return attacks;
            }
            else if (Stamina < 40)
            {
                Stamina -= 5;
                attacks.Add(new StatPackage("Cut",Strength/2, "Maurice use double dagger(" + (Strength/2)+") physical dmg"));
                return attacks;
            }
            else
            {
                attacks.Add(new StatPackage("none", 0, "Maurice is exhausted."));
                return attacks;
            }
        }
    }
}

