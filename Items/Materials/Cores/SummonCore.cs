using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Materials.Cores
{
	public class SummonCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summon Core");
			Tooltip.SetDefault("A strange technology.\nYou feel energy pulsating out of it.");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
            item.value = Item.buyPrice(0, 0, 80, 0);
			item.rare = 2;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.Feather, 3);
			recipe.AddTile(TileID.Anvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}