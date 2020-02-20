using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChampionSet.Items
{
	public class BladeOfChampions : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade Of Champions"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Some say that only the best of the best could wield it");
		}

		public override void SetDefaults() 
		{
			item.damage = 5500;
			item.melee = true;
			item.width = 500;
			item.height = 500;
			item.useTime = 3;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 30;
			item.value = 100000000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			ModRecipe recipe = new ModRecipe(mod);
			if (calamityMod != null)
			{
				recipe.AddIngredient(calamityMod.ItemType("BarofLife"), 20);
				recipe.AddIngredient(calamityMod.ItemType("GalacticaSingularity"), 7);
				recipe.AddIngredient(calamityMod.ItemType("CoreofCalamity"), 3);
				recipe.AddIngredient(calamityMod.ItemType("CosmiliteBar"), 20);
				recipe.AddIngredient(calamityMod.ItemType("SpiritGlyph"));
				recipe.AddIngredient(ItemID.LunarBar, 15);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(this);
				recipe.AddRecipe();
				
			}
			
		}
	}
}
