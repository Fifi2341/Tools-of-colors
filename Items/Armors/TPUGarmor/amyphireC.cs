
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Colorswords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Body)]
	public class amyphireC : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("amyphire robe");
			Tooltip.SetDefault("a powerful combonation of gems fit into a robe" + "/n you now have +40 mana and increaces magic damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player) {
			player.statManaMax2 += 40;
			player.magicDamageMult = 1.3f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"amyphire",10);
			recipe.AddIngredient(ItemID.Robe, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}