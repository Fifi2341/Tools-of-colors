using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Blob.GreenBlob
{
	public class GreenBlobStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Can be OP when used correctly. Use to place mine in air");


		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.width = 30;
			item.height = 30;
			item.summon = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<BlobP>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 0f;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GreenBlob", 5);
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		
	}
}




