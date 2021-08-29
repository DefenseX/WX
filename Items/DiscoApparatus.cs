using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WX.Items
{
	public class DiscoApparatus : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Disco Apparatus");
			Tooltip.SetDefault("Shoots a storm of flares and lasers");
		}

		public override void SetDefaults() {
			item.damage = 100;
			item.noMelee = true;
			item.magic = true;
			item.channel = false;
			item.mana = 3;
			item.rare = 3;
			item.width = 102;
			item.height = 28;
			item.useTime = 5;
			item.useAnimation = 5;
			item.UseSound = SoundID.Item92;
			item.useStyle = 5;
			item.shootSpeed = 90f;
			item.shoot = 20;
			item.value = 22500;
			item.knockBack = 2.5f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
				type = ProjectileID.LaserMachinegunLaser;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}

			if (Utils.NextBool(Main.rand, 2))
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.PurpleLaser, damage, knockBack, player.whoAmI);
			}

			if (Utils.NextBool(Main.rand, 2))
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GreenLaser, damage, knockBack, player.whoAmI);
			}

			if (Utils.NextBool(Main.rand, 2))
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.HallowStar, damage, knockBack, player.whoAmI);
			}

			if (Utils.NextBool(Main.rand, 2))
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Leaf, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(-8f, 0f));
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LaserMachinegun, 1);
			recipe.AddIngredient(ItemID.LeafBlower, 1);
			recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}