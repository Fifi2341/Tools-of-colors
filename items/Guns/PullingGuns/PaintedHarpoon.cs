using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Guns.PullingGuns
{
	public class PaintedHarpoon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shots hook, pulling toward target");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 315;
			item.shootSpeed = 5f;
			item.useAmmo = AmmoID.None;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}