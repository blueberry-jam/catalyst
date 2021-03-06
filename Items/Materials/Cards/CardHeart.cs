using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials.Cards
{
    public class CardHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heart Card");
            Tooltip.SetDefault("Go fish!");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 16;
            item.useTime = 20;
            item.value = 2000;
            item.rare = 8;
            item.maxStack = 52;
        }
    }
}