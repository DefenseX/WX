using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WX.Projectiles;

namespace WX.Items
{
	public class BasicSword2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Сold space blade");
		}

		public override void SetDefaults() 
		{
			item.damage = 55;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 11;
			item.value = 50000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<BasicSwordproj>();
			item.shootSpeed = 11f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddIngredient(ItemID.CobaltBar, 20);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}