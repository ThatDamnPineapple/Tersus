using Terraria.ID;
using Terraria.ModLoader;

namespace Tersus.Items.Weapons.Summoner
{
	public class VadiumC : ModItem
	{
		private readonly Mod calamity = ModLoader.GetMod("CalamityMod");

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pure Vadium Calamity"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'I wonder how to get this legendary weapon'" + "\nCleans the evil");
		}

        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("CalamityMod") != null;
        }

		public override void SetDefaults() 
		{
			item.damage = 10000;
			item.summon = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 19;
			item.useStyle = 2;
			item.knockBack = 10;
			item.value = 100000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 35f;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(calamity, "ShadowspecBar", 1);
			recipe.AddIngredient(null, "VadiumS", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}