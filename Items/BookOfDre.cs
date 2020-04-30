using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Oreereereeo.Items 
{

	public class BookOfDre : ModItem {
	
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Man Himself");
			Tooltip.SetDefault("Have you ever heard about Dre?");
		}
		
		public override void SetDefaults() {
			item.damage = 100;
            item.noMelee = true;
            item.noUseGraphic = false;
            item.magic = true;
            item.channel = true;
            item.mana = 1;
            item.rare = 5;
            item.width = 28;
            item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 7;
			item.shoot = mod.ProjectileType("BookOfDreProjectile");
			item.value = Item.buyPrice(gold: 20);
		}
	}
}