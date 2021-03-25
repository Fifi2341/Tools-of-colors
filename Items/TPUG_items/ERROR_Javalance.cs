using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Colorswords.Items.TPUG_items
{
	public class ERROR_Javalance: ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("ERROR. NO INFORMATION FOUND. ITEM IS MEANT TO INFLICT A RANDOM DEBUFF OUT OF A SET OF DEBUFFS TO HUT YOUR ENEMY");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = false;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 9f;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("ERROR_Javalance");
			item.stack = 3;
		}
		public override void UpdateInventory(Player player)
		{
			item.useTime = 30 + (item.stack * 10) - 10;
			item.useAnimation = 30 + (item.stack * 10) - 10;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = item.stack;
			float rotation = MathHelper.ToRadians(18);
			if (numberProjectiles > 1)
			{
				position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
				for (int i = 0; i < numberProjectiles; i++)
				{
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .9f;
					Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				}
				return false;
			}
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LiquidERROR>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}