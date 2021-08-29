using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WX.Items
{
	public class HeavyClockworkRifle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Heavy Clockwork Assault Rifle");
			Tooltip.SetDefault("Improved version of the classic clockwork assault rifle");
		}

		public override void SetDefaults() {
			item.damage = 17;
			item.crit += 5;
			item.ranged = true;
			item.width = 70;
			item.height = 28;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 10;
			item.value = 7500;
			item.rare = 4;
			item.UseSound = SoundID.Item31;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 24f;
			item.useAmmo = AmmoID.Bullet;
			item.useAnimation = 12;
			item.useTime = 3;
			item.reuseDelay = 9;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return !(player.itemAnimation < item.useAnimation - 2);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(-6f, 0f));
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofSight, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}