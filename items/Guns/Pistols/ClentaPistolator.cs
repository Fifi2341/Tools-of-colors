using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Pistols
{
	public class ClentaPistolator : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fight with bosses and clean your world out of evil at same time!");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 9;
			item.value = Item.buyPrice(0, 70, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorPistol");
			recipe.AddIngredient(ItemID.Clentaminator);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.PureSpray, damage, knockBack, player.whoAmI);

			return true;
		}
	}
}