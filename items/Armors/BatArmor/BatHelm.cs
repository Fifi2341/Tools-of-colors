using System;
using ColorSwords.Items.BatKing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.BatArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class BatHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Great, I look like that little annoying thing now");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 3;
			item.defense = 5;
			item.lifeRegen = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<BatLeggins>() && legs.type == ItemType<BatChest>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+1 minion slots and minion damage increase";
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
			recipe.AddIngredient(mod, "BatKingWing");
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}