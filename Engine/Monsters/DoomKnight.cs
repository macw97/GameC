using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    class DoomKnight:Monster
    {
        public DoomKnight(int Level)
        {
            Health = 150 + 10 * Level;
            Strength = 80 + Level;
            Armor = 80;
            Precision = 70;
            MagicPower = 60;
            Stamina = 100;
            XPValue = 1000;
            Name = "monster0005";
            BattleGreetings = "You fool want to battle ME? My name is Doom Knight Prepare to DIE.";
        }
        public override List<StatPackage> BattleMove()
        {
            List<StatPackage> attacks = new List<StatPackage>();
            if(Stamina>=50)
            {
                Stamina -= 10;
                attacks.Add(new StatPackage("Cut", Strength/3, "Doom Knight Cuts you (" + Strength/3 + ") physical dmg"));
                attacks.Add(new StatPackage("Fire", Strength/5, 5, 10, 5, 20, "Doom Knigth throw fire spell (Strength: " + Strength/5 + ",Magic: 20,Armor destruction: 5)"));
                return attacks;
            }
            else if ((Stamina >= 30 && Stamina<50)|| (Health>=60 && Health<=90))
            {
                Stamina -= 10;
                attacks.Add(new StatPackage("Cut", (Strength + 25)/3, "Doom Knight uses Fire Blade (Strength:" + (Strength + 25)/3 + ")"));
                return attacks;
            }
            else if(Health<60 && Stamina<=50)
            {
                Stamina -= 15;
                attacks.Add(new StatPackage("Earth", Strength+20,20,20,10, 10, "Doom Knight powerfull save spell(Strength:" + (Strength +20) + ",Magic:" + 20 + ",Armor desturcion:" + 20+")"));
                return attacks;
            }
            else
            {
                attacks.Add(new StatPackage("none", 0, "Doom knigth has no energy to attack anymore!") );
                return attacks;
            }
        }
    }
}
