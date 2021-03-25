using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TPUG;
using TPUG.Items;
using Microsoft.Xna.Framework;

namespace ColorSwords.Npcs.TPUGnpcs
{
	public class TPUGGlobalNPC : GlobalNPC
	{
        public override void NPCLoot(Terraria.NPC npc)
        {

            if (Main.hardMode)
            {
                if (npc.lifeMax > 1 && npc.damage > 0 && npc.value > 0 && Main.rand.NextFloat() < .05f)
                {
                        Item.NewItem(npc.getRect(), mod.ItemType("GoldenPresent"));
                }


            }
        }
    }
}
