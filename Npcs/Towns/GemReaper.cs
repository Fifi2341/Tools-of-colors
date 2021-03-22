using System;
using ColorSwords.Items;
using ColorSwords.Items.Bars;
using ColorSwords.Items.Food;
using ColorSwords.Items.Swords.Cutlass;
using ColorSwords.Items.Accessories.Shields;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using ColorSwords.Projectiles.BulletsP;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Npcs.Towns
{
	
	[AutoloadHead]
	public class GemTrader : ModNPC
	{
		public override string Texture => "ColorSwords/Npcs/Towns/GemReaper";

		public override string[] AltTextures => new[] { "ColorSwords/Npcs/Towns/GemReaper_Alt_1" };

		public override bool Autoload(ref string name)
		{
			name = "Gem Reaper";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		

		

		
		

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Gem Reaper";
				case 1:
					return "Sad guy";
				case 2:
					return "The dark guy";
				default:
					return "Gemchant";
			}
		}

		

		public override string GetChat()
		{
			
			switch (Main.rand.Next(4))
			{
				case 0:
					return "Come back to me when you are little mmmm richer!";
				case 1:
					return "There is a boss called Gem Worm. Its a post ML boss summoned in hell";
				case 2:
					return "Shields? Swords? Coke? Its yours my friend, as long as you have enough rubies!";
				case 3:
					return "Shields for sale!";
				default:
	 			return "Hello!";
			}
		}



		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				
				shop = true;
			}
		}




		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(ItemType<GemCube>());
			nextSlot++;

			

			shop.item[nextSlot].SetDefaults(ItemType<RainbowShield>());
			nextSlot++;


			shop.item[nextSlot].SetDefaults(ItemType<P1>());
			nextSlot++;



			shop.item[nextSlot].SetDefaults(ItemType<AppleJuice>());
			nextSlot++;


			shop.item[nextSlot].SetDefaults(ItemType<Coke>());
			nextSlot++;

		}


		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			for (int k = 0; k < 255; k++)
			{
				Player player = Main.player[k];
				if (!player.active)
				{
					continue;
				}

				foreach (Item item in player.inventory)
				{
					if (item.type == ModContent.ItemType<ColorBar>() || item.type == ModContent.ItemType<Items.Placeable.ColorBench>())
					{
						return true;
					}
				}
			}
			return false;
		}


		public override void SetChatButtons(ref string button, ref string button2)
	{
		button = Language.GetTextValue("LegacyInterface.28");
	}




	
	public override bool CanGoToStatue(bool toKingStatue)
		{
			return true;
		}

		

		

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 200;
			knockback = 40f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 15;
			randExtraCooldown = 15;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ProjectileType<GemProjectile>();
			attackDelay = 1;
		}



		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}