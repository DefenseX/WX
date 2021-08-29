using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WX.Projectiles
{
	public class BasicSwordproj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Beam");
		}

		public override void SetDefaults()
		{
			base.projectile.width = 25;
			base.projectile.height = 25;
			base.projectile.aiStyle = 27;
			base.projectile.friendly = true;
			base.projectile.melee = true;
			base.projectile.penetrate = 3;
			base.projectile.timeLeft = 480;
		}
	}
}