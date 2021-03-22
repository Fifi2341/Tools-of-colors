using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Axes.GrandAxes
{
	public class RainbowGrandAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Created to cut all kind of trees!");  
		}

		public override void SetDefaults()
		{
			item.damage = 215;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.axe = 14;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 99);
			recipe.AddIngredient(mod, "ColorBar", 40);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();



			ModRecipe recipe2 = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 99);
			recipe.AddIngredient(mod, "ColorBar", 40);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
		
	}
}