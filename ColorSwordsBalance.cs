using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords
{
    public class ColorSwordsBalance : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == ModContent.NPCType<Npcs.Zombies.GemZombie>())
            {
                npc.lifeMax = GetInstance<ColorSwordsConfig>().GemZombieHP;
                npc.life = GetInstance<ColorSwordsConfig>().GemZombieHP;
            }
            
        }
    }
}