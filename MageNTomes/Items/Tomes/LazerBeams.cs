using Terraria;
using ColorSwords.MageNTomes.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace ColorSwords.MageNTomes.Items.Tomes
{
	public class LazerBeams : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("looks tasty");
		}


		


		public override void SetDefaults()
		{
			item.damage = 110;
			item.magic = true;
			item.channel = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 15;
			item.value = Item.buyPrice(2, 30, 0, 0);
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item30;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<WeaponLaserM>();
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.None;
			item.mana = 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MartianConduitPlating, 999);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		


	}
}