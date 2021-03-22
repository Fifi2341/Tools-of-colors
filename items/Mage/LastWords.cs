using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Mage
{
	public class LastWords : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("People change, memmories don't");
		}


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


		public override void SetDefaults()
		{
			item.damage = 250;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 3;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(2, 50, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 496; 
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.None;
			item.mana = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 40);
			recipe.AddIngredient(mod, "HexaMatter", 40);
			recipe.AddIngredient(mod, "OldGem");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}