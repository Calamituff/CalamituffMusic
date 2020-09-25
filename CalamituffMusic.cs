
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamituffMusic
{
	class CalamituffMusic : Mod
	{
		public CalamituffMusic()
		{
		}

		bool yharon3 = false;
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			bool yharon2 = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetBossDowned", "buffedeclipse") ?? false;
			int scalIndex = NPC.FindFirstNPC(calamityMod.NPCType("SupremeCalamitas"));
			if (scalIndex > -1 && Main.npc[scalIndex].modNPC is ModNPC scal)
			{
				if (NPC.AnyNPCs(calamityMod.NPCType("SupremeCalamitas")))
				{
					if (scal.npc.life <= scal.npc.lifeMax / 100)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Acceptance");
						priority = MusicPriority.BossMedium;
					}
					if (scal.npc.life <= scal.npc.lifeMax / 3.33333333333 && scal.npc.life >= scal.npc.lifeMax / 100)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Epiphany");
						priority = MusicPriority.BossMedium;
					}
					if (scal.npc.life <= scal.npc.lifeMax / 2 && scal.npc.life >= scal.npc.lifeMax / 3.33333333333)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Lament");
						priority = MusicPriority.BossMedium;
					}
					if (scal.npc.life >= scal.npc.lifeMax / 2)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Grief");
						priority = MusicPriority.BossMedium;
					}
				}
			}
			int yharonIndex = NPC.FindFirstNPC(calamityMod.NPCType("Yharon"));
			if (yharonIndex > -1 && Main.npc[yharonIndex].modNPC is ModNPC yharon)
			{
				if (NPC.AnyNPCs(calamityMod.NPCType("Yharon")) && yharon2)
				{
					if (yharon.npc.life >= yharon.npc.lifeMax / 10)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Yharon2");
						priority = MusicPriority.BossMedium;
					}
				}
				if (!yharon3 && yharon.npc.life <= yharon.npc.lifeMax / 10)
				{
					yharon3 = true;
				}
				if (yharon3)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Yharon3");
					priority = MusicPriority.BossHigh;
				}
			}
			bool incrags = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "crags") ?? false;
			bool inastral = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "astral") ?? false;
			bool insulphur = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "sulphursea") ?? false;
			bool insunken = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "sunkensea") ?? false;
			bool inabyss = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "abyss") ?? false;
			bool inlayer3 = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "layer3") ?? false;
			bool inlayer4 = (bool?)ModLoader.GetMod("CalamityMod")?.Call("GetInZone", Main.LocalPlayer, "layer4") ?? false;

			if (incrags)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/BrimstoneCrags");
				priority = MusicPriority.Environment;
			}

			if (inastral && !Main.player[Main.myPlayer].ZoneDirtLayerHeight)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/AstralInfection");
				priority = MusicPriority.Environment;
			}

			if (inastral && Main.player[Main.myPlayer].ZoneDirtLayerHeight)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/AstralUnderground");
				priority = MusicPriority.Environment;
			}

			if (insunken)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea");
				priority = MusicPriority.Environment;
			}

			if (insulphur)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/SulphurSea");
				priority = MusicPriority.Environment;
			}

			if (inabyss)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss1");
				priority = MusicPriority.Environment;
			}

			if (inlayer3)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss2");
				priority = MusicPriority.Environment;
			}

			if (inlayer4)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss3");
				priority = MusicPriority.Environment;
			}

			if (NPC.AnyNPCs(NPCID.KingSlime))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.EyeofCthulhu))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.EaterofWorldsHead))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/EaterOfWorlds");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.BrainofCthulhu))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/BrainOfCthulhu");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.SkeletronHead))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Skeletron");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.WallofFlesh))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/WallOfFlesh");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.TheDestroyer))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Destroyer");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Twins");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.SkeletronPrime))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/SkeletronPrime");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("LeviathanStart")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Siren");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(NPCID.CultistBoss))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/LunaticCultist");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Cnidrion")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cnidrion");
				priority = MusicPriority.BossLow;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("DesertScourgeHead")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/DesertScourge");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("CrabulonIdle")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Crabulon");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("HiveMind")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("HiveMindP2")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("PerforatorHive")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Perforator");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("SlimeGodCore")) || NPC.AnyNPCs(calamityMod.NPCType("SlimeGod")) || NPC.AnyNPCs(calamityMod.NPCType("SlimeGodRun")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Cryogen")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cryogen");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("BrimstoneElemental")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/BrimstoneElemental");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("AquaticScourgeHead")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/AquaticScourge");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Calamitas")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("CalamitasRun3")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas2");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Siren")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Siren2");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Leviathan")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Leviathan");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("AstrumAureus")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Aureus");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("PlaguebringerGoliath")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Plaguebringer");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("RavagerBody")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("AstrumDeusHeadSpectral")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumDeus");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("ProfanedGuardianBoss")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/ProfanedGuardians");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Providence")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Providence");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Bumblefuck")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dragonfolly");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Polterghast")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Polterghast");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("OldDuke")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/OldDuke");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("StormWeaverHead")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/StormWeaver");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("StormWeaverHeadNaked")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/StormWeaver");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("CeaselessVoid")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/CeaselessVoid");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Signus")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Signus");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("DevourerofGodsHead")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/DevourerOfGods");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("DevourerofGodsHeadS")))
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/DoG2");
				priority = MusicPriority.BossMedium;
			}

			if (NPC.AnyNPCs(calamityMod.NPCType("Yharon")) && yharon2 == false)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/Yharon1");
				priority = MusicPriority.BossMedium;
			}
		}
	}
}

