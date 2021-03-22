using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.GemDominator
{
	
	public class GemAtomicDrill : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Animation is broken but drill works");
		}

		public override void SetDefaults() {
			item.damage = 40;
			item.melee = true;
			item.width = 20;
			item.height = 12;
			item.useTime = 7;
			item.useAnimation = 25;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 250;
			item.tileBoost++;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<GemDominator.GemDrillP>();
			item.shootSpeed = 1f;
		}

		public override void AddRecipes()
		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OldGem", 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}