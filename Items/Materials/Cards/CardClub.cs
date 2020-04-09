using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Materials.Cards
{
    public class CardClub : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Club Card");
            Tooltip.SetDefault("Go fish!");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 28;
            item.useTime = 20;
            item.value = 2000;
            item.rare = 8;
        }
    }
}