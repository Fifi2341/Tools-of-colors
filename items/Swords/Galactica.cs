using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class Galactica : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Galaxy sword.");
		}

		public override void SetDefaults()
		{
			item.damage = 285;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 17;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.shoot = ProjectileType<Projectiles.GalaxyP>();
			item.knockBack = 99;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.shootSpeed = 10f;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 35;
		}





		public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HexaMatter", 35);
			recipe.AddIngredient(mod, "UltimaBar", 2);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
