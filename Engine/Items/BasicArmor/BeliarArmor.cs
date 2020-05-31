using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Items.BasicArmor
{
    class BeliarArmor:Item
    {
        private int reverseMagic;
        public BeliarArmor():base("item0012")
        {
            PublicName = "Beliar Armor";
            ArMod = 50;
            GoldValue = 250;
            PublicTip = "If you collect Beliar Staff and Neckles you will increase all stats by 50 points";
        }
        public override StatPackage ModifyOffensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == "fire" || pack.DamageType == "water" || pack.DamageType == "air" || pack.DamageType == "earth")
            {
                pack.HealthDmg = pack.HealthDmg * (100 + reverseMagic) / 100;
            }
            return pack;
        }
        public override StatPackage ModifyDefensive(StatPackage pack, List<string> otherItems)
        {
            reverseMagic += pack.HealthDmg;
            return pack;
        }
        public override void ApplyBuffs(Player currentPlayer, List<string> otherItems)
        {
            if(otherItems.Contains("item0011")&& otherItems.Contains("item0013"))
            {
                currentPlayer.HealthBuff += 50;
                currentPlayer.StrengthBuff += 50;
                currentPlayer.ArmorBuff += 50;
                currentPlayer.PrecisionBuff += 50;
                currentPlayer.MagicPowerBuff += 50;
                currentPlayer.StaminaBuff += 50;
            }
        }
    }
}
