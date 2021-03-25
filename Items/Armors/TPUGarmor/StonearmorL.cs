using ColorSwords.Items.TPUG_items;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class StonearmorL : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stone Leggings");
			Tooltip.SetDefault("your heels must be in pain");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 1;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
