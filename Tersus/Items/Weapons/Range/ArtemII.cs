using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Range
{
	public class ArtemII : ModItem
	{

		public override string Texture => "Terraria/Item_" + ItemID.DemonBow;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Artem II");
			Tooltip.SetDefault("'okay?'");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 24f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 6);
			recipe.AddIngredient(null, "ArtemI", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}