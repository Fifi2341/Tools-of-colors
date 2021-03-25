using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace Colorswords.Items.TPUG_items
{
	public class SoulOfChristmas: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul of Christmas"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Christmas spirit");
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
	}
}
