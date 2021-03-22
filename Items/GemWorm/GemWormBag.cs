using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using ColorSwords.Items.GemWorm;


namespace ColorSwords.Items.GemWorm
{
	public class GemWormBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Worm Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 10;
			item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemType<ZombifiedBar>());
			player.QuickSpawnItem(ItemType<ZombifiedScarf>());			
		}

		public override int BossBagNPC => NPCType<Npcs.GemWorm.GemWorm>();
	}
}