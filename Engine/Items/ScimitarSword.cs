using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    class ScimitarSword:Sword
    {
        public ScimitarSword() : base("item0009")
        {
            StrMod = 30;
            PrMod = 10;
            GoldValue = 100;
            PublicName = "Scimitar Sword";
        }
    }
}
