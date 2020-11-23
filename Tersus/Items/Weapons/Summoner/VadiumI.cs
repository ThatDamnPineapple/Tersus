using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumI : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Malum Vadium"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'looks ok, i guess'");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.summon = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}