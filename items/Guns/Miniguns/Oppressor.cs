 using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Miniguns
{
	public class Oppressor : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("80% not to consume ammo! \n turret go vroom! \n Wait till you'll see mk II");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 70, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 2f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorRifle");
			recipe.AddIngredient(mod, "ColorBar", 10);
			recipe.AddIngredient(ItemID.Megashark);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .80f;
		}


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}




		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);

		}
	}
}