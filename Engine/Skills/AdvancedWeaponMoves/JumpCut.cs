using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.AdvancedWeaponMoves
{
    class JumpCut:Skill
    {
        public JumpCut() : base("Jump Cut", 20, 5)
        {
            PublicName = "Jump Cut[requires sword]: 0.2*Str+0.1*Pr damage [cut]";
            RequiredItem = "Sword";
        }
        public override List<StatPackage> BattleMove(Game.Engine.CharacterClasses.Player player)
        {
            StatPackage move1 = new StatPackage("cut");
            move1.HealthDmg = (int)(0.2 * player.Strength + 0.1 * player.Precision);
            move1.CustomText = "You use Jump Cut(" + move1.HealthDmg + " cut dmg)";
            return new List<StatPackage>() { move1 };
        }
    }
}
