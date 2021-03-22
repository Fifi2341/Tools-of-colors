using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Materials
{
	public class OldGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Gem");
			Tooltip.SetDefault("Looks very old");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.buyPrice(2, 0, 0, 0);
			item.rare = 11;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 25);
			recipe.AddIngredient(ItemID.Emerald, 25);
			recipe.AddIngredient(ItemID.Sapphire, 25);
			recipe.AddIngredient(ItemID.Amber, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
	}
}