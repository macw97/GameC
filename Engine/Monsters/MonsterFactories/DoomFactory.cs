using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Game.Engine.Monsters.MonsterFactories
{
    class DoomFactory:MonsterFactory
    {
        private int encounter=0;
        public override Monster Create(int playerLevel)
        {
            if (encounter <= 3)
            {
                encounter++;
                return new DoomKnight(playerLevel);
            }
            else
                return null;
        }
        public override Image Hint()
        {
            if (encounter <= 3)
                return new DoomKnight(0).GetImage();
            else
                return null;
        }

    }
}
