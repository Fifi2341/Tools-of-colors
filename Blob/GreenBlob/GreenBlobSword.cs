using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Blob.GreenBlob
{
	public class GreenBlobSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Blob your enemies"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 15;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 10;
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
