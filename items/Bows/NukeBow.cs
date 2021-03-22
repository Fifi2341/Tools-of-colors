using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Bows
{
	public class NukeBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Blast off your enemies!");
		}

		public override void SetDefaults()
		{
			item.damage = 500;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 9;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.scale = 2f;
			item.shoot = 1; 
			item.shootSpeed = 24;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RocketI, 99);
			recipe.AddIngredient(mod, "OldGem");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		

		
		

		

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GrenadeI, damage, knockBack, player.whoAmI);
			
			return true;
		}

	}
}