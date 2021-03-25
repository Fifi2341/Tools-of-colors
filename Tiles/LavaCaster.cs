using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using ColorSwords.Items.TPUG_items;

namespace ColorSwords.Tiles
{
	public class LavaCaster: ModTile
	{
		public override void SetDefaults() 
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Lava Caster");
			AddMapEntry(new Color(238, 145, 105), name);

			//Can't use this since texture is vertical.
			//animationFrameHeight = 56;
		}
		private readonly int animationFrameWidth = 30;

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.93f;
			g = 0.11f;
			b = 0.12f;
		}

		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			// Flips the sprite if x coord is odd. Makes the tile more interesting.
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset)
		{
			// Tweak the frame drawn by x position so tiles next to each other are off-sync and look much more interesting.
			int uniqueAnimationFrame = Main.tileFrame[Type] + i;
			if (i % 2 == 0)
			{
				uniqueAnimationFrame += 3;
			}
			if (i % 3 == 0)
			{
				uniqueAnimationFrame += 3;
			}
			if (i % 4 == 0)
			{
				uniqueAnimationFrame += 3;
			}
			uniqueAnimationFrame = uniqueAnimationFrame % 6;

			frameXOffset = uniqueAnimationFrame * animationFrameWidth;
		}
		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			/*
			// Spend 9 ticks on each of 6 frames, looping
			frameCounter++;
			if (frameCounter > 8)
			{
				frameCounter = 0;
				frame++;
				if (frame > 5)
				{
					frame = 0;
				}
			}
			// Or, more compactly:
			if (++frameCounter >= 9)
			{
				frameCounter = 0;
				frame = ++frame % 6;
			}
			*/
			// Above code works, but since we are just mimicking another tile, we can just use the same value.
			frame = Main.tileFrame[TileID.FireflyinaBottle];
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 16, 32, ModContent.ItemType<LavaCasterItem>());
		}
	}

	internal class LavaCasterItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glitchy Lava Caster");
			Tooltip.SetDefault("wha-");
		}
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ModContent.ItemType<LiquidERROR>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.FireflyinaBottle);
			item.createTile = ModContent.TileType<LavaCaster>();
		}
	}
}
