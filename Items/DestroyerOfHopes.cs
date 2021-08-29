using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WX.Items
{
	public class DestroyerOfHopes : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Destroyer of hopes");
			Tooltip.SetDefault("50% chance to not consume ammo");
		}

		public override void SetDefaults() {
			item.damage = 70;
			item.noMelee = true;
			item.ranged = true;
			item.rare = 6;
			item.width = 86;
			item.height = 36;
			item.useTime = 6;
			item.useAnimation = 6;
			item.UseSound = SoundID.Item41;
			//item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/S01");
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.value = 10000;
			item.knockBack = 2.5f;
			item.autoReuse = true;
			item.shoot = 10;
			item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(1);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(4));
				type = ProjectileID.BulletHighVelocity;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			if (Utils.NextBool(Main.rand, 3))
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MolotovFire, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(-8f, 0f));
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ModContent.ItemType<BasicGun>(), 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}