using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class ChlorFist : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Fist like any other");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 380;
			item.value = Item.buyPrice(0, 75, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 70;
		}

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.MythrilAnvil); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
