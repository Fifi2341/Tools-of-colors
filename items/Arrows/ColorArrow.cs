
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Arrows
{
	public class ColorArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Colorful Arrow for every archer!");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             
			item.knockBack = 1.5f;

			item.value = Item.buyPrice(0, 0, 0, 50);
			item.rare = 4;
			item.shoot = ProjectileType<Projectiles.ArrowsP.ColorArrowP>();   
			item.shootSpeed = 1f;                  
			item.ammo = AmmoID.Arrow;             
		}

		
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Hunter, 300);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 100);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.Amber, 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}