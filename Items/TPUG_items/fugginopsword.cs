using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.TPUG_items
{
	public class fugginopsword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("fuggin op sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("haha sword go BRRRRRRRRRR \n Polaris dev weapon");
		}
		
		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableDevItems;
		}


		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 9f;
			item.autoReuse = false;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 1;
				item.useAnimation = 20;
				item.damage = 99999;
				item.shoot = ProjectileID.Bee;
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 1;
				item.useAnimation = 40;
				item.damage = 99999;
				item.shoot = ProjectileID.IchorBullet;
			}
			return base.CanUseItem(player);
		}
	}
}
