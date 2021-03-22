using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Axes
{
	public class RainbowRadicalAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Rainbow axe, perfect to destory trees!");  
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.axe = 25;         
			item.knockBack = 10;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GreenBar", 3);
			recipe.AddIngredient(mod, "YellowBar", 3);
			recipe.AddIngredient(mod, "RedBar", 3);
			recipe.AddIngredient(mod, "BlueBar", 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}