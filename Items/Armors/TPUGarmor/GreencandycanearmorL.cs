
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using ColorSwords.Items.TPUG_items;

namespace Colorswords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GreencandycanearmorL : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green candy cane Leggings");
			Tooltip.SetDefault("it tastes good!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreenCandyCaneBlock, 25);
			recipe.AddIngredient(ModContent.ItemType<SoulOfChristmas>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
