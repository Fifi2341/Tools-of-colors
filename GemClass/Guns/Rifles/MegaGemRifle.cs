using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.GemClass.Projectiles;

namespace ColorSwords.GemClass.Guns.Rifles
{
	public class MegaGemRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Pew Pew");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 10;
			item.value = Item.buyPrice(0, 55, 0, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = ProjectileType<Projectiles.MegaBullet>();
			item.shootSpeed = 120f;
			item.useAmmo = AmmoID.None;
		}

		


		

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 10 + Main.rand.Next(2); 
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); 
				
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; 
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