using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumIII : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vadium III"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'looks fire.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;
			item.summon = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 14;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 10;
			item.value = 1000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Vadiumproj>();
			item.shootSpeed = 3f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddIngredient(ItemID.TitaniumBar, 9);
			recipe.AddIngredient(null, "VadiumII", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddIngredient(ItemID.AdamantiteBar, 9);
			recipe.AddIngredient(null, "VadiumII", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}