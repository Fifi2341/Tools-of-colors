
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.TPUG_items;
using static Terraria.ModLoader.ModContent;

namespace Colorswords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Head)]
	public class RedcandycanearmorH : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Red candy cane Headgear");
			Tooltip.SetDefault("feeling sticky yet?");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 13;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<RedcandycanearmorC>() && legs.type == ModContent.ItemType<RedcandycanearmorL>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "The red spirit of the armor enhances your melee combat ability";
			player.meleeDamageMult =+ 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 25);
			recipe.AddIngredient(ModContent.ItemType<SoulOfChristmas>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
