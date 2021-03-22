using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.Food
{
	public class AppleJuice : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Why does it cost 999$?");
				
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = 11;
			item.healLife = 250; 
			item.potion = true;
			item.value = Item.buyPrice(10, 50, 0, 0);
		}

		
	}
}
