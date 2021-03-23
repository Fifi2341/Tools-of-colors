using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Snipers
{
	public class CornRevenge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corn Revenge"); 
			Tooltip.SetDefault("Looks like advanced sniper yet being just candy corn rifle with sniper parts attached to it.");
		}

		public override void SetDefaults()
		{
			item.damage = 180;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 49;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 9;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 100;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 5);
			recipe.AddIngredient(ItemID.CandyCornRifle, 15);
			recipe.AddIngredient(ItemID.SoulofSight, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}