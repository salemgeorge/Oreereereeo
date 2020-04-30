using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Oreereereeo.Items
{
    public class TestWallItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Wall Item");
            Tooltip.SetDefault("Wha da frick does any of dis meeeeeeeeeeeeeeeeeeeeeeeeeeeean??????");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;

            item.consumable = true;

            item.createWall = mod.WallType("TestWall");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TestTileItem"), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}