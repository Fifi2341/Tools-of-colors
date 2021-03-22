using Terraria;
using Terraria.ID;

namespace ColorSwords.Npcs.GemWorm
{
	internal class GemWormTail : GemWorm
	{
		public override string Texture { get { return "ColorSwords/Npcs/GemWorm/GemWormTail"; } }
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DiggerBody);
			npc.aiStyle = -1;
			npc.damage = 25;
			npc.defense = 90;
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.damage = 50;
		}
		public override void Init()
		{
			base.Init();
			tail = true;
		}
	}
}