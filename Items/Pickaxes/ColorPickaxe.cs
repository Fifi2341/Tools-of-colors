using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Pickaxes
{
	public class ColorPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Pickaxe filled with color energy.");  
		}

		public override void SetDefaults()
		{
			item.damage = 20;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.pick = 220;
			item.value = Item.buyPrice(0, 65, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 20);
			recipe.AddIngredient(mod, "Mecha", 5);
			recipe.AddIngredient(ItemID.Picksaw);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}