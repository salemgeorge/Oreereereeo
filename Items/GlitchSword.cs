using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Oreereereeo.Items
{
    public class GlitchSword : ModItem
    {
        public override void SetStaticDefaults() 
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("You know what you must yabba dabba do.");
        }

        public override void SetDefaults() 
        {
            item.damage = 50;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 5;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            // item.shoot = ModContent.ProjectileType<TutorialBullet>();
            // item.shootSpeed = 16f;
            // item.useAmmo = AmmoID.Bullet;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if(Main.rand.Next(3) == 0)
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("TestDust"));
        }

        //public override void UseItem(Player player)
        //{
        //    if (Main.rand.Next(3) == 0)
        //        Dust.NewDust(new Vector2(player.position.X, player.position.Y), player.Hitbox.Width, player.Hitbox.Height, mod.DustType("TestDust"));
        //    return base.UseItem(player);
        //}

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