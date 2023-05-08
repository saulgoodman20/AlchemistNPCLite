using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;
 
namespace AlchemistNPCLite.Items
{
    public class CalamityCombination : ModItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
			ModLoader.TryGetMod("Delet", out Mod Calamity);
			return Calamity != null;
        }

		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Calamity Combination");
			Tooltip.SetDefault("Grants most buffs from Calamity Mod potions (Yharim's Stimulants, Cadance, Titan Scale, Soaring, Bounding and Fabsol's Vodka)");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Комбинация Calamity");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Даёт большинство баффов от зелий мода Calamity (Стимулянты Ярима, Каденции, Титановой Чешуи, Полёта, Связующее и Водки Фабсола)");

            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "灾厄药剂包");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "给予大部分灾厄药剂的增益效果 (Yharim之力, 舒畅, 泰坦鳞片, 节奏大师, 全知)");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
        }    

		public override void SetDefaults()
        {
            Item.UseSound = SoundID.Item3;                 //this is the sound that plays when you use the item
            Item.useStyle = 9;                 //this is how the item is holded when used
            Item.useTurn = true;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.maxStack = 99;                 //this is where you set the max stack of item
            Item.consumable = true;           //this make that the item is consumable when used
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = 10;
            Item.buffType = Item.buffType = ModContent.BuffType<Buffs.CalamityComb>();           //this is where you put your Buff
            Item.buffTime = 52000;    //this is the buff duration        10 = 10 Second
        }
        
		public override void AddRecipes()
		{
		
		}
    }
}
