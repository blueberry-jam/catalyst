using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials.Cores
{
	public class MagicCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Core");
			Tooltip.SetDefault("A strange technology.\nYou feel energy pulsating out of it.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 8000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
