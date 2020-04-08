using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials.Cores.Supercharged
{
	public class SuperchargedMagicCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supercharged Magic Core");
			Tooltip.SetDefault("A strange technology.\nYou feel immense energy pulsating out of it.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 020000;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MagicCore"));
			recipe.AddIngredient(ItemID.SoulofLight);
			recipe.AddIngredient(ItemID.CrystalShard, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
