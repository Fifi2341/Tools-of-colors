using ColorSwords.Items.BatKing;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Armors.BatArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class BatLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bat Leggings");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 3;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BatKingWing");
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}