using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    class GoldDragon:Monster
    {
        public GoldDragon(int Level)
        {
            Health = 100 + 10 * Level;
            Strength = 70 + Level;
            Armor = 100;
            Precision = 60;
            MagicPower = 0;
            Stamina = 100;
            XPValue = 700;
            Name = "monster0006";
            BattleGreetings = "Many mighty warriors tried to battle me, all of them died just like you will";
        }
        public override List<StatPackage> BattleMove()
        {
            List<StatPackage> attacks = new List<StatPackage>();
            if (Stamina >= 60)
            {
                Stamina -= 10;
                attacks.Add(new StatPackage("Cut", Strength/3, "Gold Dragon use claws (" + Strength/3 + ") physical dmg"));
                attacks.Add(new StatPackage("Fire", Strength/3, 10, 10, 10, 20, "Gold Dragon throw mythical magical fire (Strength: " + Strength/3 + ",Magic: 20,Armor destruction:20)"));
                return attacks;
            }
            else if (Stamina >= 40 && Stamina < 60)
            {
                Stamina -= 5;
                attacks.Add(new StatPackage("Cut", Strength/3 + 15, "Gold Dragon uses Fire claws (" + (Strength/3 + 15) + ")"));
                return attacks;
            }
            else if(Stamina<40)
            {
                Stamina -= 5;
                attacks.Add(new StatPackage("Earth", Strength +10, 15, 10, 10, 10, "Gold Dragon rage flame save spell(Strength:" + (Strength + 10) + ",Magic:" + 10 + ",Armor desturcion:" + 10 + ")"));
                return attacks;
            }
            else
            {
                attacks.Add(new StatPackage("none", 0, "Golden Dragon has no energy to attack anymore!"));
                return attacks;
            }
        }
    }
}
