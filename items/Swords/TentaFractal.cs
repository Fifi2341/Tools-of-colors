using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class TentaFractal : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Found underwater");
		}

		public override void SetDefaults()
		{
			item.damage = 80;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.shoot = 496;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 65, 0, 0);
			item.shootSpeed = 20f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 85;
		}





		public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HexaMatter", 15);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
