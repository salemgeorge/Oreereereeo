using Terraria;
using Terraria.ModLoader;

namespace Oreereereeo.Dusts
{
    public class TestDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = true;
            dust.scale = 2f;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X;
            dust.scale -= 0.1f;
            if(dust.scale < 0.2f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}