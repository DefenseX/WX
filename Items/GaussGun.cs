using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WX.Items
{
	public class GaussGun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Gauss Rifle");
			Tooltip.SetDefault("Do not use for driving nails");
		}

		public override void SetDefaults() {
			item.damage = 25;
			item.noMelee = true;
			item.magic = true;
			item.channel = false;
			item.mana = 20;
			item.rare = 3;
			item.width = 102;
			item.height = 28;
			item.useTime = 40;
			item.useAnimation = 40;
			item.UseSound = SoundID.Item38;
			item.useStyle = 5;
			item.shootSpeed = 70f;
			item.shoot = 20;
			item.value = 22500;
			item.knockBack = 2.5f;
		}

		public override void HoldItem(Player player)
        {
          player.scope = true;
        }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(-10f, 0f));
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddIngredient(ItemID.DemoniteBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}