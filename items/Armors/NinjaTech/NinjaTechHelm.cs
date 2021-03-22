using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.NinjaTech
{
	[AutoloadEquip(EquipType.Head)]
	public class NinjaTechHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Grants life regeneration and futuristic looks");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.defense = 10;
			item.lifeRegen = 10;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<NinjaTechChest>() && legs.type == ItemType<NinjaTechLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Become invisible";
			player.AddBuff(BuffID.Invisibility, 3);

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Crystals", 5);
			recipe.AddIngredient(mod, "BlueBar", 10);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}