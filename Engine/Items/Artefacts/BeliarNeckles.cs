using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.Artefacts
{
    class BeliarNeckles:Item
    {
        public BeliarNeckles():base("item0013")
        {
            PublicName = "Beliar Neckles";
            PublicTip = "If you collect Beliar Staff and Armor you will increase all stats by 50 points";
            GoldValue = 400;
            ArMod = 120;
        }
    }
}
