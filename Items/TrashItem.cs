using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Oreereereeo.Items
{
    public class TrashItem : ModItem
    {
        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Trash Bag"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Accurate description of Evan.");
        }

        public override void SetDefaults() 
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.value = 5;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
			item.maxStack = 999;
            // item.shoot = ModContent.ProjectileType<TutorialBullet>();
            // item.shootSpeed = 16f;
            // item.useAmmo = AmmoID.Bullet;
        }
    }
}