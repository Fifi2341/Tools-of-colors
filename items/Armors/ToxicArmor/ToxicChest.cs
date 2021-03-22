
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Armors.ToxicArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class ToxicChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("7 minion slots, +200 mana and immmunity to several debuffs");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(11, 0, 0, 0);
			item.rare = 11;
			item.defense = 40;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Silenced] = true;
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Stoned] = true;
			player.buffImmune[BuffID.Webbed] = true;
			player.buffImmune[BuffID.VortexDebuff] = true;
			player.statManaMax2 += 200;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ZombifiedBar", 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}