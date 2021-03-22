using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.HealingStaffs
{
	public class HealingStaffIV : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing Staff IV");
			Tooltip.SetDefault("Upgrade to Healing staff III");
				
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
			item.rare = 8;
			item.healLife = 50; 
			item.potion = false;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.mana = 11;
		}
		public override void AddRecipes()   
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreaterHealingPotion, 40);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
			recipe.AddIngredient(mod, "HexaMatter", 10);
			recipe.AddIngredient(mod, "HealingStaffIII");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}