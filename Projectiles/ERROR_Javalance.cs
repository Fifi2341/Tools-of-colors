using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Colorswords.Projectiles
{
	public class ERROR_Javalance : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.ranged = true;
			projectile.timeLeft = 3000;
			projectile.ignoreWater = true;
			aiType = 1;
			projectile.ranged = true;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			int type = Main.rand.Next(new int[] { BuffID.Frostburn, BuffID.Poisoned, BuffID.OnFire});
		}
		public override void OnHitPlayer(Player target, int damage, bool crit)
		{

		}
		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
		}
	}
}