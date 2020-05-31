using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.BasicArmor
{
    class MargeryArmor:Item
    {
        public MargeryArmor() : base("item0015")
        {
            PublicName = "Margery Armor";
            GoldValue = 10;
            ArMod = 20;
        }
    }
}
