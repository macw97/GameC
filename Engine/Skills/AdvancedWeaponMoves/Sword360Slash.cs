using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.AdvancedWeaponMoves
{
    class Sword360Slash:Skill
    {
        public Sword360Slash():base("Sword full rotation slash",25,5)
        {
            PublicName = "Full roration slash [requires sword]: 0.3*Str+0.2*Pr damage [cut] and 0.1*Str+0.1*Pr damage[incised]";
            RequiredItem = "Sword";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage move1 = new StatPackage("cut");
            move1.HealthDmg = (int)(0.3 * player.Strength + 0.2 * player.Precision);
            StatPackage move2 = new StatPackage("incised");
            move2.HealthDmg = (int)(0.1 * player.Strength + 0.1 * player.Precision);
            move2.CustomText = "You use Full Rotation Slash(" + move1.HealthDmg + " cut dmg, " + move2.HealthDmg + " incised dmg";
            return new List<StatPackage>(){ move1,move2};
        }
    }
}
