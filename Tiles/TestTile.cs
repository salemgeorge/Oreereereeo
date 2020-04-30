using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Oreereereeo.Tiles
{
    public class TestTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileLavaDeath[Type] = true;

            drop = mod.ItemType("TestTileItem");
            dustType = DustID.Platinum;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Test Tile");

            AddMapEntry(new Color(100, 150, 200), name);

            minPick = 20;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.75f;
            b = 1f;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}