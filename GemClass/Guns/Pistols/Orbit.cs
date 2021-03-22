using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.GemClass.Guns.Pistols
{
	public class Orbit : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Found in the orbit");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 55, 0, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = ProjectileType<GemClass.Projectiles.OrbitShot>();
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.None;
			item.mana = 5;
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