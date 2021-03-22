using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ColorSwords.Items.Blob.GreenBlob.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class BlobChest : ModItem
	{
		

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.rare = 2;
			item.defense = 5;
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