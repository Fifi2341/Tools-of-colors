using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class CrystalFist : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Shiny!");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 600;
			item.value = Item.buyPrice(0, 45, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 30;
		}

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddIngredient(mod, "Crystals", 15);
			recipe.AddIngredient(mod, "YellowSmallRock", 5);
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
