using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class WaterEnemy : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Water's enemy"); 
		}

		public override void SetDefaults()
		{
			item.damage = 35;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 30;
		}





		public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 5);
			recipe.AddIngredient(ItemID.Gel, 40);
			recipe.AddTile(TileID.WorkBenches); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
