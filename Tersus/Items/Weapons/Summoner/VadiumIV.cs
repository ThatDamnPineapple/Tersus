using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumIV : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vadium IV"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Uh... do I see a soul aura?'");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.summon = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 16;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 10;
			item.value = 10000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Vadiumproj>();
			item.shootSpeed = 4f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddIngredient(null, "VadiumIII", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}