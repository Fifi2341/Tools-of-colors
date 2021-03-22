using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.Bars
{
    public class BlueBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Special Bar charged with essence of blue color");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 10, 0, 0);
            item.rare = 4;
            
        }

        public override void AddRecipes()
        {
            
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sapphire, 2);
            recipe.AddTile(mod.GetTile("ColorBench"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(mod, "GemCube");
            recipe2.AddTile(TileID.AdamantiteForge);
            recipe2.SetResult(this, 10);
            recipe2.AddRecipe();
        }
    }
}