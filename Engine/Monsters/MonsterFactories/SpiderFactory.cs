using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    class SpiderFactory:MonsterFactory
    {
        private int encounterNumber = 0;
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber >= 0 && encounterNumber <= 3)
            {
                encounterNumber++;
                return new Spider(playerLevel);
            }
            else if (encounterNumber > 3 && encounterNumber <= 7)
            {
                encounterNumber++;
                return new SpiderEvolved(playerLevel);
            }
            else return null;
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber >=0 && encounterNumber<=3) return new Spider(0).GetImage();
            else if (encounterNumber>3 && encounterNumber<=7) return new SpiderEvolved(0).GetImage();
            else return null;
        }
    }
}
