using Terraria.ID;
using Terraria.ModLoader;

namespace catalyst.Items.Weapons
{
	public class Vermilion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vermilion");
			Tooltip.SetDefault("Mathematical!");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 030000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}