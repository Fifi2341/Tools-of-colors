using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GoldPlated
{
	public class GoldPlatedSniperRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("5n1p3r");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
		}

		public override void SetDefaults()
		{
			item.damage = 5555;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 100;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 40;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.autoReuse = true;
			item.shoot = 706; 
			item.shootSpeed = 50f;
			item.useAmmo = AmmoID.None;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GemGoldBar", 10);
			recipe.AddIngredient(ItemID.SniperRifle, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .85f;
		}

		
	}
}