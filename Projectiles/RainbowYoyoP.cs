using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Projectiles
{
	public class RainbowYoyoP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 14.5f;
			
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 300f;
			
			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 14f;
		}

		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 16;
			
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
			projectile.scale = 1f;
		}
		

		public override void PostAI()
		{
			if (Main.rand.NextBool())
			{
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 16);
				dust.noGravity = true;
				dust.scale = 1.6f;
			}
		}
	}
}