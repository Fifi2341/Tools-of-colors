using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World;
using Terraria.GameContent;
using System.Timers;
using On.Terraria;
using IL.Terraria;

namespace Colorswords.Projectiles
{
	public class NULL_proj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NULL");
		}

		public override void SetDefaults()
		{
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.light = 30f;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.aiStyle = 5;
		}

		public float Timer
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}
		public override void AI()
		{

		// Other code...
		Timer++;
			if (Timer > 120)
			{
				// Our timer has finished, do something here:
				// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
			
				projectile.CloneDefaults(ProjectileID.CrystalLeaf);
				projectile.minionSlots = 1;
				Timer = 0;
			}
			// Other code...
		}
	}
}