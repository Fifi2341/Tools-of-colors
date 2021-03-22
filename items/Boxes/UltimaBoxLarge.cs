using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.Items.Placeable;
using ColorSwords.Items.Bars;
using ColorSwords.Items.Materials;

namespace ColorSwords.Items.Boxes
{
	public class UltimaBoxLarge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultima Box [c/ff9999:Large]");
			Tooltip.SetDefault("Contains: \n Ultima anvil: 99% \n Ultima bar: 2% \n Old gem: 1%");
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

			if (Main.rand.NextFloat() < .2f)
				player.QuickSpawnItem(ItemType<UltimaBar>());

			if (Main.rand.NextFloat() < .1f)
				player.QuickSpawnItem(ItemType<OldGem>());
		}

		
	}
}