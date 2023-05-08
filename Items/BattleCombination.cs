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
    public class BattleCombination : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Battle Combination");
			Tooltip.SetDefault("Grants buffs, which are necessary for battle (Endurance, Lifeforce, Ironskin, Regeneration, Rage & Wrath)");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Боевая Комбинация");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Даёт баффы, важные для битв (Выносливость, Жизненные Силы, Железная Кожа, Регенерация, Ярость и Гнев)");

            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "战斗药剂包");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "获得你在战斗时需要的Buff(耐力, 生命力, 铁皮, 恢复, 暴怒, 怒气)");
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
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = 10;
            Item.buffType = ModContent.BuffType<Buffs.BattleComb>();           //this is where you put your Buff
            Item.buffTime = 52000;    //this is the buff duration
            return;
        }
		
		public override void AddRecipes()
		{
			Recipe recipe = Recipe.Create(Item.type);
            recipe.AddIngredient(ItemID.EndurancePotion, 1);
            recipe.AddIngredient(ItemID.LifeforcePotion, 1);
            recipe.AddIngredient(ItemID.IronskinPotion, 1);
            recipe.AddIngredient(ItemID.RestorationPotion, 1);
            recipe.AddIngredient(ItemID.RagePotion, 1);
            recipe.AddIngredient(ItemID.WrathPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.Register();
		}
    }
}
