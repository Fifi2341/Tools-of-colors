using ColorSwords.TPUG_items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Colorswords.Items.Armors.TPUGarmor
{
	[AutoloadEquip(EquipType.Head)]
	public class StonearmorH : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Stone Headgear");
			Tooltip.SetDefault("why isn't this hurting your head?");
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
			return body.type == ModContent.ItemType<StonearmorC>() && legs.type == ModContent.ItemType<StonearmorL>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "The stone empowers you and your combat ability is rising, so is your dash";
			player.allDamage = +2;
			player.dash =+ 1;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
