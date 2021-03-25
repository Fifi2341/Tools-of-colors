using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using ColorSwords.Projectiles;
using System.Timers;
using System;

namespace ColorSwords.Npcs.TheBigAssShield
{
	[AutoloadBossHead]
	public class TheBigAssShieldd: ModNPC
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Grand Shield");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 2300;
			npc.damage = 30;
			npc.defense = 30;
			npc.knockBackResist = 0.3f;
			npc.width = 70;
			npc.alpha = 0;
			npc.height = 46;
			animationType = 244; //npc.position and npc.velocity use these lol
			aiType = 138;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.buffImmune[24] = true;
			music = MusicID.Boss2;
			bossBag = ModContent.ItemType<TBASTeasureBag>();
			//npc.HitSound = mod.GetLegacySoundSlot((SoundType)3, "Sounds/Clank");
			npc.lifeRegen = 1;
		}


		public int Timer;
		public override void BossLoot(ref string name, ref int potionType)
		{
			if (Terraria.Main.expertMode)
                Terraria.Item.NewItem(npc.getRect(), mod.ItemType("TBASTeasureBag"));
			else
			{
				switch (Main.rand.Next(1, 7))
				{
					case 1:
						Item.NewItem(npc.getRect(), mod.ItemType("SacrificialKnife"));
						break;
					case 2:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASGun"));
						break;
					case 3:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASSword"));
						break;
					case 4:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASStaff"));
						break;
					case 5:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASyoyo"));
						break;
				}
				switch (Main.rand.Next(1, 7))
				{
					case 1:
						Item.NewItem(npc.getRect(), mod.ItemType("SacrificialKnife"));
						break;
					case 2:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASGun"));
						break;
					case 3:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASSword"));
						break;
					case 4:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASStaff"));
						break;
					case 5:
						Item.NewItem(npc.getRect(), mod.ItemType("TBASyoyo"));
						break;
				}
			}
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.7f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.8f);
		}
		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<TheBigAssShield_Proj>(), (int)(npc.damage / 2), 3, Main.myPlayer);
		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X - 4 + Main.rand.Next(9), -Main.rand.Next(6, 9), ModContent.ProjectileType<TheBigAssShield_Proj>(), (int)(npc.damage / 2), 3, Main.myPlayer);
		}
		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			player.AddBuff(BuffID.OnFire, 600, true);
		}
		private int oldliferegen;
		public override void AI()
		{
			if (npc.life <= 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("PosessedSword"));
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("PosessedSword"));
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("PosessedSword"));
			}
			Timer++;
			if (npc.life > 1150)
			{
				if (Timer > 30)
				{
					float rand = Main.rand.NextFloat();
					if (rand < .1f)
					{
						NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("Spikeball"));
						npc.defense = 15;
						npc.lifeRegen = npc.lifeRegen - 1;
						npc.reflectingProjectiles = false;
						Timer++;
						if (Timer > 60)
						{
							NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("Spikeball"));
							Timer = 0;
						}
					}

					else if (rand < .5f)
					{
						npc.reflectingProjectiles = true;
						npc.defense = 100;
						npc.lifeRegen = npc.lifeRegen + 2;
					}
					else if (rand < .10f)
					{
						npc.lifeRegen = 1;
						npc.defense = 30;
						npc.reflectingProjectiles = false;
					}

					Timer = 0;
				}
			}
			else
			{

				float rand = Main.rand.NextFloat();
				if (rand < .1f)
				{
					NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("Spikeball"));
					npc.defense = 10;
					if (npc.lifeRegen > 1) 
					{
						npc.lifeRegen = npc.lifeRegen - 1;
					}
					npc.reflectingProjectiles = false;
					Timer++;
					if (Timer > 30)
					{
						NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("Spikeball"));
						Timer = 0;
					}

				}
				else if (rand < .10f)
				{
					npc.lifeRegen = 1;
					npc.defense = 15;
					npc.reflectingProjectiles = false;

				}
			}
		}
		

		private void Movement(Vector2 targetPos, float speedModifier, float cap = 12f)
		{
			if (npc.Center.X < targetPos.X)
			{
				npc.velocity.X += speedModifier;
				if (npc.velocity.X < 0)
					npc.velocity.X += speedModifier * 2;
			}
			else
			{
				npc.velocity.X -= speedModifier;
				if (npc.velocity.X > 0)
					npc.velocity.X -= speedModifier * 2;
			}
			if (npc.Center.Y < targetPos.Y)
			{
				npc.velocity.Y += speedModifier;
				if (npc.velocity.Y < 0)
					npc.velocity.Y += speedModifier * 2;
			}
			else
			{
				npc.velocity.Y -= speedModifier;
				if (npc.velocity.Y > 0)
					npc.velocity.Y -= speedModifier * 2;
			}
			if (Math.Abs(npc.velocity.X) > cap)
				npc.velocity.X = cap * Math.Sign(npc.velocity.X);
			if (Math.Abs(npc.velocity.Y) > cap)
				npc.velocity.Y = cap * Math.Sign(npc.velocity.Y);
		}
	}
}
