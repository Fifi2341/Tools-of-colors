using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GemWorm
{
	[AutoloadEquip]
	public class ZombifiedScarf : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxic scarf");
			Tooltip.SetDefault("Insane life regen and immunity to several debuffs!");
				
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.rare = 11;
			item.accessory = true;
			item.defense = 20;
			item.lifeRegen = 200;
			item.expert = true;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

			{
				player.allDamage += 0.20f; 

			}
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
		}
	}
}