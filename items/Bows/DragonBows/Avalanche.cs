using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Bows.DragonBows
{
	public class Avalanche : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This item got rebalanced and resprited many times");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 75, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 100; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 15);
			recipe.AddIngredient(ItemID.Tsunami, 1);
			recipe.AddIngredient(mod, "BlueBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}

		
	}
}