
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Blob.GreenBlob.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class BlobJeans : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Not so comfortable but stylish for sure!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 2;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GreenBlob", 5);
			recipe.AddTile(TileID.Benches); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}