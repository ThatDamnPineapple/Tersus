using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumP : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pure Vadium"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'The last Vadium summoner weapon, or is it...'");
		} 
		public override void SetDefaults() 
		{
			item.damage = 150;
			item.summon = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 10;
			item.value = 10000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Vadiumproj>();
			item.shootSpeed = 6f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "VadiumV");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}