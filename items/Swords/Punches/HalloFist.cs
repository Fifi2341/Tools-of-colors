using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class HalloFist : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Halo?");
		}

		public override void SetDefaults() 
		{
			item.damage = 85;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 300;
			item.value = Item.buyPrice(0, 65, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 40;
		}

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
