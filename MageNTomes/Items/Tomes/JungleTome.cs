using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class JungleTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("I can smell the jungle");
		}


		


		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(0, 7, 0, 0);
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 229; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.None;
			item.mana = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 20);
			recipe.AddIngredient(ItemID.Stinger, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}