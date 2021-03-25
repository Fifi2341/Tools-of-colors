using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.TPUG_items
{
	public class Stone_cleaver: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stone War Axe"); 
			Tooltip.SetDefault("Choppy choppy choppy");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.axe = 60;
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
				item.useTime = 15;
				item.useAnimation = 20;
				item.damage = 10;
				item.shoot = ProjectileID.None;
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 25;
				item.useAnimation = 40;
				item.damage = 20;
				item.shoot = ProjectileID.None;
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
