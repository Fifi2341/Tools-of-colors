using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GoldPlated
{
	public class GoldPlatedMegaShark : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rihc! :stonks: ");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
		}

		public override void SetDefaults()
		{
			item.damage = 222;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 50f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GemGoldBar", 10);
			recipe.AddIngredient(ItemID.Megashark);
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