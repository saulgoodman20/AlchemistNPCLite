using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;
using Terraria.DataStructures;

namespace AlchemistNPCLite.Buffs
{
    public class CalamityComb : ModBuff
    {
        private string[] BuffList = {
                "FabsolVodkaBuff",
                "Soaring",
                "BoundingBuff"
        };

        public override bool IsLoadingEnabled(Mod mod)
        {
			ModLoader.TryGetMod("CalamityMod", out Calamity);
			return Calamity != null;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calamity Combination");
            Description.SetDefault("Perfect sum of Calamity buffs"
            + "\nFabsol's Vodka, Soaring, Bounding");
            Main.debuff[Type] = false;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Комбинация Каламити");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Идеальное сочетание баффов Каламити мода\nДает эффект Стимулянтов Ярима, Каденции, Водки Фабсола, Титановой Чешуи и Всевидения");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "灾厄药剂包");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "完美结合了以下灾厄药剂的Buff：\n魔君牌兴奋剂、尾音药剂、Fabsol伏特加、泰坦之鳞药剂以及全知药剂");
        }

        public override void Update(Player player, ref int buffIndex)
        {

            foreach (string BuffString in BuffList)
            {
                if (Calamity.TryFind<ModBuff>(BuffString, out ModBuff buff))
                    player.buffImmune[buff.Type] = true;
            }
            // IMPLEMENT WHEN WEAKREFERENCES FIXED
            /*
			if (ModLoader.GetMod("ThoriumMod") != null)
			{
				ThoriumBoosts(player);
			}
			if (ModLoader.GetMod("Redemption") != null)
			{
				RedemptionBoost(player);
			}
			*/
            if (ModLoader.GetMod("CalamityMod") != null)
            {
                CalamityBoost(player, ref buffIndex);
            }
        }


        private void CalamityBoost(Player player, ref int buffIndex)
        {
            foreach (string BuffString in BuffList)
            {
                if (Calamity.TryFind<ModBuff>(BuffString, out ModBuff buff))
                    buff.Update(player, ref buffIndex);
            }
        }
        private Mod Calamity;

        // IMPLEMENT WHEN WEAKREFERENCES FIXED
        /*
		private void RedemptionBoost(Player player)
        {
			Redemption.Items.DruidDamageClass.DruidDamagePlayer RedemptionPlayer = player.GetModPlayer<Redemption.Items.DruidDamageClass.DruidDamagePlayer>();
            Redemptionplayer.GetDamage(DamageClass.druid) += 2;
        }
		private void ThoriumBoosts(Player player)
        {
            ThoriumMod.ThoriumPlayer ThoriumPlayer = player.GetModPlayer<ThoriumMod.ThoriumPlayer>();
            Thoriumplayer.GetDamage(DamageClass.symphonic) += 2;
            Thoriumplayer.GetDamage(DamageClass.radiant) += 2;
        }
		*/
    }
}
