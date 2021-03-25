using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace ColorSwords.Items.TPUG_items
{
	public class Superfire: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Superfire"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("whAT OW OW HOT");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
		}
		/*
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddIngredient(ItemID.IceTorch, 5);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddIngredient(ItemID.ShadowFlameKnife, 1);
			recipe.AddTile(ModContent.TileType<LavaCaster>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		*/
	}
}
