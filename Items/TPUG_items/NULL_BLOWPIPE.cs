using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.TPUG_items
{
	public class NULL_BLOWPIPE : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("NO ITEM WAS FOUND FOR TPUG/Items/NULL_BLOWPIPE.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.CloneDefaults(ItemID.Blowpipe);
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
			item.shoot = mod.ProjectileType("NULL_proj");
			item.shootSpeed = 9f;
			item.autoReuse = false;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, -7);
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
