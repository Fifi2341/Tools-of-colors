using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.TPUG_items
{
	public class NULL : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("NULL"); // i made this item in school
			Tooltip.SetDefault("NO NAME WAS FOUND FOR TPUG/Items/NULL. PLEASE CONTACT THE DEVELOPER IF YOU SEE THIS ERROR");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = false;
			item.magic = true;
			item.mana = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item28;
			item.shoot = mod.ProjectileType("NULL_proj");
			item.shootSpeed = 9f;
			item.autoReuse = false;
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
