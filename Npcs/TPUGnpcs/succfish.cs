using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Colorswords.Npcs.TPUGnpcs
{
	public class succfish : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Succy boi");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 5;
			npc.damage = 5;
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
			return SpawnCondition.WaterCritter.Chance * 1.5f;
		}
		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.expertMode || Main.rand.NextBool())
			{
				player.AddBuff(BuffID.WaterCandle, 10, true);
			}
		}
	}
}