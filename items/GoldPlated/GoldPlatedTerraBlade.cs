using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;


namespace ColorSwords.Items.GoldPlated
{
	public class GoldPlatedTerraBlade : ModItem
	{
		public override void SetStaticDefaults()
		{

			Tooltip.SetDefault("So it can beat zenith");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(2); 
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; 
		}

		public override void SetDefaults() 
		{
			item.damage = 500;  
			item.melee = true;
			item.width = 150;
			item.height = 150;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.shoot = 132;
			item.shootSpeed = 20f;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GemGoldBar", 10);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	

}