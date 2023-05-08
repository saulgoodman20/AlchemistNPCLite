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
     public class TitanSkinPotion : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titan Skin Potion");
			Tooltip.SetDefault("Grants immunity to some debuffs (On Fire!, Frostburn, Cursed Flame, Chilled, Frozen, Ichor)"
			+ "\nImmunity to Cursed Flame and Ichor would work only after beating Twins"
			+"\nNON-CALAMITY BUFF POTION");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Зелье Титановой Кожи");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Даёт иммунитет к некоторым серьёзным дебаффам (Горение, Морозный ожог, Проклятое Пламя, Замедление, Заморозка, Ихор)\nИммунитет к Проклятому Пламени или Ихору активируется только после победы над Близнецами");

            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "泰坦皮肤药剂");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "使你免疫部分Debuff (点燃, 霜燃, 诅咒火焰, 寒冷, 冰冻, 腐蚀)\n对诅咒火焰和腐蚀的免疫能力只有在击败双子魔眼后才会生效\n非灾厄BUFF药剂");
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
            Item.width = 20;
            Item.height = 30;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 7;
            Item.buffType = ModContent.BuffType<Buffs.TitanSkin>();           //this is where you put your Buff
            Item.buffTime = 52000;    //this is the buff duration        10 = 10 Second
            return;
        }
		
		public override void AddRecipes()
		{
			Recipe recipeCursedFlame = Recipe.Create(Item.type);
			recipeCursedFlame.AddIngredient(ItemID.Waterleaf, 1);
			recipeCursedFlame.AddIngredient(ItemID.Fireblossom, 1);
			recipeCursedFlame.AddIngredient(ItemID.Shiverthorn, 1);
			recipeCursedFlame.AddIngredient(ItemID.Deathweed, 1);
			recipeCursedFlame.AddIngredient(ItemID.Obsidian, 1);
			recipeCursedFlame.AddIngredient(ItemID.CrystalShard, 1);
			recipeCursedFlame.AddIngredient(ItemID.SoulofLight, 1);
			recipeCursedFlame.AddIngredient(ItemID.SoulofNight, 1);
			recipeCursedFlame.AddIngredient(ItemID.BottledWater, 1);
			recipeCursedFlame.AddTile(TileID.Bottles);

			Recipe recipeIchor = recipeCursedFlame.Clone();
			
			recipeCursedFlame.AddIngredient(ItemID.CursedFlame, 1);
			recipeIchor.AddIngredient(ItemID.Ichor, 1);

			recipeCursedFlame.Register();
			recipeIchor.Register();
		}
    }
}
