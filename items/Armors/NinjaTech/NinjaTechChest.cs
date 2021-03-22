
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.NinjaTech
{
	[AutoloadEquip(EquipType.Body)]
	public class NinjaTechChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Cobalt armor 2077");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Stoned] = true;
			player.buffImmune[BuffID.Webbed] = true;
			player.statManaMax2 += 40;
			
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