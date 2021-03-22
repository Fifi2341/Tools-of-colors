using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Guns.Rifles
{
	public class DMG : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("D.M.G");
			Tooltip.SetDefault("Dolphin machine gun");
		}

		public override void SetDefaults()
		{
			item.damage = 360;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 168; 
			item.shootSpeed = 33f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 30);
			recipe.AddIngredient(ItemID.SoulofFright, 50);
			recipe.AddIngredient(ItemID.SDMG); 
			recipe.AddIngredient(ItemID.SoulofSight, 50);
			recipe.AddIngredient(mod, "Mecha", 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		


		
		


	}
}