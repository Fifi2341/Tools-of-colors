using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GemDominator
{
	public class UltimaRagnarok : ModItem
	{ 
		public override void SetStaticDefaults()
		{
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableExperimentalItems;
		}

		public override void SetDefaults() 
		{
			item.damage = 625;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.noUseGraphic = true;
			item.channel = true;
			item.shootSpeed = 20f;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("SwingU");
			item.crit = 30;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "UltimaBar", 15);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		

	}
}




