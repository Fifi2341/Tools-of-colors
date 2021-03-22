using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;
using Terraria.ModLoader;
using ColorSwords;
using ColorSwords.Items.Boxes;

namespace ColorSwords.Npcs.Ultima
{
    [AutoloadBossHead]
    public class UltimaNova : ModNPC
    {
        private int ai;
        private int attackTimer = 0;
        private bool checkDead = false;

        private double counting;
        private int deadTimer = 0;
        private bool fastSpeed = false;
        private int frame;
        private int healTime = 0;
        private int healTimeKey;
        private bool secondState;
        private bool secondState2;
        private bool stunned;
        private int stunnedTimer;

        public override void SetDefaults()
        {
            npc.lifeMax = 40000;
            npc.damage = 80;
            npc.defense = 30;
            npc.knockBackResist = 0f;
            npc.width = 204;
            npc.height = 160;
            npc.npcSlots = 5f;
            npc.HitSound = SoundID.NPCHit1;
            npc.noGravity = true;
            npc.npcSlots = 5f;
            npc.boss = true;
            npc.value = Item.buyPrice(0, 50, 0, 0);
            npc.noTileCollide = true;
            Main.npcFrameCount[npc.type] = 6;
            //bossBag = mod.ItemType("A");
            music = MusicID.Boss2;
            npc.scale = 2;
        }

        public override void ScaleExpertStats(int playerXPlayers, float bossLifeScale)
        {
            if (playerXPlayers > 1)
            {
                npc.lifeMax = (int)(45000 + (double)npc.lifeMax * 0.2 * (double)playerXPlayers);
            }
            else
            {
                npc.lifeMax = 45000;
            }
            npc.damage = (int)(npc.damage * 0.65f);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultima hype nova Spider");
            
        }



        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                //  npc.DropBossBags();
                Item.NewItem(npc.getRect(), ModContent.ItemType<UltimaBoxLarge>());
            }
            else
            {

                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<UltimaBoxMedium>());
                }
            }
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = 499;
        }

        public override void AI()
        {
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;
            npc.rotation = 0.0f;
            npc.netAlways = true;
            npc.TargetClosest(true);
            if (npc.life >= npc.lifeMax)
                npc.life = npc.lifeMax;
            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active)
            {
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.1f;
                if (npc.timeLeft > 10)
                {
                    npc.timeLeft = 10;
                    return;
                }
            }
            if (this.stunned)
            {
                npc.velocity.Y = 0.0f;
                npc.velocity.X = 0.0f;
                ++this.stunnedTimer;
                if (this.stunnedTimer >= 105)
                {
                    this.stunned = false;
                    this.stunnedTimer = 0;
                }
            }
            if (!this.secondState)
            {
                float distance = 160f;
                float k = 1.26f;
                for (int count = 0; count < 10; count++)
                {
                    Vector2 spawn = npc.Center + distance * ((float)count * k).ToRotationVector2();
                    NPC.NewNPC((int)spawn.X, (int)spawn.Y, mod.NPCType("UltimaShield"), 0, (float)npc.whoAmI, 0.0f, (float)count, 0.0f, 255);
                }
                this.secondState = true;
            }
            ++this.ai;
            npc.ai[0] = (float)this.ai * 1f;
            int velocity = (int)((double)npc.ai[0] / 50f);
            bool speedB = ((double)npc.life <= npc.lifeMax * 0.6 ? true : false);
            int speedV = (int)(speedB ? 6f : 0f);
            if ((double)npc.ai[0] < 350.0 && !this.stunned)
            {
                this.frame = 0;
                ColorSwordsHelper.MoveTowards(npc, target, (int)(Vector2.Distance(target, npc.Center) > 300 ? (Main.expertMode ? 24f : 20f) : (Main.expertMode ? 9f : 7f)) + speedV, 30f);
                for (int k = 0; k < 5 * (npc.ai[0] / 50); k++)
                {
                    
                }
                npc.netUpdate = true;
                if ((double)npc.ai[0] % 349.0 == 0)
                {
                    this.healTime += 1;
                    //CombatText.NewText(new Rectangle((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height), Color.Red, "+1", false, false);
                }
            }
            else if ((double)npc.ai[0] >= 350.0 && (double)npc.ai[0] < 450.0)
            {
                this.stunned = true;
                this.frame = 2;
                ColorSwordsHelper.MoveTowards(npc, target, (int)(Vector2.Distance(target, npc.Center) > 300 ? (Main.expertMode ? 24f : 20f) : (Main.expertMode ? 9f : 7f)) + speedV, 30f);
                for (int k = 0; k < 2 * (npc.ai[0] / 45); k++)
                {
                    
                }
                player.AddBuff(mod.BuffType("SpiderRevenge"), Main.expertMode ? 560 : 420, true);
                npc.netUpdate = true;
            }
            if ((double)npc.ai[0] >= 450.0)
            {
                this.frame = 1;
                this.stunned = false;
                npc.defense = 40;
                if (!this.fastSpeed)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        this.fastSpeed = true;
                        npc.ai[2] = 0f;
                    }
                    else
                    {
                        this.fastSpeed = true;
                        npc.ai[2] = 1f;
                    }
                }
                else
                {
                    if ((double)npc.ai[2] == 0.0)
                    {
                        if ((double)npc.ai[0] % 50 == 0)
                        {
                            float speed = 21f + speedV;
                            if (Main.expertMode)
                                speed = 25f + speedV;
                            Vector2 vector_ = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
                            float x = player.position.X + (float)(player.width / 2) - vector_.X;
                            float y = player.position.Y + (float)(player.height / 2) - vector_.Y;
                            float distanse = (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y);
                            float resuceFactor = speed / distanse;
                            npc.velocity.X = x * resuceFactor;
                            npc.velocity.Y = y * resuceFactor;
                        }
                    }
                    else
                    {
                        npc.alpha = 180;
                        if ((double)npc.ai[0] % 35 == 0)
                        {
                            float speed = 28f + speedV;
                            if (Main.expertMode)
                                speed = 30f + speedV;
                            Vector2 vector_ = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
                            float x = player.position.X + (float)(player.width / 2) - vector_.X;
                            float y = player.position.Y + (float)(player.height / 2) - vector_.Y;
                            float distanse = (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y);
                            float resuceFactor = speed / distanse;
                            npc.velocity.X = x * resuceFactor;
                            npc.velocity.Y = y * resuceFactor;
                        }
                    }
                }
                npc.netUpdate = true;
            }
            else
                npc.defense = 22;
            if ((double)npc.ai[0] >= 650.0)
            {
                this.ai = 0;
                npc.alpha = 0;
                npc.ai[2] = 0;
                this.fastSpeed = false;
            }
            if ((double)npc.life <= npc.lifeMax * 0.333)
            {
                npc.alpha = 0;
                this.ai = 0;
                this.frame = 0;
                npc.ai[1] += 1 + ((double)npc.life <= npc.lifeMax * 0.111 ? 1 : ((double)npc.life <= npc.lifeMax * 0.222 ? 1 : 0));
                npc.defense = 25;
                if ((double)npc.ai[1] < 200.0)
                {
                    this.frame = 2;
                    npc.velocity.X = 0f; npc.velocity.Y = 0f;
                }
                if ((double)npc.ai[1] < 200.0)
                    for (int k = 0; k < 3 * (npc.ai[1] / 50); k++)
                    {
                        
                    }
                if ((double)npc.ai[1] % 200.0 == 0 && (double)npc.ai[1] <= 399.0)
                {
                    this.attackTimer += 1;
                    if (this.attackTimer <= 2)
                    {
                        Vector2 shootPos = npc.Center;
                        float inaccuracy = 10f * (npc.life / npc.lifeMax);
                        Vector2 shootVel = target - shootPos + new Vector2(Main.rand.NextFloat(-inaccuracy, inaccuracy), Main.rand.NextFloat(-inaccuracy, inaccuracy));
                        shootVel.Normalize();
                        shootVel *= 14f;
                        Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 88);
                        for (int k = 0; k < (Main.expertMode ? 5 : 3); k++) Projectile.NewProjectile(shootPos.X + (float)(-100 * npc.direction) + (float)Main.rand.Next(-40, 41), shootPos.Y - (float)Main.rand.Next(-50, 40), shootVel.X, shootVel.Y, mod.ProjectileType("GalaxyHostile"), npc.damage / 3, 5f);
                    }
                    else
                    {
                        if (Main.expertMode)
                        {
                            for (int i = 0; i < 7; i++)
                                Projectile.NewProjectile((int)((player.position.X - 50) + Main.rand.Next(100)), (int)((player.position.Y - 50) + Main.rand.Next(100)), 0.0f, 0.0f, mod.ProjectileType("Golas1Sheet"), npc.damage / 3, 4.5f);
                        }
                        for (int k = 0; k < (Main.expertMode ? 8 : 5); k++)
                        {
                            Vector2 shootPos = player.position + new Vector2(Main.rand.Next(-300, 300), -1000);
                            Vector2 shootVel = new Vector2(Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(9f, 14f));
                            Projectile.NewProjectile(shootPos, shootVel, mod.ProjectileType("GalaxyHostile"), npc.damage / 3, 4.5f);
                        }
                        Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 88);
                        this.attackTimer = 0;
                    }
                }
                if ((double)npc.ai[1] > 200.0)
                {
                    ColorSwordsHelper.MoveTowards(npc, player.Center, 8f + (float)((double)npc.life <= npc.lifeMax * 0.111 ? 3 : ((double)npc.life <= npc.lifeMax * 0.222 ? 2 : 0)), 8f + (float)((double)npc.life <= npc.lifeMax * 0.111 ? 3 : ((double)npc.life <= npc.lifeMax * 0.222 ? 2 : 0)));
                }
                if (npc.ai[1] >= 350f)
                    npc.ai[1] = 0f;
                npc.netUpdate = true;
            }
            if ((double)npc.life <= npc.lifeMax * 0.135)
            {
                this.frame = 1;
                this.stunned = true;
                if (!this.secondState2)
                {
                    float distance = 160f;
                    float k = 1.26f;
                    for (int count = 0; count < 10; count++)
                    {
                        Vector2 spawn = npc.Center + distance * ((float)count * k).ToRotationVector2();
                        NPC.NewNPC((int)spawn.X, (int)spawn.Y, mod.NPCType("UltimaShield"), 0, (float)npc.whoAmI, 0.0f, (float)count, 0.0f, 255);
                    }
                    this.secondState2 = true;
                }
                if (NPC.AnyNPCs(mod.NPCType("UltimaShield")))
                {
                    //if ((double)this.ai % 215.0 == 0.0)
                    if (Main.rand.Next(5) == 0)
                        Projectile.NewProjectile((int)((npc.position.X - 500) + Main.rand.Next(1000)), (int)((npc.position.Y - 500) + Main.rand.Next(1000)), 0.0f, 0.0f, mod.ProjectileType("Golas1Sheet"), npc.damage / 3, 4.5f);
                    npc.dontTakeDamage = true;
                }
                else
                {
                    //if ((double)this.ai % 225.0 == 0.0)
                    if (Main.rand.Next(5) == 0)
                        Projectile.NewProjectile((int)((npc.position.X - 500) + Main.rand.Next(1000)), (int)((npc.position.Y - 500) + Main.rand.Next(1000)), 0.0f, 0.0f, mod.ProjectileType("Golas1Sheet"), npc.damage / 3, 4.5f);
                    npc.dontTakeDamage = false;
                }
            }
            if (this.healTime >= 3)
            {
                ++this.healTimeKey;
                if (this.healTimeKey >= 120)
                {
                    npc.life += (int)(620 * (Main.expertMode ? 1.5f : 1f));
                    CombatText.NewText(new Rectangle((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height), new Color(71, 180, 71), "+" + (int)(350 * (Main.expertMode ? 1.5f : 1f)), false, false);
                    Main.player[Main.myPlayer].statLife -= 50;
                    this.healTime = 0;
                    this.healTimeKey = 0;
                    npc.netUpdate = true;
                }
            }
            if (this.checkDead)
            {
                this.ai = 0;
                npc.ai[0] = 0;
                npc.ai[1] = 0;
                npc.velocity.X = npc.velocity.Y = 0f;
                ++this.deadTimer;
                this.frame = 0;
                for (int k = 0; k < 5 * (this.deadTimer / 50); k++)
                {
                    
                   
                }
                if (this.deadTimer == 100)
                {
              
                }
                if (this.deadTimer >= 300)
                {
                    this.frame = 1;
                    if (this.deadTimer >= 400)
                    {
                        npc.life = 0;
                        npc.HitEffect(0, 1337);
                        npc.checkDead();
                        Main.PlaySound(4, (int)npc.position.X, (int)npc.position.Y, 43);
                       
                    }
                }
                if (this.deadTimer >= 0)
                    Main.musicFade[Main.curMusic] = 1f / (float)(this.deadTimer / 15 * 0.5f);
            }
        }

        public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.expertMode && this.frame == 1)
            {
                projectile.velocity.X = -projectile.velocity.X;
                projectile.velocity.Y = -projectile.velocity.Y;
                projectile.friendly = false;
                projectile.hostile = true;
                projectile.damage /= 3;
            }
        }

        

        public override bool CheckDead()
        {
            if (this.deadTimer <= 0)
            {
                this.checkDead = true;
                npc.dontTakeDamage = true;
                npc.life = npc.lifeMax;
                npc.netUpdate = true;
                return false;
            }
            return base.CheckDead();
        }

        public override void FindFrame(int frameHeight)
        {
            if (this.frame == 0)
            {
                counting += 1.0;
                if (counting < 8.0)
                {
                    npc.frame.Y = 0;
                }
                else if (counting < 16.0)
                {
                    npc.frame.Y = frameHeight;
                }
                else if (counting < 24.0)
                {
                    npc.frame.Y = frameHeight * 2;
                }
                else if (counting < 32.0)
                {
                    npc.frame.Y = frameHeight * 3;
                }
                else
                {
                    counting = 0.0;
                }
            }
            else if (this.frame == 1)
                npc.frame.Y = frameHeight * 4;
            else
                npc.frame.Y = frameHeight * 5;
        }
    }
}