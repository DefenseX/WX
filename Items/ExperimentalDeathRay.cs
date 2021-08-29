using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WX.Projectiles;

namespace WX.Items
{
	public class ExperimentalDeathRay : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoot a Deadly laser beam");
		}

		public override void SetDefaults() {
			item.damage = 40;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;
			item.mana = 5;
			item.rare = ItemRarityID.Pink;
			item.width = 122;
			item.height = 46;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = ModContent.ProjectileType<DeathRay>();
			item.value = Item.sellPrice(gold: 30);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(391, 10);
			recipe.AddIngredient(ItemID.IllegalGunParts, 2);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-36, 0);
		}
	}
}