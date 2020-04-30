using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Oreereereeo.Items
{
    public class TestRayGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ray Gun");
            Tooltip.SetDefault("Bzp Bzp Bzzzp");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.noMelee = true;
            item.noUseGraphic = false;
            item.magic = true;
            item.channel = true;
            item.mana = 1;
            item.rare = 5;
            item.width = 28;
            item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 7;
			item.shoot = mod.ProjectileType("RayGunProjectile");
			item.value = Item.buyPrice(gold: 20);
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