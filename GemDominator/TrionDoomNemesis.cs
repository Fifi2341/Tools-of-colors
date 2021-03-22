using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.GemDominator
{
	public class TrionDoomNemesis : ModItem
	{
		

		public override void SetDefaults()
		{
			item.damage = 295;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 9;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.rare = 11;
			item.shoot = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shootSpeed = 24;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "UltimaBar", 15);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}


		

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
	
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GrenadeI, damage, knockBack, player.whoAmI);

			return true;
		}

	}
}