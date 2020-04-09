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
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.maxStack = 5;
            item.value = 010000;
            item.rare = 3;
        }
    }
}