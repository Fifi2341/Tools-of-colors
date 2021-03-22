using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Blob.GreenBlob.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BlobHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A helm for your safety!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
			item.defense = 10;
			item.lifeRegen = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<BlobChest>() && legs.type == ItemType<BlobJeans>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Small damage increase";
			player.allDamage -= 0.2f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GreenBlob", 5);
			recipe.AddTile(TileID.Benches); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}