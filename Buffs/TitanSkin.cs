using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;
using Terraria.ID;

namespace AlchemistNPCLite.Buffs
{
    public class TitanSkin : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titan Skin");
            Description.SetDefault("You have some heavy debuff immunity");
            Main.debuff[Type] = false;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Кожа Титана");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Вы имеете иммунитет к некоторым серьёзным дебаффам");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "泰坦皮肤");
            Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "你免疫一些Debuff");
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (NPC.downedMechBoss2)
            {
                player.buffImmune[39] = true;
                player.buffImmune[69] = true;
            }
            player.buffImmune[24] = true;
            player.buffImmune[44] = true;
            player.buffImmune[46] = true;
            player.buffImmune[47] = true;

        }
    }
}
