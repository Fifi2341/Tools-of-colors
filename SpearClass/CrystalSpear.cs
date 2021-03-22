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
	public class CrystalSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("For early HM"); 


		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.ranged = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.noUseGraphic = true;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<SpearClass.Projectiles.CrystalSpear>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 30f;
		}

		

		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 25);
			recipe.AddIngredient(ItemID.UnicornHorn, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


