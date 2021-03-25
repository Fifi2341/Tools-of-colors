using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TPUG.Tiles;
using TPUG.Items;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class TBASTeasureBag: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vase of secrets");
			Tooltip.SetDefault("What lies inside?");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.consumable = true;
		}
		public override bool CanRightClick()
		{
			return true;
		}
		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemID.IronBar, Main.rand.Next(5, 8));
			player.QuickSpawnItem(mod.ItemType("MiniShield"));
			switch (Main.rand.Next(1, 7))
			{
				case 1:
					player.QuickSpawnItem(mod.ItemType("SacrificialKnife"));
					break;
				case 2:
					player.QuickSpawnItem(mod.ItemType("TBASGun"));
					break;
				case 3:
					player.QuickSpawnItem(mod.ItemType("TBASSword"));
					break;
				case 4:
					player.QuickSpawnItem(mod.ItemType("TBASStaff"));
					break;
			}
			switch (Main.rand.Next(1, 7))
			{
				case 1:
					player.QuickSpawnItem(mod.ItemType("SacrificialKnife"));
					break;
				case 2:
					player.QuickSpawnItem(mod.ItemType("TBASGun"));
					break;
				case 3:
					player.QuickSpawnItem(mod.ItemType("TBASSword"));
					break;
				case 4:
					player.QuickSpawnItem(mod.ItemType("TBASStaff"));
					break;
			}

		}
	}
}