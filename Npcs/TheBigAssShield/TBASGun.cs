using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ColorSwords.Tiles;

namespace Colorswords.Npcs.TheBigAssShield
{
	public class TBASGun: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sacrificial Knife Cannon");
			Tooltip.SetDefault("a device used to launch...sacrificial knives? That's a weird way of religious execution...");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.maxStack = 1;
			item.consumable = false;
			item.damage = 45;
			item.ranged = true;
			item.melee = false;
			item.shoot = ProjectileID.CannonballFriendly;
			item.useAmmo = AmmoID.Bullet;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 20f;
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
