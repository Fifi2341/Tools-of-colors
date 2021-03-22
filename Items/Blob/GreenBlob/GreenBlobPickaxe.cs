using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Blob.GreenBlob
{
	public class GreenBlobPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{

			Tooltip.SetDefault("Can mine meteor ore!");
		}
		public override void SetDefaults()
		{
			item.damage = 20; 
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.pick = 50;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GreenBlob", 10);
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}