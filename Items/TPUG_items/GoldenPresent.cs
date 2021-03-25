using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using ColorSwords.Items.TPUG_items;
using System;
using ColorSwords.Items.TPUGarmor;

namespace ColorSwords.Items.TPUG_items
{
	public class GoldenPresent: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Golden Present"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shiny!");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.consumable = true;
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{

			float rand = Main.rand.NextFloat();
			if (rand < .1f)
				if (WorldGen.crimson)
				{
					player.QuickSpawnItem(ModContent.ItemType<SuperSpewerCrim>());
				}
				else
				{
					player.QuickSpawnItem(ModContent.ItemType<SuperSpewerCorr>());
				}
			else if (rand < .2f)
				player.QuickSpawnItem(ItemID.GreenCandyCaneBlock, 110);
			else if (rand < .23f)
				player.QuickSpawnItem(ItemID.CandyCaneBlock, 110);
			else if (rand < .26f)
				player.QuickSpawnItem(ItemID.PineTreeBlock, 110);
			else if (rand < .29f)
				player.QuickSpawnItem(mod.ItemType("SoulOfChristmas"), 10);
			else if (rand < .3f)
				player.QuickSpawnItem(ItemID.DogWhistle);
			else if (rand < .4f)
			{
				player.QuickSpawnItem(ModContent.ItemType<RedcandycanearmorC>());
				player.QuickSpawnItem(ModContent.ItemType<RedcandycanearmorL>());
				player.QuickSpawnItem(ModContent.ItemType<RedcandycanearmorH>());
			}
			else if (rand < .45f)
			{
				player.QuickSpawnItem(ModContent.ItemType<GreencandycanearmorC>());
				player.QuickSpawnItem(ModContent.ItemType<GreencandycanearmorH>());
				player.QuickSpawnItem(ModContent.ItemType<GreencandycanearmorL>());
			}
			else if (rand < .68f)
				player.QuickSpawnItem(ModContent.ItemType<Greencandycanebow>());
			else if (rand < .69f)
				player.QuickSpawnItem(ModContent.ItemType<Redcandycanebow>());
		}


        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Present, 1);
			recipe.AddIngredient(ItemID.GoldOre, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
