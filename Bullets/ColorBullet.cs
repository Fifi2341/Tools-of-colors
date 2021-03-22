
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Bullets
{
	public class ColorBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Nock'em out!");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             
			item.knockBack = 1.5f;
			item.value = Item.buyPrice(0, 0, 0, 50);
			item.rare = 3;
			item.shoot = ProjectileType<Projectiles.BulletsP.ColorBullet>();  
			item.shootSpeed = 16f;                  
			item.ammo = AmmoID.Bullet;            
		}

		
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Regeneration, 1500);
			}
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 3);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}