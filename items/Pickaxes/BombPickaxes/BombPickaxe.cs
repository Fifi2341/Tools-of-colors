using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Pickaxes.BombPickaxes
{
	public class BombPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("boom boom for some fast minning!"); 
		}

		public override void SetDefaults()
		{
			item.damage = 20;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.pick = 200;    
			item.shoot = 28;
			item.value = Item.buyPrice(0, 80, 0, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bomb, 999);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}