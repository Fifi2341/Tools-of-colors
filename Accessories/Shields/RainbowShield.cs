using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Accessories.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class RainbowShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Strong!");
				
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = ItemRarityID.Yellow;
			item.accessory = true;
			item.defense = 50;
			
		}

		

		
	}
}