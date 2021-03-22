using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Bows.Repeaters
{
	public class HellRepeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A repeater from hell");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 40;
			item.value = Item.buyPrice(0, 35, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 18;
			item.useAmmo = AmmoID.Arrow;
		}


		public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddTile(TileID.Anvils); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}




		 
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(2); 
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); 
				
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; 
		}

		
	}
}