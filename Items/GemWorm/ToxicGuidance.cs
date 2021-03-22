using ColorSwords.Tiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.GemWorm
{
	public class ToxicGuidance : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Toxic Guidance");
			Tooltip.SetDefault("You can steer missile with your cursor");
				
		}

		public override void SetDefaults() {
			item.damage = 2500;
			item.magic = true;
			item.mana = 14;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = true;
			item.channel = true; 
			item.knockBack = 8;
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item9;
			item.shoot = ModContent.ProjectileType<Projectiles.Manual.MagicMissile>();
			item.shootSpeed = 10f;
		}

		
		public override void ModifyManaCost(Player player, ref float reduce, ref float mult) {
			double currentTime = Main.time;
			
			double maxTime = Main.dayTime ? Main.dayLength : Main.nightLength;
			
			int direction = Main.dayTime ? 1 : -1;
			
			float timeMult = (float)Math.Sin(currentTime / maxTime * Math.PI);
			
			timeMult = 1 + timeMult * direction * 0.5f;
			
			mult *= timeMult;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ZombifiedBar", 1);
			recipe.AddTile(mod.GetTile("ColorBench"));
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}