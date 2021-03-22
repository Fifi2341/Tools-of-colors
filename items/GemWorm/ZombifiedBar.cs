using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.GemWorm
{
    public class ZombifiedBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toxic Bar");
            Tooltip.SetDefault("Used to craft one of 4 toxic weapons");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(5, 0, 0, 0);
            item.rare = 11;
            
        }

        
    }
}