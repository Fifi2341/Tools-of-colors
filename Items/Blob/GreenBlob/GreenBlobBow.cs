using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Blob.GreenBlob
{
	public class GreenBlobBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Seems useful for early game");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 2;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 14;
			item.useAmmo = AmmoID.Arrow;
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