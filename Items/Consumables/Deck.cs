using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace catalyst.Items.Consumables
{
    public class Deck : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deck");
            Tooltip.SetDefault("What's in here?\nRight click to open.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 16;
            //item.UseSound = SoundID.Item2;
            item.maxStack = 10;
            item.rare = 8;
            item.value = 010000;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            switch (Main.rand.Next(3))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("CardHeart"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("CardSpade"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("CardClub"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("CardDiamond"));
                    break;
            }
        }
    }
}