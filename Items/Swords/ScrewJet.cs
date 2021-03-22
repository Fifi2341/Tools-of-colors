using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords
{
	public class ScrewJet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scream Jet");
			Tooltip.SetDefault("Scream Jet is first proof that the greatest inventions are accidents.");
		}

		public override void SetDefaults()
		{
			item.damage = 325;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 17;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.shootSpeed = 10f;
			item.rare = 10;
			item.shoot = 14;
			item.useAmmo = AmmoID.None;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 25;
		}





		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Galactica");
			recipe.AddIngredient(mod, "ColorBar", 5);
			recipe.AddIngredient(ItemID.LunarBar, 10);
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
