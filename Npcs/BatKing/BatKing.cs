using System;
using ColorSwords.Items.BatKing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ColorSwords.Npcs.BatKing
{
	[AutoloadBossHead]
	public class BatKing : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GiantBat];
		}

		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			else
			{

				{
					Item.NewItem(npc.getRect(), ModContent.ItemType<BatKingWing>());
				}
			}
		}



		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 25;
			npc.defense = 10;
			npc.lifeMax = 850;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60000f;
			npc.knockBackResist = 0.0f;
			npc.aiStyle = 14;
			aiType = NPCID.GiantBat;
			animationType = NPCID.GiantBat;
			npc.scale = 2;
			music = MusicID.Boss1;
			npc.boss = true;
			npc.noTileCollide = true;
			npc.buffImmune[31] = true;
			bossBag = ModContent.ItemType<BatKingBag>();
		}

		
	}
}