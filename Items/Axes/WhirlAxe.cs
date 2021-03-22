using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Axes
{
	public class WhirlAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			
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
			item.axe = 30;        
			item.knockBack = 10;
			item.value = Item.buyPrice(0, 65, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RainbowRadicalAxe");
			recipe.AddIngredient(mod, "ColorBar", 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}