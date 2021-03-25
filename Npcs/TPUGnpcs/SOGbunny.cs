using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace ColorSwords.Npcs.TPUGnpcs
{
	public class SOGbunny : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny?");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 5;
			npc.damage = 0;
			npc.defense = 0;
			npc.knockBackResist = -1f;
			npc.width = 70;
			npc.alpha = 0;
			npc.height = 46;
			animationType = 244;
			npc.aiStyle = 16;
			aiType = 16;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDayGrassCritter.Chance * 0.4f;
		}
		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.expertMode || Main.rand.NextBool())
			{
				player.AddBuff(BuffID.Horrified, 60, true);
			}
		}
	}
}
