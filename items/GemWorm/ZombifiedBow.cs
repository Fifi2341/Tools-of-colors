using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.GemWorm
{
	public class ZombifiedBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxic Bow");
			Tooltip.SetDefault("Strong");

		}

		public override void SetDefaults()
		{
			item.damage = 3000;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 9;
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 167; 
			item.shootSpeed = 24;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ZombifiedBar", 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 1);
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