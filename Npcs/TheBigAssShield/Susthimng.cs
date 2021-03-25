using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TPUG.Tiles;
using TPUG.Items;
using TPUG.TheBigAssShield;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class Susthimng: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sus shield");
			Tooltip.SetDefault("shield sus");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.consumable = true;
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<TheBigAssShield.TheBigAssShieldd>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}