
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.BossSummons
{
	
	public class BatInAJar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bat in a jar");
			Tooltip.SetDefault("Use it to summon Bat King boss! Don't ask me about crating");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; 
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 3;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		
		

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Npcs.BatKing.BatKing>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 1);
			recipe.AddIngredient(mod, "GreenBlob", 3);
			recipe.AddIngredient(ItemID.Worm, 5);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}