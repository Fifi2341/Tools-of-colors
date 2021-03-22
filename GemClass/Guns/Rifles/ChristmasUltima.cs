using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.GemClass.Projectiles;

namespace ColorSwords.GemClass.Guns.Rifles
{
	public class ChristmasUltima : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Merry Christmas 2020!");
		}

		public override void SetDefaults()
		{
			item.damage = 450;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 10;
			item.value = Item.buyPrice(10, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = ProjectileType<Projectiles.ChristmasBullet>();
			item.shootSpeed = 120f;
			item.useAmmo = AmmoID.None;
		}


		/*public override void AddRecipes()   
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "TheLastGiftOfChristmas");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/




		
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

		
	}
}