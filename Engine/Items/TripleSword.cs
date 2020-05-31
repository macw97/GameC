using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    class TripleSword:Sword
    {
        public TripleSword() : base("item0010")
        {
            StrMod = 80;
            PrMod = 20;
            GoldValue = 250;
            PublicName = "Triple Sword";
        }
    }
}
