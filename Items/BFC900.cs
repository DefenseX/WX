using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WX.Items
{
	public class BFC900 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("BFC-900");
			Tooltip.SetDefault("Powerful energy flows through its wires");
		}

		public override void SetDefaults() {
			item.damage = 200;
			item.noMelee = true;
			item.magic = true;
			item.channel = false;
			item.mana = 30;
			item.rare = 6;
			item.width = 104;
			item.height = 34;
			item.useTime = 120;
			item.UseSound = SoundID.Item80;
			item.useStyle = 5;
			item.shootSpeed = 10f;
			item.useAnimation = 120;
			item.shoot = 254;
			item.value = 22500;
			item.knockBack = 2.5f;
		}

		public override void HoldItem(Player player)
        {
          player.scope = true;
        }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(-20f, 0f));
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}