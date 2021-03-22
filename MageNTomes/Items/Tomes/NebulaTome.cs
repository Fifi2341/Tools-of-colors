using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class NebulaTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Strong end game weapon");
		}


		


		public override void SetDefaults()
		{
			item.damage = 80;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 635; 
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.None;
			item.mana = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentNebula, 18);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}