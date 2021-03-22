using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.Items.Mage
{
	public class Sky : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("ground");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item40;
			item.autoReuse = true;
			item.shoot = 238; 
			item.shootSpeed = 2f;
			item.useAmmo = AmmoID.None;
			item.mana = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BlueBar", 5);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}