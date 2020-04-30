using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Oreereereeo.Projectiles
{
    public class TestProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.ranged = true;
        }

        public override void AI()
        {
            projectile.light = 0.9f; //Glow just enough for it to cover the projectile
            projectile.alpha = 128; //Makes it semi-transparent
            projectile.rotation += (float)projectile.direction * 0.8f;
            //int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 1f); //Create Dust
            int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, mod.DustType("TestDust"));
            Main.dust[DustID].noGravity = true; //Makes the Dust not fall into the ground
        }

        //public override void Kill(int timeLeft)
        //{
        //    Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("TestDust"));
        //}
    }
}