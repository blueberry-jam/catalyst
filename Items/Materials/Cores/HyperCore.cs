using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials.Cores
{
	public class HyperCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hyper Core");
			Tooltip.SetDefault("White hot.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 050000;
			item.rare = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeetleHusk, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 3);
			recipe.AddIngredient(mod.ItemType("SuperchargedMagicCore"));
			recipe.AddIngredient(mod.ItemType("SuperchargedMeleeCore"));
			recipe.AddIngredient(mod.ItemType("SuperchargedRangerCore"));
			recipe.AddIngredient(mod.ItemType("SuperchargedSummonCore"));
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
