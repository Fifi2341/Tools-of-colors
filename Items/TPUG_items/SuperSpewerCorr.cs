using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.TPUG_items
{
	public class SuperSpewerCorr : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Super Spewer™");
			Tooltip.SetDefault("*slaps Super Spewer™* this bad boy can spew so many projectiles (gel used to power Super Spewer™ sold seperately)");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = false;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item28;
			item.shoot = ProjectileID.CursedFlameFriendly;
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Gel;
			item.autoReuse = true;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useTime = 5;
				item.useAnimation = 20;
				item.damage = 30;
				item.shoot = ProjectileID.WaterStream;
			}
			else
			{
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useTime = 5;
				item.useAnimation = 40;
				item.damage = 30;
				item.shoot = ProjectileID.CursedFlameFriendly;
			}
			return base.CanUseItem(player);
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .38f;
		}
	}
}
