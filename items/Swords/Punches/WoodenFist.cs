using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class WoodenFist : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Heavy but strong!");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 100;
			item.value = Item.buyPrice(0, 45, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 5;
		}

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Benches); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
