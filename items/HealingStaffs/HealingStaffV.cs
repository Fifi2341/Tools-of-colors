using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.HealingStaffs
{
	public class HealingStaffV : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing Staff V");
			Tooltip.SetDefault("Upgrade to Healing staff IV");
				
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
			item.useTime = 90;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 1;
			item.consumable = false;
			item.rare = 11;
			item.healLife = 250; 
			item.potion = false;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.mana = 20;
		}
		public override void AddRecipes()   
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 500);
			recipe.AddIngredient(ItemID.LunarBar, 100);
			recipe.AddIngredient(mod, "OldGem", 2);
			recipe.AddIngredient(mod, "HealingStaffIV");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}