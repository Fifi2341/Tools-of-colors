using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.HealingStaffs
{
	public class HealingStaffII : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing Staff II");
			Tooltip.SetDefault("Upgrade to Healing staff I");
				
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
			item.rare = 3;
			item.healLife = 10; 
			item.potion = false;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.mana = 9;
		}
		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HealingPotion, 20);
			recipe.AddIngredient(mod, "HealingStaff", 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}