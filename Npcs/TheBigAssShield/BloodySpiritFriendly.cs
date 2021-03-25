using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class BloodySpiritFriendly : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sacrificial knife");
		}

		public override void SetDefaults() {
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.light = 10f;  
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.aiStyle = 8;
		}
    }
}