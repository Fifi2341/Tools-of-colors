using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TPUG.Tiles;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class MiniShield: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mini Shield");
			Tooltip.SetDefault("t i n y");
		}

		public override void SetDefaults() 
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.maxStack = 1;
			item.consumable = false;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 += 15;
			player.statDefense += 20;
			player.statManaMax += 15;
			player.lifeRegen += 10;
			player.dash += 1;
		}
	}
}