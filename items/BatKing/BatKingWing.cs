using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.BatKing
{
	public class BatKingWing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Might be used to craft something, dropped by Bat King");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
		}


		

	}
}