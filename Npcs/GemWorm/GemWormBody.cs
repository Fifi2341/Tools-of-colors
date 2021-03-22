using Terraria;
using Terraria.ID;

namespace ColorSwords.Npcs.GemWorm
{
	internal class GemWormBody : GemWorm
	{
		public override string Texture { get { return "ColorSwords/Npcs/GemWorm/GemWormBody"; } }
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DiggerBody);
			npc.aiStyle = -1;
			npc.damage = 80;
			npc.defense = 50;
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.damage = 190;
		}
	}
}