using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Oreereereeo.NPCs {

	public class NpcDrops : GlobalNPC {
		
		public override void NPCLoot(NPC npc) {
			
			int choice = Main.rand.Next(3);
			if(npc.type == NPCID.EyeofCthulhu && choice == 1) {
				Item.NewItem(npc.getRect(), mod.ItemType("BookOfDre"));
			}
		}
	}
}