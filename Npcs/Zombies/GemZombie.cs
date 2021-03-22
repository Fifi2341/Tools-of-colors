using System;
using ColorSwords.Items;
using ColorSwords.Items.Yoyos;
using ColorSwords.Items.Swords.Cutlass;
using ColorSwords.Items.Boxes;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Npcs.Zombies
{
	
	public class GemZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemType<UniversalGemBox>());

			if (Main.rand.NextFloat() < .3500f)
				Item.NewItem(npc.getRect(), ItemType<TheFrog>());

			if (Main.rand.NextFloat() < .1500f)
				Item.NewItem(npc.getRect(), ItemType<P1>());
		}
		


		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 44;
			npc.defense = 60;
			npc.lifeMax = 75;
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
			return SpawnCondition.OverworldNightMonster.Chance * 0.4f;
		}

		
	}
}