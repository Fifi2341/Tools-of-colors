using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Bows
{
	public class WardFuture : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("4Ward Future");

		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 75, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
		    item.shoot = mod.ProjectileType("WardProje");
		    item.shootSpeed = 14;

			if (GetInstance<ColorSwordsConfig>().isLagReduceEnabled)
			{
				item.damage = 300;
				item.useTime = 60;
				item.shoot = mod.ProjectileType("WardProjeLag");
			}

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 20);
			recipe.AddIngredient(ItemID.SoulofFright);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		

		

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); 
				
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; 
		}

		
	}
}