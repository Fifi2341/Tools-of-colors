
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Armors.GrandGemArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GrandGemLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Leggings");
			Tooltip.SetDefault("Worth milions"
				+ "\n50% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.50f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddIngredient(mod, "Crystals", 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}