using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Items.Bars;
using ColorSwords.Items.Placeable;

namespace ColorSwords.Items.GoldPlated
{
	public class GoldPlatedBombPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Shots bombs but can also mine normaly");
		}

		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ColorSwordsConfig>().DisableGoldenItems;
		}

		public override void SetDefaults() {
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 28;
			item.shootSpeed = 1f;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GemGoldBar", 10);
			recipe.AddIngredient(mod, "BombPickaxe");
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 1;
				item.useTime = 3;
				item.useAnimation = 20;
				item.damage = 20;
				item.shoot = ProjectileID.None;
			}
			else {
				item.useStyle = 1;
				item.useTime = 3;
				item.useAnimation = 40;
				item.damage = 20;
				item.pick = 215;
				item.shoot = 28;
	
			}
			return base.CanUseItem(player);
		}

		

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			
			speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
			speedY = 0;
			
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
			
			damage = (int)(damage * .1f);
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
	}
}