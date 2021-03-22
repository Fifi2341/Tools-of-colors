using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.Bars
{
    public class ColorBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Special Bar charged with essence of valuable gems");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 1000000;
            item.rare = 8;
            
        }

        public override void AddRecipes()
        {
           
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RedBar");
            recipe.AddIngredient(mod, "GreenBar");
            recipe.AddIngredient(mod, "BlueBar");
            recipe.AddIngredient(mod, "YellowBar");
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}