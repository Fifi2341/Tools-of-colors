using System;
using ColorSwords.Items;
using ColorSwords.Items.Materials;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Npcs.Zombies
{
	
	public class WalkingMossMutant : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemType<MossFragment>());
		}
		


		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 180;
			npc.defense = 60;
			npc.lifeMax = 750;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60000f;
			npc.knockBackResist = 0.9f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneJungle && Main.hardMode)
				return 0.1f;
			return 0f;
		}

		
	}
}