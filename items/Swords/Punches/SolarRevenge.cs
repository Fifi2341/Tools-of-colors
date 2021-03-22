using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class SolarRevenge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Power-full");
		}

		public override void SetDefaults() 
		{
			item.damage = 300;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 600;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 85;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 18);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
