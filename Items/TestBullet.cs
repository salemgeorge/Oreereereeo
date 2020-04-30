using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Oreereereeo.Items
{
    public class TestBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Speed Bullet");
            Tooltip.SetDefault("One Shooty Boi.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 4;
            item.height = 4;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.2f;
            item.value = Item.buyPrice(copper: 100);
            item.rare = 2;
            item.shoot = mod.ProjectileType("TestProjectile");
            item.shootSpeed = 20f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperCoin, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}