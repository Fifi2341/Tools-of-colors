using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Colorswords.Items.TPUG_items
{
	public class THECANNON : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("THECANNON_NOT_FOUND"); // i made this item in school
			Tooltip.SetDefault("NO IMAGE WAS FOUND FOR TPUG/Items/THECANNON. PLEASE CONTACT THE DEVELOPER IF YOU SEE THIS ERROR");
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
			item.shoot = ProjectileID.JestersArrow;
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = true;
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .38f;
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