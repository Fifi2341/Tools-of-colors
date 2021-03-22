using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Accessories
{
	
	public class NinjaTechEmblem : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Grants live regeneration and dash");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 5;
			item.accessory = true;
			item.lifeRegen = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.dash = 1;
			player.allDamage += 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Crystals", 5);
			recipe.AddIngredient(mod, "BlueBar", 10);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}