using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Npcs.TheBigAssShield
{
	public class TheBigAssShield_Proj : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shield Shard");
		}

		public override void SetDefaults() {
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.light = 10f;  
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			aiType = ProjectileID.WoodenArrowHostile;
		}
    }
}
