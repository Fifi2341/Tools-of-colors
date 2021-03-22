using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.HeavyArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class HeavyHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tank on legs");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableBallisticItems;
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 11;
			item.defense = 50;
		
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<HeavyArmor>() && legs.type == ItemType<HeavyLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Hp increase";
			player.statLifeMax2 += 150;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.TurtleShell, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}