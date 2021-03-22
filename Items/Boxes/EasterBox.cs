using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.Items.Guns.Miniguns;

namespace ColorSwords.Items.Boxes
{
	public class EasterBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Easter Box 2021");
			Tooltip.SetDefault("Contains: \n Easter Tones: 100% ");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.rare = 11;
			
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
				player.QuickSpawnItem(ItemType<EasterTones>());

		}

		
	}
}