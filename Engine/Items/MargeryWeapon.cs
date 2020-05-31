using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    class MargeryWeapon:Spear
    {
        public MargeryWeapon():base("item0014")
        {
            StrMod = 10;
            PrMod = 10;
            GoldValue = 10;
            PublicName = "Margery Trident";
        }
    }
}
