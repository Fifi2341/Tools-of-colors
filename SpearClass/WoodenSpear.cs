using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.SpearClass
{
	public class WoodenSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Will do good job");


		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.noUseGraphic = true;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<SpearClass.Projectiles.WoodenSpear>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 30f;
		}

		



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


