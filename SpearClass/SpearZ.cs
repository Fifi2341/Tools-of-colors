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
	public class SpearZ : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("What a trend!");


		}

		public override void SetDefaults() 
		{
			item.damage = 350;
			item.ranged = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.noUseGraphic = true;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 35;
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<SpearClass.Projectiles.SpearZ>();
			item.useAmmo = AmmoID.None;
			item.shootSpeed = 120f;

			

		}

		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

		{

			float spread = 45f * 0.0174f;

			float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);

			double startAngle = Math.Atan2(speedX, speedY) - spread / 2;

			double deltaAngle = spread / 40f;

			double offsetAngle;

			int i;

			for (i = 0; i < 8; i++)

			{

				offsetAngle = startAngle + deltaAngle * i;

				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("SolarSpear"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("ChlorSpearLag"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("WoodenSpear"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("CrystalSpear"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("MoltenSpear"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("BoneSpear"), damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("HallowSpear"), damage, knockBack, item.owner);

				if (GetInstance<ColorSwordsConfig>().isLagReduceEnabled)
				{
					Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("SpearZLag"), damage, knockBack, item.owner);
				}
				else
				{
					Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("SpearZ"), damage, knockBack, item.owner);
				}

			}

			return false;

		}




		public override void AddRecipes()
		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "WoodenSpear");
			recipe.AddIngredient(mod, "CrystalSpear");
			recipe.AddIngredient(mod, "HalloSpear");
			recipe.AddIngredient(mod, "ChlorophyteSpear");
			recipe.AddIngredient(mod, "SolarSpear");
			recipe.AddIngredient(mod, "BoneSpear");
			recipe.AddIngredient(mod, "MoltenSpear");
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}


