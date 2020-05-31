using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    class BeliarStaff:Staff
    {
        public BeliarStaff():base("item0011")
        {
            MgcMod = 50;
            GoldValue = 150;
            PublicName = "Beliar Staff";
            PublicTip = "This rare staff increases your Magic power by 50 + current power/5 also increases health by 20 points";
        }
        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            currentPlayer.MagicPowerBuff += MgcMod + currentPlayer.MagicPower / 5;
            currentPlayer.HealthBuff += 20;
        }
    }
}
