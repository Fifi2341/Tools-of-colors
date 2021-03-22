using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.ShortSwords
{
	public class GemShortSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Weak but what to say"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 50;  
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 75;
			
		}


	

	
	public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BlueBar", 1);
			recipe.AddIngredient(mod, "GreenBar", 1);
			recipe.AddIngredient(mod, "BlueBar", 1);
			recipe.AddIngredient(mod, "YellowBar", 1);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
