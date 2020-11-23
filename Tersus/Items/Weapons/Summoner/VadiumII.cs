using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumII : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vadium II"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'looks pretty... cool.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.summon = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Vadiumproj>();
			item.shootSpeed = 2f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.ShadowScale, 9);
			recipe.AddIngredient(null, "VadiumI", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}