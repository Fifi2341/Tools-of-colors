using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.HealingStaffs
{
	public class HealingStaffIII : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing Staff III");
			Tooltip.SetDefault("Upgrade to Healing staff II");
				
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
			item.rare = 4;
			item.healLife = 15; 
			item.potion = false;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.mana = 10;
		}
		public override void AddRecipes()   
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HealingPotion, 40);
			recipe.AddIngredient(ItemID.PixieDust, 20);
			recipe.AddIngredient(mod, "HealingStaffII");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}