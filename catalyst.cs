using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace catalyst
{
	public class catalyst : Mod
	{
		public catalyst()
		{
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cursed Flame", new int[]
            {
                ItemID.CursedFlame,
                ItemID.Ichor
            });
            RecipeGroup.RegisterGroup("catalyst:CursedFlame", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Rotten Chunk", new int[]
            {
                ItemID.RottenChunk,
                ItemID.Vertebrae
            });
            RecipeGroup.RegisterGroup("catalyst:RottenChunk", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Color Husk", new int[]
            {
                ItemID.CyanHusk,
                ItemID.RedHusk,
                ItemID.VioletHusk
            });
            RecipeGroup.RegisterGroup("catalyst:ColorHusk", group);
        }
	}
}