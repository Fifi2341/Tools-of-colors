using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.Cutlass
{
	public class ColorCutlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Yarr!");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 35, 0, 0);
			item.rare = 5;
			item.shoot = 157;
			item.shootSpeed = 2f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<Projectiles.Cutlass.PirateSkelly>();
			item.useAmmo = AmmoID.None;
		}

		public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cutlass, 1);
			recipe.AddIngredient(mod, "ColorBar", 10);
			recipe.AddIngredient(mod, "HexaMatter", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}