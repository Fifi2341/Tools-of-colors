using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Pickaxes
{
	public class UltimaMiner : ModItem
	{
		public override void SetStaticDefaults()
		{
		     DisplayName.SetDefault("UltimaMiner"); 
			Tooltip.SetDefault("Ultimate mining machina");
		}

		public override void SetDefaults()
		{
			item.damage = 111;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.pick = 275;
			item.axe = 50; 
			item.knockBack = 6;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorPickaxe");
			recipe.AddIngredient(mod, "ColorBar", 10);
			recipe.AddIngredient(mod, "UltimaBar", 5);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}