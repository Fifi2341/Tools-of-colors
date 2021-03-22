using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.GemClass.Swords
{
	public class GemSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("First in its class!"); 


		}

		public override void SetDefaults() 
		{
			item.damage = 75;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 55, 0, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<GemClass.Projectiles.GemPro>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 3f;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 25);
			recipe.AddIngredient(mod, "HexaMatter", 25);
			recipe.AddIngredient(mod, "YellowSmallRock", 25);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
	}
}




