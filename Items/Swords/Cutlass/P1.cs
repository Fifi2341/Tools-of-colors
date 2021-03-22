using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Swords.Cutlass
{
	public class P1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			
			
		}

		public override void SetDefaults() 
		{
			item.damage = 10;   
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 2;
			item.shoot = 157; 
			item.shootSpeed = 6f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<Projectiles.Cutlass.PirateSkelly>();
			item.useAmmo = AmmoID.None;
		}

		
	}
}