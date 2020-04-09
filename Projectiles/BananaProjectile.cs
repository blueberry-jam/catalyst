using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace catalyst.Projectiles
{
    public class BananaProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 19;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.melee = true;
            projectile.scale = 1f;
        }

        public override void AI()
        {
            Random rnd = new Random();
            if (rnd.Next(4) == 0)
            {
                switch (rnd.Next(2))
                {
                    case 0:
                        Dust.NewDust(projectile.position, projectile.width, projectile.height, 18, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
                        break;
                    case 1:
                        Dust.NewDust(projectile.position, projectile.width, projectile.height, 19, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
                        break;
                    case 2:
                        Dust.NewDust(projectile.position, projectile.width, projectile.height, 32, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
                        break;
                }
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(3, 443);

            return true;
        }
    }
}