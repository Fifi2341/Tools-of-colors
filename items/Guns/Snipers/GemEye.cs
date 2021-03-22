using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Snipers
{
	public class SGemEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Eye"); 
			Tooltip.SetDefault("High damage but slow speed");
		}

		public override void SetDefaults()
		{
			item.damage = 510;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 100;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 80, 0, 0);
			item.rare = 6;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 100;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorPistol");
			recipe.AddIngredient(ItemID.SoulofFright, 15);
			recipe.AddIngredient(ItemID.SoulofSight, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}