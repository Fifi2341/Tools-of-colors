using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class MoltenTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Molten tome! Wait...The book is burning!");
		}


		


		public override void SetDefaults()
		{
			item.damage = 40;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 34; 
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.None;
			item.mana = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}