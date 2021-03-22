using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.GoldPlated
{
	public class GoldPlatedOnyxBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This underrated masterpiece deserves gold plating RIGHT NOW!");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
		}

		public override void SetDefaults()
		{
			item.damage = 555;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime =20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 17f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GemGoldBar", 10);
			recipe.AddIngredient(ItemID.OnyxBlaster);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .70f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BlackBolt, damage, knockBack, player.whoAmI);

			return true;

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