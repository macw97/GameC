using System;
using System.Collections.Generic;
using Game.Engine.Skills.SkillFactories;
using Game.Engine.Monsters.MonsterFactories;
using Game.Engine.Items;
using Game.Engine.Items.Artefacts;
using Game.Engine.Items.ItemFactories;
using Game.Engine.Items.BasicArmor;
using Game.Engine.Interactions;
using Game.Engine.Interactions.InteractionFactories;

namespace Game.Engine
{
    // contains information about skills, items and monsters that will be available in the game
    public partial class Index
    {
        private static List<SkillFactory> magicSkillFactories = new List<SkillFactory>()
        {
            new BasicSpellFactory(),
            new AdvancedSpellsFactory()
        };

        private static List<SkillFactory> weaponSkillFactories = new List<SkillFactory>()
        {
            new BasicWeaponMoveFactory(),
            new AdvancedMovesFactory()
        };

        private static List<Item> items = new List<Item>()
        {
            new BasicStaff(),
            new BeliarStaff(),
            new BasicSpear(),
            new BasicAxe(),
            new BasicSword(),
            new ScimitarSword(),
            new TripleSword(),
            new SteelArmor(),
            new AntiMagicArmor(),
            new BerserkerArmor(),
            new GrowingStoneArmor(),
            new BeliarArmor(),
            new BeliarNeckles(),
            new MargeryWeapon(),
            new MargeryArmor()
        };

        private static List<ItemFactory> itemFactories = new List<ItemFactory>()
        {
            new BasicArmorFactory(),
            new WeaponFactory()
        };

        private static List<MonsterFactory> monsterFactories = new List<MonsterFactory>()
        {
            new Monsters.MonsterFactories.RatFactory(),
            new Monsters.MonsterFactories.SpiderFactory(),
            new Monsters.MonsterFactories.DoomFactory(),
            new Monsters.MonsterFactories.DragonFactory()
        };

        private static List<InteractionFactory> interactionFactories = new List<InteractionFactory>()
        {
            new SkillForgetFactory(),
            new GymirHymirFactory(),
            new MargeryMauriceFactory(),
            new BlacksmithFactory()
        };

    }
}
