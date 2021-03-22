using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GemWorm
{
	public class ToxicBlade : ModItem
	{ 
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Why is it so toxic to me?");


		}

		public override void SetDefaults() 
		{
			item.damage = 3200;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ZombifiedBar", 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		

	}
}




