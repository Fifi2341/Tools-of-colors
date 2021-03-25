using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Colorswords.Items.TPUG_items
	public class BATNOTFOUND: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("BAT NOT FOUND"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("CANNOT FIND GLITCHBAT.BATS.AZERCADIUM. PLEASE MOVE THIS TO THE RIGHT DIRECTORY" + "/n COMMAND 'LEFTCLICK' WILL SHOOT PROJECTILE.ID.BEE" + "/n COMMAND 'RIGHTCLICK' WILL SWING A BAT WITH MORE DAMAGE");
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
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useTime = 30;
				item.useAnimation = 20;
				item.damage = 10;
				item.shoot = ProjectileID.Bee;
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 20;
				item.shoot = ProjectileID.None;
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LiquidERROR>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}