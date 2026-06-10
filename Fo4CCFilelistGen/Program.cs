using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fo4CCFilelistGen
{
    enum ModCategory { Official, Cut }

    record Mod(string Id, string Name, ModCategory Category, string[] Files);

    static class Program
    {
        static readonly List<Mod> AllMods = new()
        {
            // ── OFFICIAL ────────────────────────────────────────────────────────────
            new("ccACXFO4001-VSuit",                         "Vault Suit Customization",                    ModCategory.Official, ["Data/ccACXFO4001-VSuit - Main.ba2", "Data/ccACXFO4001-VSuit - Textures.ba2", "Data/ccACXFO4001-VSuit.esl"]),
            new("ccAWNFO4001-BrandedAttire",                 "Graphic T-Shirt Pack",                        ModCategory.Official, ["Data/ccAWNFO4001-BrandedAttire - Main.ba2", "Data/ccAWNFO4001-BrandedAttire - Textures.ba2", "Data/ccAWNFO4001-BrandedAttire.esl"]),
            new("ccAWNFO4002-FactionClothing",               "Railroad's Clandestine Couture",              ModCategory.Official, ["Data/ccAWNFO4002-FactionClothing - Main.ba2", "Data/ccAWNFO4002-FactionClothing - Textures.ba2", "Data/ccAWNFO4002-FactionClothing.esl"]),
            new("ccBGSFO4001-PipBoy(Black)",                 "Pip-Boy Paint Job - Onyx",                    ModCategory.Official, ["Data/ccBGSFO4001-PipBoy(Black) - Main.ba2", "Data/ccBGSFO4001-PipBoy(Black) - Textures.ba2", "Data/ccBGSFO4001-PipBoy(Black).esl"]),
            new("ccBGSFO4002-PipBoy(Blue)",                  "Pip-Boy Paint Job - Blue",                    ModCategory.Official, ["Data/ccBGSFO4002-PipBoy(Blue) - Main.ba2", "Data/ccBGSFO4002-PipBoy(Blue) - Textures.ba2", "Data/ccBGSFO4002-PipBoy(Blue).esl"]),
            new("ccBGSFO4003-PipBoy(Camo01)",                "Pip-Boy Paint Job - Desert Camo",             ModCategory.Official, ["Data/ccBGSFO4003-PipBoy(Camo01) - Main.ba2", "Data/ccBGSFO4003-PipBoy(Camo01) - Textures.ba2", "Data/ccBGSFO4003-PipBoy(Camo01).esl"]),
            new("ccBGSFO4004-PipBoy(Camo02)",                "Pip-Boy Paint Job - Swamp Camo",              ModCategory.Official, ["Data/ccBGSFO4004-PipBoy(Camo02) - Main.ba2", "Data/ccBGSFO4004-PipBoy(Camo02) - Textures.ba2", "Data/ccBGSFO4004-PipBoy(Camo02).esl"]),
            new("ccBGSFO4005-BlueCamo",                      "Pip-Boy Paint Job - Aquatic Camo",            ModCategory.Official, ["Data/ccBGSFO4005-BlueCamo - Main.ba2", "Data/ccBGSFO4005-BlueCamo - Textures.ba2", "Data/ccBGSFO4005-BlueCamo.esl"]),
            new("ccBGSFO4006-PipBoy(Chrome)",                "Pip-Boy Paint Job - Chrome",                  ModCategory.Official, ["Data/ccBGSFO4006-PipBoy(Chrome) - Main.ba2", "Data/ccBGSFO4006-PipBoy(Chrome) - Textures.ba2", "Data/ccBGSFO4006-PipBoy(Chrome).esl"]),
            new("ccBGSFO4008-PipGrn",                        "Pip-Boy Paint Job - Green",                   ModCategory.Official, ["Data/ccBGSFO4008-PipGrn - Main.ba2", "Data/ccBGSFO4008-PipGrn - Textures.ba2", "Data/ccBGSFO4008-PipGrn.esl"]),
            new("ccBGSFO4009-PipOran",                       "Pip-Boy Paint Job - Orange",                  ModCategory.Official, ["Data/ccBGSFO4009-PipOran - Main.ba2", "Data/ccBGSFO4009-PipOran - Textures.ba2", "Data/ccBGSFO4009-PipOran.esl"]),
            new("ccBGSFO4010-PipPnk",                        "Pip-Boy Paint Job - Pink",                    ModCategory.Official, ["Data/ccBGSFO4010-PipPnk - Main.ba2", "Data/ccBGSFO4010-PipPnk - Textures.ba2", "Data/ccBGSFO4010-PipPnk.esl"]),
            new("ccBGSFO4011-PipPurp",                       "Pip-Boy Paint Job - Purple",                  ModCategory.Official, ["Data/ccBGSFO4011-PipPurp - Main.ba2", "Data/ccBGSFO4011-PipPurp - Textures.ba2", "Data/ccBGSFO4011-PipPurp.esl"]),
            new("ccBGSFO4012-PipBoy(Red)",                   "Pip-Boy Paint Job - Red",                     ModCategory.Official, ["Data/ccBGSFO4012-PipBoy(Red) - Main.ba2", "Data/ccBGSFO4012-PipBoy(Red) - Textures.ba2", "Data/ccBGSFO4012-PipBoy(Red).esl"]),
            new("ccBGSFO4013-PipTan",                        "Pip-Boy Paint Job - Tan",                     ModCategory.Official, ["Data/ccBGSFO4013-PipTan - Main.ba2", "Data/ccBGSFO4013-PipTan - Textures.ba2", "Data/ccBGSFO4013-PipTan.esl"]),
            new("ccBGSFO4014-PipBoy(White)",                 "Pip-Boy Paint Job - White",                   ModCategory.Official, ["Data/ccBGSFO4014-PipBoy(White) - Main.ba2", "Data/ccBGSFO4014-PipBoy(White) - Textures.ba2", "Data/ccBGSFO4014-PipBoy(White).esl"]),
            new("ccBGSFO4015-PipYell",                       "Pip-Boy Paint Job - Yellow",                  ModCategory.Official, ["Data/ccBGSFO4015-PipYell - Main.ba2", "Data/ccBGSFO4015-PipYell - Textures.ba2", "Data/ccBGSFO4015-PipYell.esl"]),
            new("ccBGSFO4016-Prey",                          "Morgan's Space Suit",                         ModCategory.Official, ["Data/ccBGSFO4016-Prey - Main.ba2", "Data/ccBGSFO4016-Prey - Textures.ba2", "Data/ccBGSFO4016-Prey.esl"]),
            new("ccBGSFO4018-GaussRiflePrototype",           "Prototype Gauss Rifle",                       ModCategory.Official, ["Data/ccBGSFO4018-GaussRiflePrototype - Main.ba2", "Data/ccBGSFO4018-GaussRiflePrototype - Textures.ba2", "Data/ccBGSFO4018-GaussRiflePrototype.esl"]),
            new("ccBGSFO4019-ChineseStealthArmor",           "Chinese Stealth Armor",                       ModCategory.Official, ["Data/ccBGSFO4019-ChineseStealthArmor - Main.ba2", "Data/ccBGSFO4019-ChineseStealthArmor - Textures.ba2", "Data/ccBGSFO4019-ChineseStealthArmor.esl"]),
            new("ccBGSFO4020-PowerArmorSkin(Black)",         "Power Armor Paint Job - Black",               ModCategory.Official, ["Data/ccBGSFO4020-PowerArmorSkin(Black) - Main.ba2", "Data/ccBGSFO4020-PowerArmorSkin(Black) - Textures.ba2", "Data/ccBGSFO4020-PowerArmorSkin(Black).esl"]),
            new("ccBGSFO4021-PowerArmorSkinBlue",            "Power Armor Paint Job - Blue",                ModCategory.Official, ["Data/ccBGSFO4021-PowerArmorSkinBlue - Main.ba2", "Data/ccBGSFO4021-PowerArmorSkinBlue - Textures.ba2", "Data/ccBGSFO4021-PowerArmorSkinBlue.esl"]),
            new("ccBGSFO4022-PowerArmorSkin(Camo01)",        "Power Armor Paint Job - Desert Camo",         ModCategory.Official, ["Data/ccBGSFO4022-PowerArmorSkin(Camo01) - Main.ba2", "Data/ccBGSFO4022-PowerArmorSkin(Camo01) - Textures.ba2", "Data/ccBGSFO4022-PowerArmorSkin(Camo01).esl"]),
            new("ccBGSFO4023-PowerArmorSkin(Camo02)",        "Power Armor Paint Job - Swamp Camo",          ModCategory.Official, ["Data/ccBGSFO4023-PowerArmorSkin(Camo02) - Main.ba2", "Data/ccBGSFO4023-PowerArmorSkin(Camo02) - Textures.ba2", "Data/ccBGSFO4023-PowerArmorSkin(Camo02).esl"]),
            new("ccBGSFO4024-PACamo03",                      "Power Armor Paint Job - Winter Camo",         ModCategory.Official, ["Data/ccBGSFO4024-PACamo03 - Main.ba2", "Data/ccBGSFO4024-PACamo03 - Textures.ba2", "Data/ccBGSFO4024-PACamo03.esl"]),
            new("ccBGSFO4025-PowerArmorSkin(Chrome)",        "Power Armor Paint Job - Chrome",              ModCategory.Official, ["Data/ccBGSFO4025-PowerArmorSkin(Chrome) - Main.ba2", "Data/ccBGSFO4025-PowerArmorSkin(Chrome) - Textures.ba2", "Data/ccBGSFO4025-PowerArmorSkin(Chrome).esl"]),
            new("ccBGSFO4027-PowerArmorSkinGreen",           "Power Armor Paint Job - Green",               ModCategory.Official, ["Data/ccBGSFO4027-PowerArmorSkinGreen - Main.ba2", "Data/ccBGSFO4027-PowerArmorSkinGreen - Textures.ba2", "Data/ccBGSFO4027-PowerArmorSkinGreen.esl"]),
            new("ccBGSFO4028-PowerArmorSkinForge",           "Power Armor Paint Job - Orange",              ModCategory.Official, ["Data/ccBGSFO4028-PowerArmorSkinOrange - Main.ba2", "Data/ccBGSFO4028-PowerArmorSkinOrange - Textures.ba2", "Data/ccBGSFO4028-PowerArmorSkinOrange.esl"]),
            new("ccBGSFO4029-PowerArmorSkinRed",             "Power Armor Paint Job - Pink",                ModCategory.Official, ["Data/ccBGSFO4029-PowerArmorSkinPink - Main.ba2", "Data/ccBGSFO4029-PowerArmorSkinPink - Textures.ba2", "Data/ccBGSFO4029-PowerArmorSkinPink.esl"]),
            new("ccBGSFO4030-PowerArmorSkinPurple",          "Power Armor Paint Job - Purple",              ModCategory.Official, ["Data/ccBGSFO4030-PowerArmorSkinPurple - Main.ba2", "Data/ccBGSFO4030-PowerArmorSkinPurple - Textures.ba2", "Data/ccBGSFO4030-PowerArmorSkinPurple.esl"]),
            new("ccBGSFO4031-PowerArmorSkinRed",             "Power Armor Paint Job - Red",                 ModCategory.Official, ["Data/ccBGSFO4031-PowerArmorSkinRed - Main.ba2", "Data/ccBGSFO4031-PowerArmorSkinRed - Textures.ba2", "Data/ccBGSFO4031-PowerArmorSkinRed.esl"]),
            new("ccBGSFO4032-PowerArmorSkinTan",             "Power Armor Paint Job - Tan",                 ModCategory.Official, ["Data/ccBGSFO4032-PowerArmorSkinTan - Main.ba2", "Data/ccBGSFO4032-PowerArmorSkinTan - Textures.ba2", "Data/ccBGSFO4032-PowerArmorSkinTan.esl"]),
            new("ccBGSFO4033-PowerArmorSkinWhite",           "Power Armor Paint Job - White",               ModCategory.Official, ["Data/ccBGSFO4033-PowerArmorSkinWhite - Main.ba2", "Data/ccBGSFO4033-PowerArmorSkinWhite - Textures.ba2", "Data/ccBGSFO4033-PowerArmorSkinWhite.esl"]),
            new("ccBGSFO4034-PowerArmorSkinYellow",          "Power Armor Paint Job - Yellow",              ModCategory.Official, ["Data/ccBGSFO4034-PowerArmorSkinYellow - Main.ba2", "Data/ccBGSFO4034-PowerArmorSkinYellow - Textures.ba2", "Data/ccBGSFO4034-PowerArmorSkinYellow.esl"]),
            new("ccBGSFO4035-Pint",                          "Pint-Sized Slasher",                          ModCategory.Official, ["Data/ccBGSFO4035-Pint - Main.ba2", "Data/ccBGSFO4035-Pint - Textures.ba2", "Data/ccBGSFO4035-Pint.esl"]),
            new("ccBGSFO4036-TrnsDg",                        "TransDOGrifier",                              ModCategory.Official, ["Data/ccBGSFO4036-TrnsDg - Main.ba2", "Data/ccBGSFO4036-TrnsDg - Textures.ba2", "Data/ccBGSFO4036-TrnsDg.esl"]),
            new("ccBGSFO4038-HorseArmor",                    "Horse Power Armor",                           ModCategory.Official, ["Data/ccBGSFO4038-HorseArmor - Main.ba2", "Data/ccBGSFO4038-HorseArmor - Textures.ba2", "Data/ccBGSFO4038-HorseArmor.esl"]),
            new("ccBGSFO4040-VRWorkshop01",                  "Virtual Workshop: Grid World",                ModCategory.Official, ["Data/ccBGSFO4040-VRWorkshop01 - Main.ba2", "Data/ccBGSFO4040-VRWorkshop01 - Textures.ba2", "Data/ccBGSFO4040-VRWorkshop01.esl"]),
            new("ccBGSFO4041-DoomMarineArmor",               "Doom Marine Armor",                           ModCategory.Official, ["Data/ccBGSFO4041-DoomMarineArmor - Main.ba2", "Data/ccBGSFO4041-DoomMarineArmor - Textures.ba2", "Data/ccBGSFO4041-DoomMarineArmor.esl"]),
            new("ccBGSFO4042-BFG",                           "Doom BFG",                                    ModCategory.Official, ["Data/ccBGSFO4042-BFG - Main.ba2", "Data/ccBGSFO4042-BFG - Textures.ba2", "Data/ccBGSFO4042-BFG.esl"]),
            new("ccBGSFO4044-HellfirePowerArmor",            "Hellfire Power Armor",                        ModCategory.Official, ["Data/ccBGSFO4044-HellfirePowerArmor - Main.ba2", "Data/ccBGSFO4044-HellfirePowerArmor - Textures.ba2", "Data/ccBGSFO4044-HellfirePowerArmor.esl"]),
            new("ccBGSFO4045-AdvArcCab",                     "Arcade Workshop Pack",                        ModCategory.Official, ["Data/ccBGSFO4045-AdvArcCab - Main.ba2", "Data/ccBGSFO4045-AdvArcCab - Textures.ba2", "Data/ccBGSFO4045-AdvArcCab.esl"]),
            new("ccBGSFO4046-TesCan",                        "Tesla Cannon",                                ModCategory.Official, ["Data/ccBGSFO4046-TesCan - Main.ba2", "Data/ccBGSFO4046-TesCan - Textures.ba2", "Data/ccBGSFO4046-TesCan.esl"]),
            new("ccBGSFO4047-QThund",                        "Thunderbolt",                                 ModCategory.Official, ["Data/ccBGSFO4047-QThund - Main.ba2", "Data/ccBGSFO4047-QThund - Textures.ba2", "Data/ccBGSFO4047-QThund.esl"]),
            new("ccBGSFO4048-Dovah",                         "Fantasy Hero Set",                            ModCategory.Official, ["Data/ccBGSFO4048-Dovah - Main.ba2", "Data/ccBGSFO4048-Dovah - Textures.ba2", "Data/ccBGSFO4048-Dovah.esl"]),
            new("ccBGSFO4049-BrahminArmor",                  "Brahmin Armor",                               ModCategory.Official, ["Data/ccBGSFO4049-BrahminArmor - Main.ba2", "Data/ccBGSFO4049-BrahminArmor - Textures.ba2", "Data/ccBGSFO4049-BrahminArmor.esl"]),
            new("ccBGSFO4050-DgBColl",                       "Dog: Border Collie",                          ModCategory.Official, ["Data/ccBGSFO4050-DgBColl - Main.ba2", "Data/ccBGSFO4050-DgBColl - Textures.ba2", "Data/ccBGSFO4050-DgBColl.esl"]),
            new("ccBGSFO4051-DgBox",                         "Dog: Boxer",                                  ModCategory.Official, ["Data/ccBGSFO4051-DgBox - Main.ba2", "Data/ccBGSFO4051-DgBox - Textures.ba2", "Data/ccBGSFO4051-DgBox.esl"]),
            new("ccBGSFO4052-DgDal",                         "Dog: Dalmatian",                              ModCategory.Official, ["Data/ccBGSFO4052-DgDal - Main.ba2", "Data/ccBGSFO4052-DgDal - Textures.ba2", "Data/ccBGSFO4052-DgDal.esl"]),
            new("ccBGSFO4053-DgGoldR",                       "Dog: Golden Retriever",                       ModCategory.Official, ["Data/ccBGSFO4053-DgGoldR - Main.ba2", "Data/ccBGSFO4053-DgGoldR - Textures.ba2", "Data/ccBGSFO4053-DgGoldR.esl"]),
            new("ccBGSFO4054-DgGreatD",                      "Dog: Great Dane",                             ModCategory.Official, ["Data/ccBGSFO4054-DgGreatD - Main.ba2", "Data/ccBGSFO4054-DgGreatD - Textures.ba2", "Data/ccBGSFO4054-DgGreatD.esl"]),
            new("ccBGSFO4055-DgHusk",                        "Dog: Husky",                                  ModCategory.Official, ["Data/ccBGSFO4055-DgHusk - Main.ba2", "Data/ccBGSFO4055-DgHusk - Textures.ba2", "Data/ccBGSFO4055-DgHusk.esl"]),
            new("ccBGSFO4056-DgLabB",                        "Dog: Black Labrador",                         ModCategory.Official, ["Data/ccBGSFO4056-DgLabB - Main.ba2", "Data/ccBGSFO4056-DgLabB - Textures.ba2", "Data/ccBGSFO4056-DgLabB.esl"]),
            new("ccBGSFO4057-DgLabY",                        "Dog: Yellow Labrador",                        ModCategory.Official, ["Data/ccBGSFO4057-DgLabY - Main.ba2", "Data/ccBGSFO4057-DgLabY - Textures.ba2", "Data/ccBGSFO4057-DgLabY.esl"]),
            new("ccBGSFO4058-DGLabC",                        "Dog: Chocolate Labrador",                     ModCategory.Official, ["Data/ccBGSFO4058-DGLabC - Main.ba2", "Data/ccBGSFO4058-DGLabC - Textures.ba2", "Data/ccBGSFO4058-DGLabC.esl"]),
            new("ccBGSFO4059-DgPit",                         "Dog: Pitbull",                                ModCategory.Official, ["Data/ccBGSFO4059-DgPit - Main.ba2", "Data/ccBGSFO4059-DgPit - Textures.ba2", "Data/ccBGSFO4059-DgPit.esl"]),
            new("ccBGSFO4060-DgRot",                         "Dog: Rottweiler",                             ModCategory.Official, ["Data/ccBGSFO4060-DgRot - Main.ba2", "Data/ccBGSFO4060-DgRot - Textures.ba2", "Data/ccBGSFO4060-DgRot.esl"]),
            new("ccBGSFO4061-DgShiInu",                      "Dog: Shiba Inu",                              ModCategory.Official, ["Data/ccBGSFO4061-DgShiInu - Main.ba2", "Data/ccBGSFO4061-DgShiInu - Textures.ba2", "Data/ccBGSFO4061-DgShiInu.esl"]),
            new("ccBGSFO4062-PipPat",                        "Pip-Boy Paint Job - Patriotic",               ModCategory.Official, ["Data/ccBGSFO4062-PipPat - Main.ba2", "Data/ccBGSFO4062-PipPat - Textures.ba2", "Data/ccBGSFO4062-PipPat.esl"]),
            new("ccBGSFO4063-PAPat",                         "Power Armor Paint Job - Patriotic",           ModCategory.Official, ["Data/ccBGSFO4063-PAPat - Main.ba2", "Data/ccBGSFO4063-PAPat - Textures.ba2", "Data/ccBGSFO4063-PAPat.esl"]),
            new("ccBGSFO4070-PipAbra",                       "Pip-Boy Paint Job - Abraxo",                  ModCategory.Official, ["Data/ccBGSFO4070-PipAbra - Main.ba2", "Data/ccBGSFO4070-PipAbra - Textures.ba2", "Data/ccBGSFO4070-PipAbra.esl"]),
            new("ccBGSFO4071-PipArc",                        "Pip-Boy Paint Job - ArcJet",                  ModCategory.Official, ["Data/ccBGSFO4071-PipArc - Main.ba2", "Data/ccBGSFO4071-PipArc - Textures.ba2", "Data/ccBGSFO4071-PipArc.esl"]),
            new("ccBGSFO4072-PipGrog",                       "Pip-Boy Paint Job - Grognak",                 ModCategory.Official, ["Data/ccBGSFO4072-PipGrog - Main.ba2", "Data/ccBGSFO4072-PipGrog - Textures.ba2", "Data/ccBGSFO4072-PipGrog.esl"]),
            new("ccBGSFO4073-PipMMan",                       "Pip-Boy Paint Job - Manta Man",               ModCategory.Official, ["Data/ccBGSFO4073-PipMMan - Main.ba2", "Data/ccBGSFO4073-PipMMan - Textures.ba2", "Data/ccBGSFO4073-PipMMan.esl"]),
            new("ccBGSFO4074-PipInspect",                    "Pip-Boy Paint Job - Inspector",               ModCategory.Official, ["Data/ccBGSFO4074-PipInspect - Main.ba2", "Data/ccBGSFO4074-PipInspect - Textures.ba2", "Data/ccBGSFO4074-PipInspect.esl"]),
            new("ccBGSFO4075-PipShroud",                     "Pip-Boy Paint Job - Silver Shroud",           ModCategory.Official, ["Data/ccBGSFO4075-PipShroud - Main.ba2", "Data/ccBGSFO4075-PipShroud - Textures.ba2", "Data/ccBGSFO4075-PipShroud.esl"]),
            new("ccBGSFO4076-PipMystery",                    "Pip-Boy Paint Job - Mistress of Mystery",     ModCategory.Official, ["Data/ccBGSFO4076-PipMystery - Main.ba2", "Data/ccBGSFO4076-PipMystery - Textures.ba2", "Data/ccBGSFO4076-PipMystery.esl"]),
            new("ccBGSFO4077-PipRocket",                     "Pip-Boy Paint Job - Red Rocket",              ModCategory.Official, ["Data/ccBGSFO4077-PipRocket - Main.ba2", "Data/ccBGSFO4077-PipRocket - Textures.ba2", "Data/ccBGSFO4077-PipRocket.esl"]),
            new("ccBGSFO4078-PipReily",                      "Pip-Boy Paint Job - Reilly's Rangers",        ModCategory.Official, ["Data/ccBGSFO4078-PipReily - Main.ba2", "Data/ccBGSFO4078-PipReily - Textures.ba2", "Data/ccBGSFO4078-PipReily.esl"]),
            new("ccBGSFO4079-PipVim",                        "Pip-Boy Paint Job - Vim!",                    ModCategory.Official, ["Data/ccBGSFO4079-PipVim - Main.ba2", "Data/ccBGSFO4079-PipVim - Textures.ba2", "Data/ccBGSFO4079-PipVim.esl"]),
            new("ccBGSFO4080-PipPop",                        "Pip-Boy Paint Job - Pop",                     ModCategory.Official, ["Data/ccBGSFO4080-PipPop - Main.ba2", "Data/ccBGSFO4080-PipPop - Textures.ba2", "Data/ccBGSFO4080-PipPop.esl"]),
            new("ccBGSFO4081-PipPhenolResin",                "Pip-Boy Paint Job - Phenol Resin",            ModCategory.Official, ["Data/ccBGSFO4081-PipPhenolResin - Main.ba2", "Data/ccBGSFO4081-PipPhenolResin - Textures.ba2", "Data/ccBGSFO4081-PipPhenolResin.esl"]),
            new("ccBGSFO4082-PipPRC",                        "Pip-Boy Paint Job - Five-Star Red",           ModCategory.Official, ["Data/ccBGSFO4082-PipPRC - Main.ba2", "Data/ccBGSFO4082-PipPRC - Textures.ba2", "Data/ccBGSFO4082-PipPRC.esl"]),
            new("ccBGSFO4083-PipArtDeco",                    "Pip-Boy Paint Job - Art Deco",                ModCategory.Official, ["Data/ccBGSFO4083-PipArtDeco - Main.ba2", "Data/ccBGSFO4083-PipArtDeco - Textures.ba2", "Data/ccBGSFO4083-PipArtDeco.esl"]),
            new("ccBGSFO4084-PipRetro",                      "Pip-Boy Paint Job - Corvega",                 ModCategory.Official, ["Data/ccBGSFO4084-PipRetro - Main.ba2", "Data/ccBGSFO4084-PipRetro - Textures.ba2", "Data/ccBGSFO4084-PipRetro.esl"]),
            new("ccBGSFO4085-PipHawaii",                     "Pip-Boy Paint Job - Hawaii",                  ModCategory.Official, ["Data/ccBGSFO4085-PipHawaii - Main.ba2", "Data/ccBGSFO4085-PipHawaii - Textures.ba2", "Data/ccBGSFO4085-PipHawaii.esl"]),
            new("ccBGSFO4086-PipAdventure",                  "Pip-Boy Paint Job - Adventure",               ModCategory.Official, ["Data/ccBGSFO4086-PipAdventure - Main.ba2", "Data/ccBGSFO4086-PipAdventure - Textures.ba2", "Data/ccBGSFO4086-PipAdventure.esl"]),
            new("ccBGSFO4087-PipHaida",                      "Pip-Boy Paint Job - Haida",                   ModCategory.Official, ["Data/ccBGSFO4087-PipHaida - Main.ba2", "Data/ccBGSFO4087-PipHaida - Textures.ba2", "Data/ccBGSFO4087-PipHaida.esl"]),
            new("ccBGSFO4089-PipSynthwave",                  "Pip-Boy Paint Job - Synthwave",               ModCategory.Official, ["Data/ccBGSFO4089-PipSynthwave - Main.ba2", "Data/ccBGSFO4089-PipSynthwave - Textures.ba2", "Data/ccBGSFO4089-PipSynthwave.esl"]),
            new("ccBGSFO4090-PipTribal",                     "Pip-Boy Paint Job - Tribal",                  ModCategory.Official, ["Data/ccBGSFO4090-PipTribal - Main.ba2", "Data/ccBGSFO4090-PipTribal - Textures.ba2", "Data/ccBGSFO4090-PipTribal.esl"]),
            new("ccBGSFO4091-AS_Bats",                       "Armor Paint Job - Bats",                      ModCategory.Official, ["Data/ccBGSFO4091-AS_Bats - Main.ba2", "Data/ccBGSFO4091-AS_Bats - Textures.ba2", "Data/ccBGSFO4091-AS_Bats.esl"]),
            new("ccBGSFO4092-AS_CamoBlue",                   "Armor Paint Job - Aquatic Camo",              ModCategory.Official, ["Data/ccBGSFO4092-AS_CamoBlue - Main.ba2", "Data/ccBGSFO4092-AS_CamoBlue - Textures.ba2", "Data/ccBGSFO4092-AS_CamoBlue.esl"]),
            new("ccBGSFO4093-AS_CamoGreen",                  "Armor Paint Job - Swamp Camo",                ModCategory.Official, ["Data/ccBGSFO4093-AS_CamoGreen - Main.ba2", "Data/ccBGSFO4093-AS_CamoGreen - Textures.ba2", "Data/ccBGSFO4093-AS_CamoGreen.esl"]),
            new("ccBGSFO4094-AS_CamoTan",                    "Armor Paint Job - Desert Camo",               ModCategory.Official, ["Data/ccBGSFO4094-AS_CamoTan - Main.ba2", "Data/ccBGSFO4094-AS_CamoTan - Textures.ba2", "Data/ccBGSFO4094-AS_CamoTan.esl"]),
            new("ccBGSFO4095-AS_ChildrenOfAtom",             "Armor Paint Job - Children of Atom",          ModCategory.Official, ["Data/ccBGSFO4095-AS_ChildrenOfAtom - Main.ba2", "Data/ccBGSFO4095-AS_ChildrenOfAtom - Textures.ba2", "Data/ccBGSFO4095-AS_ChildrenOfAtom.esl"]),
            new("ccBGSFO4096-AS_Enclave",                    "Armor Paint Job - Enclave",                   ModCategory.Official, ["Data/ccBGSFO4096-AS_Enclave - Main.ba2", "Data/ccBGSFO4096-AS_Enclave - Textures.ba2", "Data/ccBGSFO4096-AS_Enclave.esl"]),
            new("ccBGSFO4097-AS_Jack-oLantern",              "Armor Paint Job - Jack O'Lantern",            ModCategory.Official, ["Data/ccBGSFO4097-AS_Jack-oLantern - Main.ba2", "Data/ccBGSFO4097-AS_Jack-oLantern - Textures.ba2", "Data/ccBGSFO4097-AS_Jack-oLantern.esl"]),
            new("ccBGSFO4098-AS_Pickman",                    "Armor Paint Job - Pickman",                   ModCategory.Official, ["Data/ccBGSFO4098-AS_Pickman - Main.ba2", "Data/ccBGSFO4098-AS_Pickman - Textures.ba2", "Data/ccBGSFO4098-AS_Pickman.esl"]),
            new("ccBGSFO4099-AS_ReillysRangers",             "Armor Paint Job - Reilly's Rangers",          ModCategory.Official, ["Data/ccBGSFO4099-AS_ReillysRangers - Main.ba2", "Data/ccBGSFO4099-AS_ReillysRangers - Textures.ba2", "Data/ccBGSFO4099-AS_ReillysRangers.esl"]),
            new("ccBGSFO4101-AS_Shi",                        "Armor Paint Job - Shi",                       ModCategory.Official, ["Data/ccBGSFO4101-AS_Shi - Main.ba2", "Data/ccBGSFO4101-AS_Shi - Textures.ba2", "Data/ccBGSFO4101-AS_Shi.esl"]),
            new("ccBGSFO4103-AS_TunnelSnakes",               "Armor Paint Job - Tunnel Snakes",             ModCategory.Official, ["Data/ccBGSFO4103-AS_TunnelSnakes - Main.ba2", "Data/ccBGSFO4103-AS_TunnelSnakes - Textures.ba2", "Data/ccBGSFO4103-AS_TunnelSnakes.esl"]),
            new("ccBGSFO4104-WS_Bats",                       "Weapon Paint Job - Bats",                     ModCategory.Official, ["Data/ccBGSFO4104-WS_Bats - Main.ba2", "Data/ccBGSFO4104-WS_Bats - Textures.ba2", "Data/ccBGSFO4104-WS_Bats.esl"]),
            new("ccBGSFO4105-WS_CamoBlue",                   "Weapon Paint Job - Aquatic Camo",             ModCategory.Official, ["Data/ccBGSFO4105-WS_CamoBlue - Main.ba2", "Data/ccBGSFO4105-WS_CamoBlue - Textures.ba2", "Data/ccBGSFO4105-WS_CamoBlue.esl"]),
            new("ccBGSFO4106-WS_CamoGreen",                  "Weapon Paint Job - Swamp Camo",               ModCategory.Official, ["Data/ccBGSFO4106-WS_CamoGreen - Main.ba2", "Data/ccBGSFO4106-WS_CamoGreen - Textures.ba2", "Data/ccBGSFO4106-WS_CamoGreen.esl"]),
            new("ccBGSFO4107-WS_CamoTan",                    "Weapon Paint Job - Desert Camo",              ModCategory.Official, ["Data/ccBGSFO4107-WS_CamoTan - Main.ba2", "Data/ccBGSFO4107-WS_CamoTan - Textures.ba2", "Data/ccBGSFO4107-WS_CamoTan.esl"]),
            new("ccBGSFO4108-WS_ChildrenOfAtom",             "Weapon Paint Job - Children of Atom",         ModCategory.Official, ["Data/ccBGSFO4108-WS_ChildrenOfAtom - Main.ba2", "Data/ccBGSFO4108-WS_ChildrenOfAtom - Textures.ba2", "Data/ccBGSFO4108-WS_ChildrenOfAtom.esl"]),
            new("ccBGSFO4110-WS_Enclave",                    "Weapon Paint Job - Enclave",                  ModCategory.Official, ["Data/ccBGSFO4110-WS_Enclave - Main.ba2", "Data/ccBGSFO4110-WS_Enclave - Textures.ba2", "Data/ccBGSFO4110-WS_Enclave.esl"]),
            new("ccBGSFO4111-WS_Jack-oLantern",              "Weapon Paint Job - Jack O'Lantern",           ModCategory.Official, ["Data/ccBGSFO4111-WS_Jack-oLantern - Main.ba2", "Data/ccBGSFO4111-WS_Jack-oLantern - Textures.ba2", "Data/ccBGSFO4111-WS_Jack-oLantern.esl"]),
            new("ccBGSFO4112-WS_Pickman",                    "Weapon Paint Job - Pickman",                  ModCategory.Official, ["Data/ccBGSFO4112-WS_Pickman - Main.ba2", "Data/ccBGSFO4112-WS_Pickman - Textures.ba2", "Data/ccBGSFO4112-WS_Pickman.esl"]),
            new("ccBGSFO4113-WS_ReillysRangers",             "Weapon Paint Job - Reilly's Rangers",         ModCategory.Official, ["Data/ccBGSFO4113-WS_ReillysRangers - Main.ba2", "Data/ccBGSFO4113-WS_ReillysRangers - Textures.ba2", "Data/ccBGSFO4113-WS_ReillysRangers.esl"]),
            new("ccBGSFO4114-WS_Shi",                        "Weapon Paint Job - Shi",                      ModCategory.Official, ["Data/ccBGSFO4114-WS_Shi - Main.ba2", "Data/ccBGSFO4114-WS_Shi - Textures.ba2", "Data/ccBGSFO4114-WS_Shi.esl"]),
            new("ccBGSFO4115-X02",                           "X-02 Power Armor",                            ModCategory.Official, ["Data/ccBGSFO4115-X02 - Main.ba2", "Data/ccBGSFO4115-X02 - Textures.ba2", "Data/ccBGSFO4115-X02.esl"]),
            new("ccBGSFO4116-HeavyFlamer",                   "Heavy Incinerator",                           ModCategory.Official, ["Data/ccBGSFO4116-HeavyFlamer - Main.ba2", "Data/ccBGSFO4116-HeavyFlamer - Textures.ba2", "Data/ccBGSFO4116-HeavyFlamer.esl"]),
            new("ccBGSFO4117-CapMerc",                       "Capital Wasteland Mercenaries",               ModCategory.Official, ["Data/ccBGSFO4117-CapMerc - Main.ba2", "Data/ccBGSFO4117-CapMerc - Textures.ba2", "Data/ccBGSFO4117-CapMerc.esl"]),
            new("ccBGSFO4118-WS_TunnelSnakes",               "Weapon Paint Job - Tunnel Snakes",            ModCategory.Official, ["Data/ccBGSFO4118-WS_TunnelSnakes - Main.ba2", "Data/ccBGSFO4118-WS_TunnelSnakes - Textures.ba2", "Data/ccBGSFO4118-WS_TunnelSnakes.esl"]),
            new("ccBGSFO4119-Cyberdog",                      "Cyber Dog",                                   ModCategory.Official, ["Data/ccBGSFO4119-Cyberdog - Main.ba2", "Data/ccBGSFO4119-Cyberdog - Textures.ba2", "Data/ccBGSFO4119-Cyberdog.esl"]),
            new("ccBGSFO4120-PowerAmorSkin(PittRaider)",     "Power Armor Paint Job - Pitt Raider",         ModCategory.Official, ["Data/ccBGSFO4120-PowerAmorSkin(PittRaider) - Main.ba2", "Data/ccBGSFO4120-PowerAmorSkin(PittRaider) - Textures.ba2", "Data/ccBGSFO4120-PowerAmorSkin(PittRaider).esl"]),
            new("ccBGSFO4121-PowerAmorSkin(AirForce)",       "Power Armor Paint Job - Air Force",           ModCategory.Official, ["Data/ccBGSFO4121-PowerAmorSkin(AirForce) - Main.ba2", "Data/ccBGSFO4121-PowerAmorSkin(AirForce) - Textures.ba2", "Data/ccBGSFO4121-PowerAmorSkin(AirForce).esl"]),
            new("ccBGSFO4122-PowerAmorSkin(ScorchedSierra)", "Power Armor Paint Job - Scorched Sierra",     ModCategory.Official, ["Data/ccBGSFO4122-PowerAmorSkin(ScorchedSierra) - Main.ba2", "Data/ccBGSFO4122-PowerAmorSkin(ScorchedSierra) - Textures.ba2", "Data/ccBGSFO4122-PowerAmorSkin(ScorchedSierra).esl"]),
            new("ccBGSFO4123-PowerAmorSkin(Inferno)",        "Power Armor Paint Job - Inferno",             ModCategory.Official, ["Data/ccBGSFO4123-PowerAmorSkin(Inferno) - Main.ba2", "Data/ccBGSFO4123-PowerAmorSkin(Inferno) - Textures.ba2", "Data/ccBGSFO4123-PowerAmorSkin(Inferno).esl"]),
            new("ccBGSFO4124-PowerAmorSkin(TribalHelmets)",  "Repurposed Power Armor Helmets",              ModCategory.Official, ["Data/ccBGSFO4124-PowerAmorSkin(TribalHelmets) - Main.ba2", "Data/ccBGSFO4124-PowerAmorSkin(TribalHelmets) - Textures.ba2", "Data/ccBGSFO4124-PowerAmorSkin(TribalHelmets).esl"]),
            new("ccCRSFO4001-PipCoA",                        "Pip-Boy Paint Job - Children of Atom",        ModCategory.Official, ["Data/ccCRSFO4001-PipCoA - Main.ba2", "Data/ccCRSFO4001-PipCoA - Textures.ba2", "Data/ccCRSFO4001-PipCoA.esl"]),
            new("ccEEJFO4001-DecorationPack",                "Home Decor Workshop Pack",                    ModCategory.Official, ["Data/ccEEJFO4001-DecorationPack - Main.ba2", "Data/ccEEJFO4001-DecorationPack - Textures.ba2", "Data/ccEEJFO4001-DecorationPack.esl"]),
            new("ccEEJFO4002-Nuka",                          "Nuka-Cola Collector Workshop",                ModCategory.Official, ["Data/ccEEJFO4002-Nuka - Main.ba2", "Data/ccEEJFO4002-Nuka - Textures.ba2", "Data/ccEEJFO4002-Nuka.esl"]),
            new("ccFRSFO4001-HandmadeShotgun",               "Handmade Shotgun",                            ModCategory.Official, ["Data/ccFRSFO4001-HandmadeShotgun - Main.ba2", "Data/ccFRSFO4001-HandmadeShotgun - Textures.ba2", "Data/ccFRSFO4001-HandmadeShotgun.esl"]),
            new("ccFRSFO4002-AntimaterielRifle",             "Anti-Materiel Rifle",                         ModCategory.Official, ["Data/ccFRSFO4002-AntimaterielRifle - Main.ba2", "Data/ccFRSFO4002-AntimaterielRifle - Textures.ba2", "Data/ccFRSFO4002-AntimaterielRifle.esl"]),
            new("ccFRSFO4003-CR75L",                         "CR-74L Combat Rifle",                         ModCategory.Official, ["Data/ccFRSFO4003-CR75L - Main.ba2", "Data/ccFRSFO4003-CR75L - Textures.ba2", "Data/ccFRSFO4003-CR75L.esl"]),
            new("ccFSVFO4001-ModularMilitaryBackpack",       "Modular Military Backpack",                   ModCategory.Official, ["Data/ccFSVFO4001-ModularMilitaryBackpack - Main.ba2", "Data/ccFSVFO4001-ModularMilitaryBackpack - Textures.ba2", "Data/ccFSVFO4001-ModularMilitaryBackpack.esl"]),
            new("ccFSVFO4002-MidCenturyModern",              "Modern Furniture Workshop Pack",              ModCategory.Official, ["Data/ccFSVFO4002-MidCenturyModern - Main.ba2", "Data/ccFSVFO4002-MidCenturyModern - Textures.ba2", "Data/ccFSVFO4002-MidCenturyModern.esl"]),
            new("ccFSVFO4003-Slocum",                        "Coffee and Donuts Workshop Pack",             ModCategory.Official, ["Data/ccFSVFO4003-Slocum - Main.ba2", "Data/ccFSVFO4003-Slocum - Textures.ba2", "Data/ccFSVFO4003-Slocum.esl"]),
            new("ccFSVFO4004-VRWorkshopGNRPlaza",            "Virtual Workshop: GNR Plaza",                 ModCategory.Official, ["Data/ccFSVFO4004-VRWorkshopGNRPlaza - Main.ba2", "Data/ccFSVFO4004-VRWorkshopGNRPlaza - Textures.ba2", "Data/ccFSVFO4004-VRWorkshopGNRPlaza.esl"]),
            new("ccFSVFO4005-VRDesertIsland",                "Virtual Workshop: Desert Island",             ModCategory.Official, ["Data/ccFSVFO4005-VRDesertIsland - Main.ba2", "Data/ccFSVFO4005-VRDesertIsland - Textures.ba2", "Data/ccFSVFO4005-VRDesertIsland.esl"]),
            new("ccFSVFO4006-VRWasteland",                   "Virtual Workshop: Capital Wasteland",         ModCategory.Official, ["Data/ccFSVFO4006-VRWasteland - Main.ba2", "Data/ccFSVFO4006-VRWasteland - Textures.ba2", "Data/ccFSVFO4006-VRWasteland.esl"]),
            new("ccFSVFO4007-Halloween",                     "Halloween Workshop",                          ModCategory.Official, ["Data/ccFSVFO4007-Halloween - Main.ba2", "Data/ccFSVFO4007-Halloween - Textures.ba2", "Data/ccFSVFO4007-Halloween.esl"]),
            new("ccGCAFO4001-FactionWS01Army",               "Weapon Paint Job - Army",                     ModCategory.Official, ["Data/ccGCAFO4001-FactionWS01Army - Main.ba2", "Data/ccGCAFO4001-FactionWS01Army - Textures.ba2", "Data/ccGCAFO4001-FactionWS01Army.esl"]),
            new("ccGCAFO4002-FactionWS02ACat",               "Weapon Paint Job - Atom Cats",                ModCategory.Official, ["Data/ccGCAFO4002-FactionWS02ACat - Main.ba2", "Data/ccGCAFO4002-FactionWS02ACat - Textures.ba2", "Data/ccGCAFO4002-FactionWS02ACat.esl"]),
            new("ccGCAFO4003-FactionWS03BOS",                "Weapon Paint Job - Brotherhood of Steel",     ModCategory.Official, ["Data/ccGCAFO4003-FactionWS03BOS - Main.ba2", "Data/ccGCAFO4003-FactionWS03BOS - Textures.ba2", "Data/ccGCAFO4003-FactionWS03BOS.esl"]),
            new("ccGCAFO4004-FactionWS04Gun",                "Weapon Paint Job - Gunners",                  ModCategory.Official, ["Data/ccGCAFO4004-FactionWS04Gun - Main.ba2", "Data/ccGCAFO4004-FactionWS04Gun - Textures.ba2", "Data/ccGCAFO4004-FactionWS04Gun.esl"]),
            new("ccGCAFO4005-FactionWS05HRPink",             "Weapon Paint Job - Hot Rod Pink",             ModCategory.Official, ["Data/ccGCAFO4005-FactionWS05HRPink - Main.ba2", "Data/ccGCAFO4005-FactionWS05HRPink - Textures.ba2", "Data/ccGCAFO4005-FactionWS05HRPink.esl"]),
            new("ccGCAFO4006-FactionWS06HRShark",            "Weapon Paint Job - Hot Rod Shark",            ModCategory.Official, ["Data/ccGCAFO4006-FactionWS06HRShark - Main.ba2", "Data/ccGCAFO4006-FactionWS06HRShark - Textures.ba2", "Data/ccGCAFO4006-FactionWS06HRShark.esl"]),
            new("ccGCAFO4007-FactionWS07HRFlames",           "Weapon Paint Job - Hot Rod Red Flames",       ModCategory.Official, ["Data/ccGCAFO4007-FactionWS07HRFlames - Main.ba2", "Data/ccGCAFO4007-FactionWS07HRFlames - Textures.ba2", "Data/ccGCAFO4007-FactionWS07HRFlames.esl"]),
            new("ccGCAFO4008-FactionWS08Inst",               "Weapon Paint Job - Institute",                ModCategory.Official, ["Data/ccGCAFO4008-FactionWS08Inst - Main.ba2", "Data/ccGCAFO4008-FactionWS08Inst - Textures.ba2", "Data/ccGCAFO4008-FactionWS08Inst.esl"]),
            new("ccGCAFO4009-FactionWS09MM",                 "Weapon Paint Job - Minutemen",                ModCategory.Official, ["Data/ccGCAFO4009-FactionWS09MM - Main.ba2", "Data/ccGCAFO4009-FactionWS09MM - Textures.ba2", "Data/ccGCAFO4009-FactionWS09MM.esl"]),
            new("ccGCAFO4010-FactionWS10RR",                 "Weapon Paint Job - Railroad",                 ModCategory.Official, ["Data/ccGCAFO4010-FactionWS10RR - Main.ba2", "Data/ccGCAFO4010-FactionWS10RR - Textures.ba2", "Data/ccGCAFO4010-FactionWS10RR.esl"]),
            new("ccGCAFO4011-FactionWS11VT",                 "Weapon Paint Job - Vault-Tec",                ModCategory.Official, ["Data/ccGCAFO4011-FactionWS11VT - Main.ba2", "Data/ccGCAFO4011-FactionWS11VT - Textures.ba2", "Data/ccGCAFO4011-FactionWS11VT.esl"]),
            new("ccGCAFO4012-FactionAS01ACat",               "Armor Paint Job - Atom Cats",                 ModCategory.Official, ["Data/ccGCAFO4012-FactionAS01ACat - Main.ba2", "Data/ccGCAFO4012-FactionAS01ACat - Textures.ba2", "Data/ccGCAFO4012-FactionAS01ACat.esl"]),
            new("ccGCAFO4013-FactionAS02BoS",                "Armor Paint Job - Brotherhood of Steel",      ModCategory.Official, ["Data/ccGCAFO4013-FactionAS02BoS - Main.ba2", "Data/ccGCAFO4013-FactionAS02BoS - Textures.ba2", "Data/ccGCAFO4013-FactionAS02BoS.esl"]),
            new("ccGCAFO4014-FactionAS03Gun",                "Armor Paint Job - Gunners",                   ModCategory.Official, ["Data/ccGCAFO4014-FactionAS03Gun - Main.ba2", "Data/ccGCAFO4014-FactionAS03Gun - Textures.ba2", "Data/ccGCAFO4014-FactionAS03Gun.esl"]),
            new("ccGCAFO4015-FactionAS04HRPink",             "Armor Paint Job - Hot Rod Pink",              ModCategory.Official, ["Data/ccGCAFO4015-FactionAS04HRPink - Main.ba2", "Data/ccGCAFO4015-FactionAS04HRPink - Textures.ba2", "Data/ccGCAFO4015-FactionAS04HRPink.esl"]),
            new("ccGCAFO4016-FactionAS05HRShark",            "Armor Paint Job - Hot Rod Shark",             ModCategory.Official, ["Data/ccGCAFO4016-FactionAS05HRShark - Main.ba2", "Data/ccGCAFO4016-FactionAS05HRShark - Textures.ba2", "Data/ccGCAFO4016-FactionAS05HRShark.esl"]),
            new("ccGCAFO4017-FactionAS06Inst",               "Armor Paint Job - Institute",                 ModCategory.Official, ["Data/ccGCAFO4017-FactionAS06Inst - Main.ba2", "Data/ccGCAFO4017-FactionAS06Inst - Textures.ba2", "Data/ccGCAFO4017-FactionAS06Inst.esl"]),
            new("ccGCAFO4018-FactionAS07MM",                 "Armor Paint Job - Minutemen",                 ModCategory.Official, ["Data/ccGCAFO4018-FactionAS07MM - Main.ba2", "Data/ccGCAFO4018-FactionAS07MM - Textures.ba2", "Data/ccGCAFO4018-FactionAS07MM.esl"]),
            new("ccGCAFO4019-FactionAS08Nuk",                "Armor Paint Job - Nuka-Cola",                 ModCategory.Official, ["Data/ccGCAFO4019-FactionAS08Nuk - Main.ba2", "Data/ccGCAFO4019-FactionAS08Nuk - Textures.ba2", "Data/ccGCAFO4019-FactionAS08Nuk.esl"]),
            new("ccGCAFO4020-FactionAS09RR",                 "Armor Paint Job - Railroad",                  ModCategory.Official, ["Data/ccGCAFO4020-FactionAS09RR - Main.ba2", "Data/ccGCAFO4020-FactionAS09RR - Textures.ba2", "Data/ccGCAFO4020-FactionAS09RR.esl"]),
            new("ccGCAFO4021-FactionAS10HRFlames",           "Armor Paint Job - Hot Rod Red Flames",        ModCategory.Official, ["Data/ccGCAFO4021-FactionAS10HRFlames - Main.ba2", "Data/ccGCAFO4021-FactionAS10HRFlames - Textures.ba2", "Data/ccGCAFO4021-FactionAS10HRFlames.esl"]),
            new("ccGCAFO4022-FactionAS11VT",                 "Armor Paint Job - Vault-Tec",                 ModCategory.Official, ["Data/ccGCAFO4022-FactionAS11VT - Main.ba2", "Data/ccGCAFO4022-FactionAS11VT - Textures.ba2", "Data/ccGCAFO4022-FactionAS11VT.esl"]),
            new("ccGCAFO4023-FactionAS12Army",               "Armor Paint Job - Army",                      ModCategory.Official, ["Data/ccGCAFO4023-FactionAS12Army - Main.ba2", "Data/ccGCAFO4023-FactionAS12Army - Textures.ba2", "Data/ccGCAFO4023-FactionAS12Army.esl"]),
            new("ccGCAFO4024-InstitutePlasmaWeapons",        "Institute Plasma Weapons",                    ModCategory.Official, ["Data/ccGCAFO4024-InstitutePlasmaWeapons - Main.ba2", "Data/ccGCAFO4024-InstitutePlasmaWeapons - Textures.ba2", "Data/ccGCAFO4024-InstitutePlasmaWeapons.esl"]),
            new("ccGCAFO4025-PAGunMM",                       "Gunners vs. Minutemen",                       ModCategory.Official, ["Data/ccGCAFO4025-PAGunMM - Main.ba2", "Data/ccGCAFO4025-PAGunMM - Textures.ba2", "Data/ccGCAFO4025-PAGunMM.esl"]),
            new("ccGRCFO4001-PipGreyTort",                   "Pip-Boy Paint Job - Grey Tortoise",           ModCategory.Official, ["Data/ccGRCFO4001-PipGreyTort - Main.ba2", "Data/ccGRCFO4001-PipGreyTort - Textures.ba2", "Data/ccGRCFO4001-PipGreyTort.esl"]),
            new("ccGRCFO4002-PipGreenVim",                   "Pip-Boy Paint Job - Green Vim!",              ModCategory.Official, ["Data/ccGRCFO4002-PipGreenVim - Main.ba2", "Data/ccGRCFO4002-PipGreenVim - Textures.ba2", "Data/ccGRCFO4002-PipGreenVim.esl"]),
            new("ccJVDFO4001-Holiday",                       "Holiday Workshop Pack",                       ModCategory.Official, ["Data/ccJVDFO4001-Holiday - Main.ba2", "Data/ccJVDFO4001-Holiday - Textures.ba2", "Data/ccJVDFO4001-Holiday.esl"]),
            new("ccKGJFO4001-bastion",                       "Settlement Ambush Kit",                       ModCategory.Official, ["Data/ccKGJFO4001-bastion - Main.ba2", "Data/ccKGJFO4001-bastion - Textures.ba2", "Data/ccKGJFO4001-bastion.esl"]),
            new("ccOTMFO4001-Remnants",                      "Enclave Remnants",                            ModCategory.Official, ["Data/ccOTMFO4001-Remnants - Main.ba2", "Data/ccOTMFO4001-Remnants - Textures.ba2", "Data/ccOTMFO4001-Remnants.esl"]),
            new("ccQDRFO4001_PowerArmorAI",                  "Sentinel Control System Companion",           ModCategory.Official, ["Data/ccQDRFO4001_PowerArmorAI - Main.ba2", "Data/ccQDRFO4001_PowerArmorAI - Textures.ba2", "Data/ccQDRFO4001_PowerArmorAI.esl"]),
            new("ccRPSFO4001-Scavenger",                     "Sea Scavengers",                              ModCategory.Official, ["Data/ccRPSFO4001-Scavenger - Main.ba2", "Data/ccRPSFO4001-Scavenger - Textures.ba2", "Data/ccRPSFO4001-Scavenger.esl"]),
            new("ccRZRFO4001-TunnelSnakes",                  "Tunnel Snakes Rule!",                         ModCategory.Official, ["Data/ccRZRFO4001-TunnelSnakes - Main.ba2", "Data/ccRZRFO4001-TunnelSnakes - Textures.ba2", "Data/ccRZRFO4001-TunnelSnakes.esm"]),
            new("ccRZRFO4002-Disintegrate",                  "Zetan Arsenal",                               ModCategory.Official, ["Data/ccRZRFO4002-Disintegrate - Main.ba2", "Data/ccRZRFO4002-Disintegrate - Textures.ba2", "Data/ccRZRFO4002-Disintegrate.esl"]),
            new("ccRZRFO4003-PipOver",                       "Pip-Boy Paint Job - Overseer",                ModCategory.Official, ["Data/ccRZRFO4003-PipOver - Main.ba2", "Data/ccRZRFO4003-PipOver - Textures.ba2", "Data/ccRZRFO4003-PipOver.esl"]),
            new("ccRZRFO4004-PipInst",                       "Pip-Boy Paint Job - Institute",               ModCategory.Official, ["Data/ccRZRFO4004-PipInst - Main.ba2", "Data/ccRZRFO4004-PipInst - Textures.ba2", "Data/ccRZRFO4004-PipInst.esl"]),
            new("ccSBJFO4001-SolarFlare",                    "Solar Cannon",                                ModCategory.Official, ["Data/ccSBJFO4001-SolarFlare - Main.ba2", "Data/ccSBJFO4001-SolarFlare - Textures.ba2", "Data/ccSBJFO4001-SolarFlare.esl"]),
            new("ccSBJFO4002_ManwellRifle",                  "Manwell Rifle Set",                           ModCategory.Official, ["Data/ccSBJFO4002_ManwellRifle - Main.ba2", "Data/ccSBJFO4002_ManwellRifle - Textures.ba2", "Data/ccSBJFO4002_ManwellRifle.esl"]),
            new("ccSBJFO4003-Grenade",                       "Makeshift Weapon Pack",                       ModCategory.Official, ["Data/ccSBJFO4003-Grenade - Main.ba2", "Data/ccSBJFO4003-Grenade - Textures.ba2", "Data/ccSBJFO4003-Grenade.esl"]),
            new("ccSBJFO4004-Ion",                           "Ion Gun",                                     ModCategory.Official, ["Data/ccSBJFO4004-Ion - Main.ba2", "Data/ccSBJFO4004-Ion - Textures.ba2", "Data/ccSBJFO4004-Ion.esl"]),
            new("ccSWKFO4001-AstronautPowerArmor",           "Astronaut Power Armor (Captain Cosmos)",      ModCategory.Official, ["Data/ccSWKFO4001-AstronautPowerArmor - Main.ba2", "Data/ccSWKFO4001-AstronautPowerArmor - Textures.ba2", "Data/ccSWKFO4001-AstronautPowerArmor.esm"]),
            new("ccSWKFO4002-PipNuka",                       "Pip-Boy Paint Job - Nuka-Cola",               ModCategory.Official, ["Data/ccSWKFO4002-PipNuka - Main.ba2", "Data/ccSWKFO4002-PipNuka - Textures.ba2", "Data/ccSWKFO4002-PipNuka.esl"]),
            new("ccSWKFO4003-PipQuan",                       "Pip-Boy Paint Job - Nuka-Cola Quantum",       ModCategory.Official, ["Data/ccSWKFO4003-PipQuan - Main.ba2", "Data/ccSWKFO4003-PipQuan - Textures.ba2", "Data/ccSWKFO4003-PipQuan.esl"]),
            new("ccTOSFO4001-NeoSky",                        "Noir Penthouse",                              ModCategory.Official, ["Data/ccTOSFO4001-NeoSky - Main.ba2", "Data/ccTOSFO4001-NeoSky - Textures.ba2", "Data/ccTOSFO4001-NeoSky.esm"]),
            new("ccTOSFO4002_NeonFlats",                     "Neon Flats",                                  ModCategory.Official, ["Data/ccTOSFO4002_NeonFlats - Main.ba2", "Data/ccTOSFO4002_NeonFlats - Textures.ba2", "Data/ccTOSFO4002_NeonFlats.esm"]),
            new("ccVLTFO4001-Homes",                         "Bunker Home Pack",                            ModCategory.Official, ["Data/ccVLTFO4001-Homes - Main.ba2", "Data/ccVLTFO4001-Homes - Textures.ba2", "Data/ccVLTFO4001-Homes.esm"]),
            new("ccYGPFO4001-PipCruiser",                    "Pip-Boy Paint Job - Cruiser",                 ModCategory.Official, ["Data/ccYGPFO4001-PipCruiser - Main.ba2", "Data/ccYGPFO4001-PipCruiser - Textures.ba2", "Data/ccYGPFO4001-PipCruiser.esl"]),
            new("ccZSEF04001-BHouse",                        "Charlestown Condo",                           ModCategory.Official, ["Data/ccZSEF04001-BHouse - Main.ba2", "Data/ccZSEF04001-BHouse - Textures.ba2", "Data/ccZSEF04001-BHouse.esm"]),
            new("ccZSEFO4002-SManor",                        "Shroud Manor",                                ModCategory.Official, ["Data/ccZSEFO4002-SManor - Main.ba2", "Data/ccZSEFO4002-SManor - Textures.ba2", "Data/ccZSEFO4002-SManor.esm"]),
            // ── CUT ─────────────────────────────────────────────────────────────────
            new("ccBGSFO4000-Cryopod",              "Cryopod",                         ModCategory.Cut, ["Data/ccBGSFO4000-Cryopod - Main.ba2", "Data/ccBGSFO4000-Cryopod.esm"]),
            new("ccBGSFO4017-Mauler",               "The Mauler",                      ModCategory.Cut, ["Data/ccBGSFO4017-Mauler - Main.ba2", "Data/ccBGSFO4017-Mauler - Textures.ba2", "Data/ccBGSFO4017-Mauler.esl"]),
            new("ccBGSFO4037-DgMeat",               "DogMeat? (4037-DgMeat)",          ModCategory.Cut, ["Data/ccBGSFO4037-DgMeat - Main.ba2", "Data/ccBGSFO4037-DgMeat - Textures.ba2", "Data/ccBGSFO4037-DgMeat.esl"]),
            new("ccBGSFO4039-TunnelSnakes",         "Scrapped Tunnel Snakes (4039)",   ModCategory.Cut, ["Data/ccBGSFO4039-TunnelSnakes - Main.ba2", "Data/ccBGSFO4039-TunnelSnakes - Textures.ba2", "Data/ccBGSFO4039-TunnelSnakes.esl"]),
            new("ccBGSFO4043-DoomChainsaw",         "Doom Chainsaw (Cut)",             ModCategory.Cut, ["Data/ccBGSFO4043-DoomChainsaw - Main.ba2", "Data/ccBGSFO4043-DoomChainsaw - Textures.ba2", "Data/ccBGSFO4043-DoomChainsaw.esl"]),
            new("ccBGSFO4066-Fishing",              "Fishing",                         ModCategory.Cut, ["Data/ccBGSFO4066-Fishing - Main.ba2", "Data/ccBGSFO4066-Fishing - Textures.ba2", "Data/ccBGSFO4066-Fishing.esl"]),
            new("ccBGSFO4100-AS_Santa",             "Scrapped Holiday (AS_Santa)",     ModCategory.Cut, ["Data/ccBGSFO4100-AS_Santa - Main.ba2", "Data/ccBGSFO4100-AS_Santa - Textures.ba2", "Data/ccBGSFO4100-AS_Santa.esl"]),
            new("ccBGSFO4102-AS_Snowflakes",        "Scrapped Holiday (AS_Snowflakes)",ModCategory.Cut, ["Data/ccBGSFO4102-AS_Snowflakes - Main.ba2", "Data/ccBGSFO4102-AS_Snowflakes - Textures.ba2", "Data/ccBGSFO4102-AS_Snowflakes.esl"]),
            new("ccBGSFO4109-WS_Christmas",         "Scrapped Holiday (WS_Christmas)", ModCategory.Cut, ["Data/ccBGSFO4109-WS_Christmas - Main.ba2", "Data/ccBGSFO4109-WS_Christmas - Textures.ba2", "Data/ccBGSFO4109-WS_Christmas.esl"]),
            new("ccFRSFO4004-127MkII",              "127MkII Weapon",                  ModCategory.Cut, ["Data/ccFRSFO4004-127MkII - Main.ba2", "Data/ccFRSFO4004-127MkII - Textures.ba2", "Data/ccFRSFO4004-127MkII.esl"]),
            new("ccPMLFO4001-LaserBallista",        "LaserBallista",                   ModCategory.Cut, ["Data/ccPMLFO4001-LaserBallista - Main.ba2", "Data/ccPMLFO4001-LaserBallista.esl"]),
            new("ccPNNFO4001-Scavenger",            "Scavenger",                       ModCategory.Cut, ["Data/ccPNNFO4001-Scavenger - Main.ba2", "Data/ccPNNFO4001-Scavenger - Textures.ba2", "Data/ccPNNFO4001-Scavenger.esl"]),
            new("ccSWKFO4004-AtomicWanderer",       "Atomic Wanderer",                 ModCategory.Cut, ["Data/ccSWKFO4004-AtomicWanderer - Main.ba2", "Data/ccSWKFO4004-AtomicWanderer - Textures.ba2", "Data/ccSWKFO4004-AtomicWanderer.esl"]),
            new("ccTOSFO4VLT",                      "Virtual Workshop",                ModCategory.Cut, ["Data/ccTOSFO4VLT - Main.ba2", "Data/ccTOSFO4VLT - Textures.ba2", "Data/ccTOSFO4VLT.esl"]),
        };

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PrintHeader();

            var choice = PromptMainMenu();
            List<Mod> selected;

            switch (choice)
            {
                case 1:
                    selected = AllMods.ToList();
                    break;
                case 2:
                    selected = AllMods.Where(m => m.Category == ModCategory.Official).ToList();
                    break;
                case 3:
                    selected = AllMods.Where(m => m.Category == ModCategory.Cut).ToList();
                    break;
                case 4:
                    selected = RunCustomChoice();
                    break;
                default:
                    return;
            }

            WriteFilelist(selected);
        }

static void PrintHeader()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    
    // Title Box
    Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║               Fallout 4 CC Filelist Generator              ║");
    Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    
    Console.ForegroundColor = ConsoleColor.White;

    // Metadata row with clickable masked links
    Console.Write(" Author: Exiled Eye          ");
    
    // Link 1: GitHub
    Link("GitHub", "https://github.com/ExiledEye/");
    
    Console.Write("                ");
    
    // Link 2: Nexus Mods
    Link("Nexus Mods", "https://www.nexusmods.com/profile/ExiledEye");
    
    Console.WriteLine();
    Console.WriteLine("──────────────────────────────────────────────────────────────");
    Console.ResetColor();
    Console.WriteLine();
}

static void Link(string text, string url)
{
    Console.Write("\x1b[4m"); // Enable Underline
    Console.ForegroundColor = ConsoleColor.Blue; 
    
    // OSC 8 Hyperlink Escape Sequence
    Console.Write($"\x1b]8;;{url}\x1b\\{text}\x1b]8;;\x1b\\");
    
    Console.Write("\x1b[24m"); // Disable Underline
    Console.ForegroundColor = ConsoleColor.Cyan;
}

        static int PromptMainMenu()
        {
            Console.WriteLine("Select which mods to include in the filelist:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [1]  Official Creation Club Mods + Cut Creation Club Mods");
            Console.WriteLine("  [2]  Official Creation Club Mods only");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  [3]  Cut Creation Club Mods only");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  [4]  Custom Choice (pick every mod individually)");
            Console.ResetColor();
            Console.WriteLine();

            while (true)
            {
                Console.Write("Your choice (1-4): ");
                var input = Console.ReadLine()?.Trim();
                if (int.TryParse(input, out int n) && n >= 1 && n <= 4)
                    return n;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Invalid input, enter 1, 2, 3 or 4.");
                Console.ResetColor();
            }
        }

        static List<Mod> RunCustomChoice()
        {
            var selected = new List<Mod>();

            Console.Clear();
            PrintHeader();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Custom mode: for each mod press Y to include, N to skip, or Q to quit.\n");
            Console.ResetColor();

            ModCategory? currentSection = null;

            foreach (var mod in AllMods)
            {
                if (mod.Category != currentSection)
                {
                    currentSection = mod.Category;
                    Console.WriteLine();
                    Console.ForegroundColor = currentSection == ModCategory.Official ? ConsoleColor.Green : ConsoleColor.Yellow;
                    Console.WriteLine(currentSection == ModCategory.Official
                        ? "─── Official Creation Club Mods ──────────────────────────────"
                        : "─── Cut Creation Club Mods ───────────────────────────────────");
                    Console.ResetColor();
                    Console.WriteLine();
                }

                string noFilesTag = mod.Files.Length == 0 ? " [no files in depot]" : "";

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"  {mod.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($" ({mod.Name}{noFilesTag})");
                    Console.ResetColor();
                    Console.Write("  [Y/N/Q]: ");

                    var key = Console.ReadKey(intercept: true);
                    Console.WriteLine();

                    if (key.Key == ConsoleKey.Y)
                    {
                        selected.Add(mod);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    ✓ Included");
                        Console.ResetColor();
                        break;
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("    – Skipped");
                        Console.ResetColor();
                        break;
                    }
                    else if (key.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("  Selection interrupted. Writing filelist with mods selected so far...");
                        Console.ResetColor();
                        return selected;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    Press Y, N or Q.");
                        Console.ResetColor();
                    }
                }
            }

            return selected;
        }

        static void WriteFilelist(List<Mod> selected)
        {
            var lines = selected
                .SelectMany(m => m.Files)
                .ToList();

            int totalFiles = lines.Count;
            int modsWithFiles = selected.Count(m => m.Files.Length > 0);
            int modsNoFiles   = selected.Count(m => m.Files.Length == 0);

            string outputPath = Path.Combine(
                AppContext.BaseDirectory,
                "filelist.txt");

            File.WriteAllLines(outputPath, lines, new System.Text.UTF8Encoding(false));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  filelist.txt written successfully.");
            Console.ResetColor();
            Console.WriteLine($"  Location : {outputPath}");
            Console.WriteLine($"  Mods selected   : {selected.Count}");
            if (modsNoFiles > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  Mods with no depot files (skipped in output): {modsNoFiles}");
                Console.ResetColor();
            }
            Console.WriteLine($"  File entries written: {totalFiles}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("══════════════════════════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("This program is part of Creation Club Depot Download Guide");
            Console.WriteLine("\x1b[4m" + $"\x1b]8;;https://www.nexusmods.com/fallout4/mods/105934\x1b\\https://www.nexusmods.com/fallout4/mods/105934\x1b]8;;\x1b\\" + "\x1B[0m");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(intercept: true);
        }
    }
}
