using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.ShortSwords
{
	public class OverclockedShortSwordZ: ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("King of shortswords"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 789;
			item.shootSpeed = 20f;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 15;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 80;
			item.shoot = ProjectileType<Projectiles.OshortP>();
			item.useAmmo = AmmoID.None;

		}


	

	
	public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OldGem", 2);
			recipe.AddIngredient(mod, "UltimaBar", 5);
			recipe.AddIngredient(mod, "ColorBar", 35);
			recipe.AddIngredient(mod, "Crystals", 35);
			recipe.AddIngredient(mod, "GemShortSword");
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
