using Terraria;
using Terraria.Localization;
using ColorSwords.Items.Accessories.Shields;
using ColorSwords.Items.Bars;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ColorSwords.Items.Accessories.TitanShields
{
	[AutoloadEquip(EquipType.Shield)]
	public class RainbowTitans : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Extremely Strong! Grants plenty of bonuses");
				
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = Item.buyPrice(1, 50, 0, 0);
			item.rare = ItemRarityID.Red;
			item.accessory = true;
			item.defense = 100;
			item.lifeRegen = 20;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

			{
				player.allDamage += 0.20f;

			}
		}
		public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RainbowShield");
			recipe.AddIngredient(mod, "OldGem", 1);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
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
			player.statManaMax2 += 75;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
		}
	}
}
