using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class ColorFuryClockwork : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Clockwork.");
		}

		public override void SetDefaults()
		{
			item.damage = 25;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 20, 0, 0);
			
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 85;
		}





		public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RedBar", 3);
			recipe.AddIngredient(mod, "BlueBar", 3);
			recipe.AddIngredient(mod, "YellowBar", 3);
			recipe.AddIngredient(mod, "BlueBar", 3);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
