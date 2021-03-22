using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ColorSwords.Items.Swords.Punches
{
	public class HellBatEleminator : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Show 'em who is the boss!");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;  
			item.melee = true;
			item.width = 100;
			item.noUseGraphic = true;
			item.height = 100;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 200;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.crit = 20;
		}

	
	public override void AddRecipes()     
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Anvils); ;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
