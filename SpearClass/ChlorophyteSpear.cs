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
	public class ChlorophyteSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fires a homing projectile! Little broken tho!");



		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.noUseGraphic = true;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = Item.buyPrice(0, 70, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<SpearClass.Projectiles.ChlorSpear>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 40f;

			if (GetInstance<ColorSwordsConfig>().isLagReduceEnabled)
			{
				item.shoot = mod.ProjectileType("ChlorSpearLag");
			}

		}

		

		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));

				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}


