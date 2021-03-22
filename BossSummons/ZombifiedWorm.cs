
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.BossSummons
{
	
	public class ZombifiedWorm : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Toxic Worm");
			Tooltip.SetDefault("Use it to summon Gem Worm boss!");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; 
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 11;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		
		public override bool CanUseItem(Player player) {
			
			return NPC.downedMoonlord && player.ZoneUnderworldHeight && !NPC.AnyNPCs(ModContent.NPCType<Npcs.GemWorm.GemWormHead>());
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Npcs.GemWorm.GemWormHead>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 5);
			recipe.AddIngredient(mod, "OldGem", 3);
			recipe.AddIngredient(ItemID.Worm, 5);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}