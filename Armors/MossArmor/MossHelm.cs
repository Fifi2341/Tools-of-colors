using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.MossArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class MossHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Now I look like that swamp thing, eh!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 6;
			item.defense = 10;
			item.lifeRegen = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<MossChest>() && legs.type == ItemType<MossLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+2 minion slots and minion damage increase";
			player.minionDamage += 1f;
			player.maxMinions++;

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