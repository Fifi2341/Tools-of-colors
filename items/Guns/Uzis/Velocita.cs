using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Guns.Uzis
{
	public class Velocita : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Small and reliable!");
		}

		public override void SetDefaults()
		{
			item.damage = 650;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 9;
			item.value = Item.buyPrice(3, 50, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 50f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "UltimateVelocity");
			recipe.AddIngredient(mod, "ColorBar", 10);
			recipe.AddIngredient(mod, "UltimaBar", 5);
			recipe.AddIngredient(ItemID.Uzi, 1);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		

		
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) 
			{
				type = ProjectileID.BulletHighVelocity; 
			}
			return true;
		}

		
	}
}