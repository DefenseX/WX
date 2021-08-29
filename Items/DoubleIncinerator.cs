using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WX.Items
{
	public class DoubleIncinerator : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Double Incinerator");
			Tooltip.SetDefault("Has a 80% chance to not consume gel");
		}

		public override void SetDefaults()
		{
			item.damage = 228;
			item.ranged = true;
			item.width = 68;
			item.height = 20;
			item.useTime = 2;
			item.useAnimation = 10; 
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 7;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.shoot = 85;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Gel;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .80f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flamethrower);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 1f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
        }

        public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, -6);
		}
	}
}