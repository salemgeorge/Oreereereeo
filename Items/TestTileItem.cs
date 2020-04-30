using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Oreereereeo.Items
{
    public class TestTileItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Tile");
            Tooltip.SetDefault("This is a test tile. What the hell else did you think this was going to be?");
        }

        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 998;
            item.consumable = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.createTile = mod.TileType("TestTile");
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}