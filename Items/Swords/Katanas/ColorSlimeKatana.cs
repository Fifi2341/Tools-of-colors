using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.Katanas
{
	public class ColorSlimeKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("For superior ninja!"); 
		}

		public override void SetDefaults()
		{
			item.damage = 80;   
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 45, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 50;
			item.buffType = BuffType<Buffs.NinjaBuff>();
		}


	


		public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddIngredient(mod, "YellowSmallRock", 5);
			recipe.AddIngredient(ItemID.Gel, 150);
			recipe.AddIngredient(ItemID.Katana, 1);
			recipe.AddTile(TileID.MythrilAnvil); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
