using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace ColorSwords.Npcs.TheBigAssShield
{
	public class TBASSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sacrificial Blade");
			Tooltip.SetDefault("This blade seems clean compared to the other weapons, which have blood. Maybe it was made just before the church was abandoned?");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.maxStack = 1;
			item.consumable = false;
			item.damage = 45;
			item.melee = true;
			item.useStyle = ItemUseStyleID.Stabbing;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 25;
				item.useAnimation = 20;
				item.damage = 60;
				item.useStyle = 1;
				item.shoot = ProjectileID.None; mod.Logger.Debug("maybe this could be an error? (sword)");
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 16;
				item.useAnimation = 20;
				item.useStyle = 1;
				item.damage = 45;
				item.shoot = ProjectileID.None; mod.Logger.Debug("maybe this could be an error? (sword)");
			}
			return base.CanUseItem(player);
		}
		/*
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddIngredient(ItemID.IceTorch, 5);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddIngredient(ItemID.ShadowFlameKnife, 1);
			recipe.AddTile(ModContent.TileType<LavaCaster>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		*/
	}
}
