using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.UltimaArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class UltimaHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Grants life regeneration");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.rare = 11;
			item.defense = 30;
			item.lifeRegen = 100;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<UltimaChest>() && legs.type == ItemType<UltimaLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "500 hp";
			player.statLifeMax2 += 500;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "UltimaBar", 10);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}