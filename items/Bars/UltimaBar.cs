using Terraria;
using ColorSwords.Items;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.Bars
{
    public class UltimaBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Opens portal to ultimate world");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(5, 0, 0, 0);
            item.rare = 10;
           
        }

        public override void AddRecipes()
        {
            
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HexaMatter", 10);
            recipe.AddIngredient(mod, "OldGem", 1);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}