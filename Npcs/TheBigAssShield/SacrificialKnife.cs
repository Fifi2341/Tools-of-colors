using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace ColorSwords.Npcs.TheBigAssShield
{
	public class SacrificialKnife: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sacrificial Knife");
			Tooltip.SetDefault("A knife with a deep, dark past...");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = false;
			item.thrown = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item97;
			item.shoot = ProjectileID.ThrowingKnife;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.None;
			item.autoReuse = true;
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
