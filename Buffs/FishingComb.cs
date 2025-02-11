using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader.IO;
using Terraria.GameInput;
using Terraria.Localization;

namespace AlchemistNPCLite.Buffs
{
	public class FishingComb : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishing Combination");
			Description.SetDefault("Combination of Crate, Sonar, Fishing, Regeneration, Thorns, Iron Skin, Calming & Inferno buffs");
			Main.debuff[Type] = false;
			BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Комбинация Рыбака");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сочетание баффов Ящиков, Сонара, Рыбалки, Регенерации, Шипов, Железной Кожи, Покоя и Инферно");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "钓鱼药剂包");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "包含以下Buff：声呐, 钓鱼, 恢复, 镇静, 荆棘, 铁皮, 狱火, 宝匣");
        }
		
		public override void Update(Player player, ref int buffIndex)
		{
			AlchemistNPCLitePlayer modPlayer = player.GetModPlayer<AlchemistNPCLitePlayer>();
			modPlayer.Defense8 = true;
			modPlayer.Regeneration = true;
			player.buffImmune[2] = true;
			player.buffImmune[5] = true;
			player.buffImmune[14] = true;
			player.buffImmune[106] = true;
			player.buffImmune[116] = true;
			player.buffImmune[121] = true;
			player.buffImmune[122] = true;
			player.buffImmune[123] = true;
			player.fishingSkill += 15;
			player.sonarPotion = true;
			player.cratePotion = true;
			player.calmed = true;
            if ((double)player.thorns < 1.0) player.thorns = 0.3333333f;
			
			player.inferno = true;
			Lighting.AddLight((int)((double)player.Center.X / 16.0), (int)((double)player.Center.Y / 16.0), 0.65f, 0.4f, 0.1f);
			int type = 24;
			float num = 200f;
			bool flag = player.infernoCounter % 60 == 0;
			int Damage = 10;
			if (player.whoAmI == Main.myPlayer)
			{
				for (int number = 0; number < 200; ++number)
				{
					NPC npc = Main.npc[number];
					if (npc.active && !npc.friendly && (npc.damage > 0 && !npc.dontTakeDamage) && (!npc.buffImmune[type] && (double)Vector2.Distance(player.Center, npc.Center) <= (double)num))
					{
						if (npc.FindBuffIndex(120) == -1)
							npc.AddBuff(type, 120, false);
						if (flag)
						{
							npc.StrikeNPC(Damage, 0.0f, 0, false, false, false);
						}
					}
				}
			}
			
		}
	}
}
