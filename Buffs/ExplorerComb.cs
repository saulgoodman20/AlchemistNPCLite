using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria.Localization;

namespace AlchemistNPCLite.Buffs
{
	public class ExplorerComb : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Explorer Combination");
			Description.SetDefault("Combination of Dangersense, Hunter, Spelunker, Night Owl, Shine & Mining buffs"
			+"\nAlso gives effects of Gills, Flippers and Water Walking Potions");
			Main.debuff[Type] = false;
			BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Комбинация Исследователя");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сочетания баффов Предчувствия, Охотника, Шахтёра, Ночного Зрения, Сияния и Добычи\nТакже даёт эффекты Подводного Дыхания, Ласт и Хождения по воде");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "探索者药剂包");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "包含以下Buff：危险感知, 狩猎, 洞穴探险, 夜猫子, 光芒, 挖矿\n同时给予鱼鳃、脚蹼和水上行走药剂效果");
        }
		public override void Update(Player player, ref int buffIndex)
		{
			player.findTreasure = true;
			Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
			player.nightVision = true;
			player.detectCreature = true;
			player.pickSpeed -= 0.25f;
			player.dangerSense = true;
			player.gills = true;
			player.waterWalk = true;
			player.ignoreWater = true;
            player.accFlipper = true;
			player.buffImmune[4] = true;
			player.buffImmune[15] = true;
			player.buffImmune[109] = true;
			player.buffImmune[9] = true;
			player.buffImmune[11] = true;
			player.buffImmune[12] = true;
			player.buffImmune[17] = true;
			player.buffImmune[104] = true;
			player.buffImmune[111] = true;
			BuffLoader.Update(BuffID.Gills, player, ref buffIndex);
			BuffLoader.Update(BuffID.Flipper, player, ref buffIndex);
			BuffLoader.Update(BuffID.Shine, player, ref buffIndex);
		}
	}
}
