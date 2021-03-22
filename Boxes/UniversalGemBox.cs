using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Boxes
{
	public class UniversalGemBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/cc00ff:Universal Gem Box] [c/00ff00:Medium]");
			Tooltip.SetDefault("Contains: \n Sapphire (15) 100% \n Ruby (15) 100% \n Emerald (15) 100% \n Amber (15) 100%");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 5;
			
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemID.Ruby, 15);
			player.QuickSpawnItem(ItemID.Sapphire, 15);
			player.QuickSpawnItem(ItemID.Emerald, 15);
			player.QuickSpawnItem(ItemID.Amber, 15);
		}

		
	}
}