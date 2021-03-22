using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.GoldPlated
{
    public class GemGoldBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gold bar with gem pieces in it");
        }

        public override bool Autoload(ref string name)
        {
            return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(1, 0, 0, 0);
            item.rare = 11;
            
        }

        public override void AddRecipes()
        {

            if (GetInstance<ColorSwordsConfig>().isEasyGoldEnabled)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Sapphire, 10);
                recipe.AddIngredient(ItemID.Ruby, 10);
                recipe.AddIngredient(ItemID.Emerald, 10);
                recipe.AddIngredient(ItemID.Amber, 10);
                recipe.AddIngredient(ItemID.GoldBar, 2);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
            else
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Sapphire, 10);
                recipe.AddIngredient(ItemID.Ruby, 10);
                recipe.AddIngredient(ItemID.Emerald, 10);
                recipe.AddIngredient(ItemID.Amber, 10);
                recipe.AddIngredient(ItemID.GoldBar, 15);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}