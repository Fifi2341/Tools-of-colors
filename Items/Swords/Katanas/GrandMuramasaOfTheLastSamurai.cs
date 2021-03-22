using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.Katanas
{
	public class GrandMuramasaOfTheLastSamurai : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Its weapon or artifact?"); 
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableExperimentalItems;
		}

		public override void SetDefaults()
		{
			item.damage = 888;   
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 8;
			item.useAnimation = 20;
			item.noUseGraphic = true;
			item.channel = true;
			item.shootSpeed = 20f;
			item.useStyle = 1;
			item.knockBack = 40;
			item.value = Item.buyPrice(1, 45, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
			item.buffType = BuffType<Buffs.NinjaBuff2>();
			item.shoot = mod.ProjectileType("SwingB");
		}


	


		public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 35);
			recipe.AddIngredient(mod, "ColorSlimeKatana");
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddIngredient(ItemID.Katana);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ItemID.FragmentSolar, 99);
			recipe.AddTile(TileID.LunarCraftingStation); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
