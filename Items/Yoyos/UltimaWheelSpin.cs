using ColorSwords.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.Yoyos
{
	public class UltimaWheelSpin : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Too much gas I guess");

			
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 777;
			item.rare = 11;
     		item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.buyPrice(3, 0, 0, 0);
			item.shoot = ProjectileType<UltimaYoyoP>();
		}

		
		private static readonly int[] unwantedPrefixes = new int[] { PrefixID.Terrible, PrefixID.Dull, PrefixID.Shameful, PrefixID.Annoying, PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy };

		public override bool AllowPrefix(int pre)
		{
			


			if (Array.IndexOf(unwantedPrefixes, pre) > -1)
			{
				
				return false;
			}
			
			return true;
		}

		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "UltimaBar", 15);
			recipe.AddTile(mod.GetTile("UltimaAnvil"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}