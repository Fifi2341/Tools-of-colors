using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Sickles
{
	public class RainbowScythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Sick Death"); 


		}

		public override void SetDefaults() 
		{
			item.damage = 150;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 100;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 55, 0, 0);
			item.shoot = 274;
			item.shootSpeed = 5f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()   
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DeathSickle, 1);
			recipe.AddIngredient(mod, "ColorBar", 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}




