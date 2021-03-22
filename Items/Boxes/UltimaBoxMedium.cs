using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.Items.Placeable;
using ColorSwords.Items.Bars;

namespace ColorSwords.Items.Boxes
{
	public class UltimaBoxMedium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultima Box [c/00ff00:Medium]");
			Tooltip.SetDefault("Contains: \n Ultima anvil: 99% \n Ultima bar: 1%");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 11;
			
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.NextFloat() < .9900f)
				player.QuickSpawnItem(ItemType<UltimaAnvil>());

			if (Main.rand.NextFloat() < .1f)
				player.QuickSpawnItem(ItemType<UltimaBar>());
		}

		
	}
}