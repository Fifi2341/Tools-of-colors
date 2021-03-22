using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.Food
{
	public class Coke : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Healthy and tasty^^!");
				
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
			item.rare = 2;
			item.healLife = 20; 
			item.potion = true;
			item.value = Item.buyPrice(0, 1, 50, 0);
		}

		
	}
}
