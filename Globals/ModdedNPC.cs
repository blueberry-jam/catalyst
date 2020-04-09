using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Globals
{
    public class ModdedNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(200) == 0)
            {
                if (npc.type == NPCID.Zombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Vermilion"));
                }
            }
            if (Main.rand.Next(75) == 0)
            {
                if (npc.type == NPCID.Skeleton || npc.type == NPCID.AngryBones)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OldFruit"));
                }
            }
            if (Main.rand.Next(75) == 0)
            {
                if (npc.type == NPCID.Necromancer || npc.type == NPCID.NecromancerArmored || npc.type == NPCID.DiabolistRed || npc.type == NPCID.DiabolistWhite || npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Deck"));
                }
            }
        }
    }
}