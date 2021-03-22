using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class TeslaTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Alien weaponry!");
		}


		


		public override void SetDefaults()
		{
			item.damage = 99;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = 443; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.None;
			item.mana = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MartianConduitPlating, 99);
			recipe.AddIngredient(ItemID.UnicornHorn, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}