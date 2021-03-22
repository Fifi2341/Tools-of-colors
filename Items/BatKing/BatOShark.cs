using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ColorSwords.Items.BatKing
{
	public class BatOShark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bat-'O'-shark");
			Tooltip.SetDefault("Bats were hurt making this gun :D!");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 33f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BatKingWing");
			recipe.AddTile(TileID.Benches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}

		
	}
}