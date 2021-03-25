using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using ColorSwords.Projectiles;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class Spikeball : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spikeball");
			Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 5;
			npc.damage = 5;
			npc.defense = 999999;
			npc.knockBackResist = -1f;
			npc.width = 22;
			npc.alpha = 0;
			npc.height = 22;
			animationType = 244;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}
		public int Timer;
        private int life;

        public override void AI()
        {
			Timer++;
			if (Timer > 120);
			{
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<Sacrificialknifehostile>(), (int)(npc.damage / 2), 3, Main.myPlayer);
				npc.life = 0;
				npc.HitEffect(1);
				npc.active = false;
			}
		}
	}
}
