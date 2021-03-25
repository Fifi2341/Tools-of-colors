
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Colorswords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Head)]
	public class amyphireH : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("amyphire hat");
			Tooltip.SetDefault("a powerful combonation of gems fit into a hat" + "/n you now have +10 mana and increaces magic crit");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 1;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ERRORC>() && legs.type == ModContent.ItemType<ERRORL>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "as you embrace the power of amyphire, your magic power increaces";
			player.magicCrit += 2;
			player.magicDamageMult = 1.1f;
		}

		public override void UpdateEquip(Player player) {
			player.statManaMax2 += 10;
			player.magicCrit += 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"amyphire",10);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}