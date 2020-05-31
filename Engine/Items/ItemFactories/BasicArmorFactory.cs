﻿using System;
using System.Collections.Generic;
using Game.Engine.Items.BasicArmor;

namespace Game.Engine.Items.ItemFactories
{
    [Serializable]
    class BasicArmorFactory : ItemFactory
    {
        // produce items from BasicArmor directory
        public Item CreateItem()
        {
            List<Item> basicArmor = new List<Item>()
            {
                new SteelArmor(),
                new AntiMagicArmor(),
                new BerserkerArmor(),
                new GrowingStoneArmor(),
                new BeliarArmor(),
                new Engine.Items.Artefacts.BeliarNeckles()
            };
            return basicArmor[Index.RNG(0, basicArmor.Count)];
        }
        public Item CreateNonMagicItem()
        {
            // GrowingStoneArmor only works for magic users
            List<Item> basicArmor = new List<Item>()
            {
                new SteelArmor(),
                new AntiMagicArmor(),
                new BerserkerArmor(),
                new Engine.Items.Artefacts.BeliarNeckles()
            };
            return basicArmor[Index.RNG(0, basicArmor.Count)];
        }
        public Item CreateNonWeaponItem()
        {
            // BerserkerArmor only works for physical damage dealers
            List<Item> basicArmor = new List<Item>()
            {
                new SteelArmor(),
                new AntiMagicArmor(),
                new GrowingStoneArmor(),
                new BeliarArmor(),
                new Engine.Items.Artefacts.BeliarNeckles()
            };
            return basicArmor[Index.RNG(0, basicArmor.Count)];
        }
    }
}
