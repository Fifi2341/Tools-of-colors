 using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Miniguns
{
	public class OppressorTwo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oppressor MK II");
			Tooltip.SetDefault("Get some help. Get some fk*n help.");
		}

		public override void SetDefaults()
		{
			item.damage = 999;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(20, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
			item.crit = 55;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Oppressor");
			recipe.AddIngredient(mod, "ColorBar", 45);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .90f;
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