using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.GrandGemArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class GrandGemHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Grants life regeneration");
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
			return body.type == ItemType<GrandGemArmor>() && legs.type == ItemType<GrandGemLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+ 50 hp";
			player.statLifeMax2 += 50;
			
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