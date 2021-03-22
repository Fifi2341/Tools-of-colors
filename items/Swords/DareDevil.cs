using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class DareDevil : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Fear me!");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableExperimentalItems;
		}

		public override void SetDefaults()
		{
			item.damage = 100;  
			item.melee = true;
			item.width = 90;
			item.height = 90;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.channel = true;
			item.noUseGraphic = true;
			item.knockBack = 12;
			item.value = Item.buyPrice(0, 85, 0, 0);
			item.shootSpeed = 20f;
			item.rare = 5;
			item.shootSpeed = 40f;
			//item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SwingA");
			item.crit = 65;
		}





		public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HexaMatter", 15);
			recipe.AddIngredient(mod, "YellowSmallRock", 15);
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
