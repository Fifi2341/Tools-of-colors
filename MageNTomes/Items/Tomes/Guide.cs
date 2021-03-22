using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using ColorSwords.MageNTomes.Projectiles;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class Guide : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault(":   |");
		}


		


		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(0, 0, 70, 0);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<GuideP>();
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.None;
			item.mana = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}