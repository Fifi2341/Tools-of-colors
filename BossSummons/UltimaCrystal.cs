
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ColorSwords.Items.BossSummons
{
	
	public class UltimaCrystal : ModItem
	{
		public override void SetStaticDefaults() {
			
			Tooltip.SetDefault("Use it to summon Ultima spider boss! Post plantera!");
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

			return NPC.downedPlantBoss && !NPC.AnyNPCs(ModContent.NPCType<Npcs.Ultima.UltimaNova>());
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Npcs.Ultima.UltimaNova>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ColorBar", 15);
			recipe.AddIngredient(mod, "OldGem", 2);
			recipe.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}