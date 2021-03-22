
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.BatKing
{
	[AutoloadEquip(EquipType.Wings)]
	public class BatKingSoul : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fly like a bat!");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 3;
			item.accessory = true;
			item.expert = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 60;
			if (GetInstance<ColorSwordsConfig>().isBatNerfEnabled)
			{
				player.wingTimeMax = 1;
			}
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.25f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5f;
			acceleration *= 0.5f;
		}

		
	}
}