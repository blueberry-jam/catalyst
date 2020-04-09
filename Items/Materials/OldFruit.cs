using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials
{
    public class OldFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Fruit");
            Tooltip.SetDefault("Smells ripe...");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.useTime = 20;
            item.maxStack = 5;
            item.value = 010000;
            item.rare = 3;
        }
    }
}