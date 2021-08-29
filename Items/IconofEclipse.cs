using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WX.Projectiles;

namespace WX.Items
{
	public class IconofEclipse : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Icon of Eclipse");
			Tooltip.SetDefault("A barely visible glow emanates from this sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 80;
			item.melee = true;
			item.width = 90;
			item.height = 90;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 750000;
			item.rare = 5;
			item.shoot = ModContent.ProjectileType<IconofEclipseBeam>();
			item.shootSpeed = 11f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}