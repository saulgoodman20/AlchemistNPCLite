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
     public class FishingCombination : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishing Combination");
			Tooltip.SetDefault("Grants Crate, Sonar, Fishing, Regeneration, Thorns, Iron Skin, Calming & Inferno buffs");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Комбинация Рыбака");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Даёт баффы Ящиков, Сонара, Рыбалки, Регенерации, Шипов, Железной Кожи, Покоя и Инферно");

            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "钓鱼药剂包");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "获得你在钓鱼时所需的Buff (声呐, 钓鱼, 恢复, 镇静, 荆棘, 铁皮, 狱火, 宝匣)");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
        }    
		public override void SetDefaults()
        {
            Item.UseSound = SoundID.Item44;                 //this is the sound that plays when you use the item
            Item.useStyle = 9;                 //this is how the item is holded when used
            Item.useTurn = true;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.maxStack = 99;                 //this is where you set the max stack of item
            Item.consumable = true;           //this make that the item is consumable when used
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 10;
            Item.buffType = ModContent.BuffType<Buffs.FishingComb>();           //this is where you put your Buff
            Item.buffTime = 52000;    //this is the buff duration        10 = 10 Second
            return;
        }
		
		public override void AddRecipes()
		{
			Recipe recipe = Recipe.Create(Item.type);
			recipe.AddIngredient(ItemID.FishingPotion, 1);
			recipe.AddIngredient(ItemID.SonarPotion, 1);
			recipe.AddIngredient(ItemID.CratePotion, 1);
			recipe.AddIngredient(ItemID.RestorationPotion, 1);
			recipe.AddIngredient(ItemID.IronskinPotion, 1);
			recipe.AddIngredient(ItemID.ThornsPotion, 1);
			recipe.AddIngredient(ItemID.InfernoPotion, 1);
			recipe.AddIngredient(ItemID.CalmingPotion, 1);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.Register();
		}
    }
}
