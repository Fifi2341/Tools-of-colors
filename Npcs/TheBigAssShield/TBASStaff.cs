using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class TBASStaff: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Unknown scepter");
			Tooltip.SetDefault("it seems to have a...thing on top of it. what is it?");
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
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item1;
			item.maxStack = 1;
			item.consumable = false;
			item.damage = 37;
			item.magic = true;
			item.melee = false;
			item.shootSpeed = 10f;
			item.shoot = ProjectileID.RubyBolt;
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
