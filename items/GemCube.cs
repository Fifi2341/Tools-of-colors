using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items
{
    public class GemCube : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to craft Color bars");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 95, 0, 0);
            item.rare = 10;
            
        }

       
    }
}
