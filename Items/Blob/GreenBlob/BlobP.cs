using System;
using ColorSwords.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ColorSwords.Items.Blob.GreenBlob
{
	public class BlobP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        
		}



		public override void SetDefaults()
		{
			projectile.width = 80;               
			projectile.height = 80;             
			projectile.aiStyle = 1;            
			projectile.friendly = true;        
			projectile.hostile = false;        
			projectile.ranged = false;          
			projectile.penetrate = 90;          
			projectile.timeLeft = 2600;         
			projectile.alpha = 0;            
			projectile.light = 1.5f;           
			projectile.ignoreWater = true;        
			projectile.tileCollide = false;          
			projectile.extraUpdates = 1;           
			aiType = ProjectileID.Bullet;
		}

		

		public override void Kill(int timeLeft)
		{


			Main.PlaySound(SoundID.Item10, projectile.position);
			for (int i = 0; i < 10; i++)
			{
				Dust dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), 0, 0, 100, Color.Lime, 0.8f);
				dust.noGravity = true;
				dust.velocity *= 2f;
				dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), 0f, 0f, 100, Color.Lime, 0.5f);
			}
		}
	}
}

