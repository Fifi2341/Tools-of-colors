using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Hammers.WarHammers
{
	public class RainbowWrappedWarHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("What is better than normal hammer? Warhammer!");
		}

		public override void SetDefaults()  
		{
			item.damage = 125;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.hammer = 260;  
			item.knockBack = 50;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RainbowHammer");
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}