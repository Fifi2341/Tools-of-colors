using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;


namespace ColorSwords.Items.GoldPlated
{ 
	public class GoldPlatedTerrorTurtle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rip my turtle 7/11/2020 \n Fiery's dev weapon ");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableDevItems;
		}

		public override void SetDefaults()
		
		{

			item.damage = 890;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 227; 
			item.shootSpeed = 33f;
			item.useAmmo = AmmoID.None;
		}


			

		
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}



		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2); 
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; 
		}
	}
}
