using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Oreereereeo.NPCs {
	
	[AutoloadHead]
	public class TestNPC : ModNPC {
		
		public override string Texture {
			get { return "Oreereereeo/NPCs/TestNPC"; }
		}
		
		public override string[] AltTextures {
			get { return new[] {"Oreereereeo/NPCs/TestNPC" }; }
		}
		
		public override bool Autoload(ref string name) {
			
			name = "Sandvich";
			return mod.Properties.Autoload;
		}
		
		public override void SetStaticDefaults() {
			Main.npcFrameCount[npc.type] = 26;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 5;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}
		
		public override void SetDefaults() {
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 12;
			npc.defense = 17;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}
		
		public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
			
			for(int k = 0; k < 255; k++) {
				
				Player player = Main.player[k];
				if(!player.active) {
					continue;
				}
				
				foreach(Item item in player.inventory) {
					
					if(item.type == mod.ItemType("TestRayGun")) {
						return true;
					}
					
				}
			}
			return false;
		}
		
		public override string TownNPCName() {
			
			switch(WorldGen.genRand.Next(10)) {
				case 0:
					return "Jesus";
				case 1:
					return "Dre";
				case 2:
					return "Beanos";
				case 3:
					return "Besus";
				case 4:
					return "2nd Besus";
				case 5:
					return "Another Besus";
				case 6:
					return "Yet another Besus";
				case 7:
					return "Trash";
				case 8: 
					return "Dasani";
				case 9:
					return "Your Mom";
				default:
					return "Evan";
			}
		}
		
		public override string GetChat() {
			
			// int otherNPC = NPC.FindFirstNPC(NPCID.Angler);
			int findThisNPC = NPC.FindFirstNPC(mod.NPCType("TestNPC"));
			
			// if(otherNPC >= 0 && Main.rand.NextBool(4)) {
				// return "Its such a shame that " + Main.npc[otherNPC].GivenName + " isnt an actual angler fish";
			// }
			
			switch(Main.rand.Next(5)) {
				case 0:
					return "Fun Fact: Your ugly.";
				case 1:
					return "Hello there.";
				case 2:
					return "TikTok is trash.";
				case 3:
					return "Have you ever Heard about Dre?";
				default:
					return "Just buy something already fatso.";
			}
			
			// if(findThisNPC >= 0 && Main.rand.NextBool(2)) {
				
				// if(Main.npc[findThisNPC].GivenName != "Dre") {
					// return "Have you heard about Dre?";
				// }
			// }
		}
			
		public override void SetChatButtons(ref string button, ref string button2) {
			button = Language.GetTextValue("LegacyInterface.28");
			button2 = "Custom";
		}
		
		public override void OnChatButtonClicked(bool firstButton, ref bool shop) {
			if(firstButton) {
				shop = true;
			} else {
				Main.npcChatText = "Do you like that Custom button? Cuz I dont.";
			}
		}
		
		public override void SetupShop(Chest shop, ref int nextSlot) {
			shop.item[nextSlot].SetDefaults(mod.ItemType("TestRayGun"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("TestBullet"));
			nextSlot++;
			
			// int findThisNPC = NPC.FindFirstNPC(mod.NPCType("TestNPC"));
			// if(Main.npc[findThisNPC].GivenName == "Evan") {
				// shop.item[nextSlot].SetDefaults(mod.ItemType("TrashItem"));
				// nextSlot++;
			// }
			shop.item[nextSlot].SetDefaults(mod.ItemType("TrashItem"));
			nextSlot++;
			// if(NPC.AnyNPCs(mod.NPCType("TestNPC"))) {
				shop.item[nextSlot].SetDefaults(mod.ItemType("BookOfDre"));
				nextSlot++;
			// }
			shop.item[nextSlot].SetDefaults(mod.ItemType("GlitchSword"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("TutorialSword"));
		}
		
		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), mod.ItemType("TrashItem"));
		}
		
		public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
			damage = 25;
			knockback = 4f;
		}
		
		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
			cooldown = 30;
			randExtraCooldown = 25;
		}
		
		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = ProjectileID.DemonScythe;
			attackDelay = 1;
		}
		
		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 5f;
			randomOffset = 2f;
		}
		
		public override bool CheckConditions(int left, int right, int top, int bottom) {
			// int score = 0;
			// for(int x = left; x <= right; x++) {
				// for(int y = top; y <= bottom; y++) {
					
					// int type = Main.tile[x, y].type;
					// if(type == mod.TileType("TestTile")) {
						// score++;
					// }
					// if(Main.tile[x, y].wall == mod.WallType("TestWall")) {
						// score++;
					// }
				// }
			// }
			// return score >= (right - left) * (bottom - top) / 2;
			return true;
		}
	}
}