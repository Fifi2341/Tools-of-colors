using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ColorSwords.Items.Swords.ShortSwords
{
	public class Vigilante : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("if you're in the market for OP order, the Vigilante is the only choice in the town"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 85;  
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.shootSpeed = 5f;
			item.knockBack = 20;
			item.shoot = 14;
			item.useAmmo = AmmoID.None;
			item.value = Item.buyPrice(2, 50, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 75;
			
		}


	

	
	public override void AddRecipes()      
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BlueBar", 25);
			recipe.AddIngredient(mod, "Mecha", 10);
			recipe.AddIngredient(mod, "YellowSmallRock", 3);
			recipe.AddIngredient(mod, "Crystals", 1);
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GrenadeI, damage, knockBack, player.whoAmI);

			return true;
		}
	}
}
