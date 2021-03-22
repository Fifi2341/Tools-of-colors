using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.HealingStaffs
{
	public class HealingStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Better than potion!");
				
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableHealingStaffItems;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
			item.useStyle = 1;
			item.useAnimation = 17;
			item.useTime = 100;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 1;
			item.consumable = false;
			item.rare = 2;
			item.healLife = 5;
			item.potion = false;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.mana = 10;
		}
		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HealingPotion, 10);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}