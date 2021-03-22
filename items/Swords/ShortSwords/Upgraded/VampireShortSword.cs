using ColorSwords.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.ShortSwords.Upgraded
{
	public class VampireShortSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Will heal life"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 140;  
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 65, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 50;
			item.healLife = 5;
		}


	

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 20);
			recipe.AddIngredient(ItemID.VampireKnives, 1);
			recipe.AddTile(TileID.MythrilAnvil); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
