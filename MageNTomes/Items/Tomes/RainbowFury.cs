using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class RainbowFury : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Similiar to rainbow gun!");
		}


		


		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(0, 35, 0, 0);
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 250; 
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.None;
			item.mana = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 25);
			recipe.AddIngredient(ItemID.CrystalShard, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}