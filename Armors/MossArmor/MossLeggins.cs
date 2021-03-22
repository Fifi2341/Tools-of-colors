
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Armors.MossArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class MossLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moss Leggings");
			Tooltip.SetDefault("Comfortable!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 6;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Crystals", 5);
			recipe.AddIngredient(mod, "MossFragment", 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}