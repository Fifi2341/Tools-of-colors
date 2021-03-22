using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Hammers
{
	public class RainbowHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("STOP! Its hammer time :D"); 
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
			item.hammer = 90;  
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}