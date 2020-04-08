using Terraria.ModLoader;
using Terraria.Localization;

namespace catalyst
{
	public class catalyst : Mod
	{
		public catalyst()
		{
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cursed Flame", new int[]
            {
                ItemID.CursedFlame,
                ItemID.Ichor
            });
            RecipeGroup.RegisterGroup("catalyst:CursedFlame", group);

            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Rotten Chunk", new int[]
            {
                ItemID.RottenChunk,
                ItemID.Vertebrae
            });
            RecipeGroup.RegisterGroup("catalyst:RottenChunk", group);

            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Color Husk", new int[]
            {
                ItemID.CyanHusk,
                ItemID.RedHusk,
                ItemID.VioletHusk
            });
            RecipeGroup.RegisterGroup("catalyst:ColorHusk", group);
		}
	}
}