
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.MossArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class MossChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			
			Tooltip.SetDefault("How do I look?");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 6;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{

			player.maxMinions++;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Crystals", 5);
			recipe.AddIngredient(mod, "MossFragment", 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}