using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlchemistNPCLite
{
    public class StarPrice : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            switch(item.type)
            {
                case ItemID.FallenStar:
                    item.value = AlchemistNPCLite.modConfiguration.StarPrice;
                    break;
				case ItemID.RecallPotion:
                    item.value = AlchemistNPCLite.modConfiguration.RecallPrice;
                    break;
				case ItemID.WormholePotion:
                    item.value = AlchemistNPCLite.modConfiguration.WormholePrice;
                    break;
				case 1267:
                    item.value = 20;
                    break;
				case 1268:
                    item.value = 40;
                    break;
				case 1269:
                    item.value = 60;
                    break;
				case 1270:
                    item.value = 75;
                    break;
				case 1271:
                    item.value = 113;
                    break;
				case 1272:
                    item.value = 130;
                    break;
				case ItemID.SiltBlock:
                    item.value = AlchemistNPCLite.modConfiguration.SiltSlushPrice;
                    break;
				case ItemID.SlushBlock:
                    item.value = AlchemistNPCLite.modConfiguration.SiltSlushPrice;
                    break;
				case ItemID.DesertFossil:
                    item.value = AlchemistNPCLite.modConfiguration.DesertFossilPrice;
                    break;
            }
        }
    }
}