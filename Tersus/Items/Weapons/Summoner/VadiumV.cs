using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumV : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vadium V"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'but can yours do this?!'");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.summon = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 10;
			item.value = 10000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Vadiumproj>();
			item.shootSpeed = 5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(null, "VadiumIV", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}