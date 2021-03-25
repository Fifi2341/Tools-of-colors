using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Colorswords.Items.TPUG_items
{
	public class Greencandycanebow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Green candy cane bow"); // i made this item in school
			Tooltip.SetDefault("doubles as a treat \n also has a chance to shoot star anise instead of arrows");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = false;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item97;
			item.shoot = ProjectileID.JestersArrow;
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = true;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileID.WoodenArrowFriendly, ProjectileID.StarAnise });
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