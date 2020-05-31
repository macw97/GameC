using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.ItemFactories
{
    class WeaponFactory:ItemFactory
    {
        public Item CreateItem()
        {
            List<Item> basicWeapons = new List<Item>()
            {
                new BasicSword(),
                new ScimitarSword(),
                new TripleSword(),
                new BasicStaff(),
                new BeliarStaff()
            };
            return basicWeapons[Index.RNG(0, basicWeapons.Count)];
        }
        public Item CreateNonMagicItem()
        {
            
            List<Item> basicWeapons = new List<Item>()
            {
                new BasicSword(),
                new ScimitarSword(),
                new TripleSword()
            };
            return basicWeapons[Index.RNG(0, basicWeapons.Count)];
        }
        public Item CreateNonWeaponItem()
        {
            
            List<Item> basicWeapons = new List<Item>()
            {
                new BasicStaff(),
                new BeliarStaff()
            };
            return basicWeapons[Index.RNG(0, basicWeapons.Count)];
        }
    }
}
