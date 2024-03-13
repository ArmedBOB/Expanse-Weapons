using System.Collections.Generic;
using System;
using System.Collections.Concurrent;
using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.ArmorDefinition.ArmorType;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces.Terminal;
using Sandbox.ModAPI.Weapons;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.Input;
using VRage.ModAPI;
using VRage.Utils;
using VRage.Voxels;
using VRageMath;
using Sandbox.Definitions;
using System.IO;

using static Sandbox.Definitions.MyDefinitionManager;
using static Scripts.Session;

namespace Scripts
{
    partial class Parts
    {
        internal DictionaryValuesReader<MyDefinitionId, MyDefinitionBase> AllDefinitions;
        internal List<KeyValuePair<WeaponDefinition, BaseGunStats>> Weapons;
        internal Parts()
        {
            AllDefinitions = Static.GetAllDefinitions();
            // naming convention: WeaponDefinition Name
            //
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            // PartDefinitions(Weapon75, Phantom01);
            // ArmorDefinitions(Armor1, Armor2);
            // SupportDefinitions(ArmorEnhancer1A);
            // UpgradeDefinitions(Upgrade75a, Upgrade75b);
            Weapons = new List<KeyValuePair<WeaponDefinition, BaseGunStats>>
            {
                // Add new weapons with their corresponding gun stats
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ApolloClassTorpedoLauncherPart,ApolloClassTorpedoLauncher),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ApolloClassTorpedoLauncherMESPart,ApolloClassTorpedoLauncherMES),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(AresClassTorpedoLauncherFlatPart,AresClassTorpedoLauncherFlat),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(AresClassTorpedoLauncherPart,AresClassTorpedoLauncher),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(AresClassTorpedoLauncherFlatPartMES,AresClassTorpedoLauncherFlat),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(AresClassTorpedoLauncherPartMES,AresClassTorpedoLauncher),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(DawsonPatternMediumRailgunPart,DawsonPatternMediumRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(DawsonPatternMediumRailgunPartMES,DawsonPatternMediumRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(FarrenPatternHeavyRailgunPart,FarrenPatternHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(FarrenPatternHeavyRailgunPartMES,FarrenPatternHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(GlapionCollectiveGatlingCannonPart,GlapionCollectiveGatlingCannon),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(KessHashari180mmCannonPart,KessHashari180mmCannon),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(NarimanDynamicsPDCPart,NarimanDynamicsPDC),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(NarimanDynamicsPDCPartMES,NarimanDynamicsPDC),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(OstmanJazinskiFlakCannonPart,OstmanJazinskiFlakCannon),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(OstmanJazinskiFlakCannonMESPart,OstmanJazinskiFlakCannonMES),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(OPAPointDefenceCannonPart,OPAPointDefenceCannon),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(RedfieldBallisticsPDCPart,RedfieldBallisticsPDC),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(RedfieldBallisticsPDCPartMES,RedfieldBallisticsPDC),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(TychoClassTorpedoMountPart,TychoClassTorpedoMount),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(TychoClassTorpedoMountMESPart,TychoClassTorpedoMountMES),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(V14StilettoLightRailgunPart,V14StilettoLightRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(V14StilettoLightRailgunPartMES,V14StilettoLightRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(VoltaireCollectiveAntiPersonnelPDCPart,VoltaireCollectiveAntiPersonnelPDC),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(VX12FoehammerUltraHeavyRailgunPart,VX12FoehammerUltraHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(VX12FoehammerUltraHeavyRailgunPartMES,VX12FoehammerUltraHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(MountedZakosetaraHeavyRailgunPart,ZakosetaraHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(T47RociLightFixedRailgunPart,ZakosetaraHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ZakosetaraHeavyRailgunPart,ZakosetaraHeavyRailgun),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ZakosetaraHeavyRailgunMESPart,ZakosetaraHeavyRailgunMES),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ZeusClassRapidTorpedoLauncherPart,ZeusClassRapidTorpedoLauncher),
                new KeyValuePair<WeaponDefinition, BaseGunStats>(ZeusClassRapidTorpedoLauncherPartMES,ZeusClassRapidTorpedoLauncher),
            };
            foreach (var pair in Weapons)
            {
                // Perform adjustments before defining the parts
                AdjustInventoryCapacity(pair.Key, pair.Value);
            }

            PartDefinitions(ApolloClassTorpedoLauncherPart,
                ApolloClassTorpedoLauncherMESPart,
                AresClassTorpedoLauncherFlatPart,
                AresClassTorpedoLauncherPart,
                AresClassTorpedoLauncherFlatPartMES,
                AresClassTorpedoLauncherPartMES,
                DawsonPatternMediumRailgunPart,
                DawsonPatternMediumRailgunPartMES,
                FarrenPatternHeavyRailgunPart,
                FarrenPatternHeavyRailgunPartMES,
                GlapionCollectiveGatlingCannonPart,
                KessHashari180mmCannonPart,
                NarimanDynamicsPDCPart,
                NarimanDynamicsPDCPartMES,
                OPAPointDefenceCannonPart,
                OstmanJazinskiFlakCannonPart,
                OstmanJazinskiFlakCannonMESPart,
                RedfieldBallisticsPDCPart,
                RedfieldBallisticsPDCPartMES,
                TychoClassTorpedoMountPart,
                TychoClassTorpedoMountMESPart,
                V14StilettoLightRailgunPart,
                V14StilettoLightRailgunPartMES,
                VoltaireCollectiveAntiPersonnelPDCPart,
                VX12FoehammerUltraHeavyRailgunPart,
                VX12FoehammerUltraHeavyRailgunPartMES,
                MountedZakosetaraHeavyRailgunPart,
                T47RociLightFixedRailgunPart,
                ZakosetaraHeavyRailgunPart,
                ZakosetaraHeavyRailgunMESPart,
                ZeusClassRapidTorpedoLauncherPart,
                ZeusClassRapidTorpedoLauncherPartMES);
        }

        private void AdjustInventoryCapacity(WeaponDefinition weapon,BaseGunStats gun)
        {
            float inventory = 2;
            foreach (var t in AllDefinitions)
            {
                if (t.Id.SubtypeName == weapon.Assignments.MountPoints[0].SubtypeId)
                {
                    MyCubeBlockDefinition blockDef = t as MyCubeBlockDefinition;
                    if (blockDef != null)
                    {
                        blockDef.IntegrityPointsPerSec = 500;
                    }
                    MyWeaponBlockDefinition weaponBlockDef = t as MyWeaponBlockDefinition;
                    if (weaponBlockDef != null)
                    {
                        foreach (var def in AllDefinitions)
                        {
                            if (weapon.Ammos[0].AmmoMagazine == def.Id.SubtypeName)
                            {
                                var magDef = def as MyAmmoMagazineDefinition;
                                if (magDef != null)
                                {
                                    float factor = 1f;
                                    if (gun.NumberOfMagazines != 0)
                                    {
                                        factor = (float)gun.NumberOfMagazines;
                                    }
                                    inventory = (float)(magDef.Volume / 3) * factor;
                                    Log.CleanLine("Volume for " + magDef.Id.SubtypeName + " is: " + magDef.Volume);
                                    Log.CleanLine("Inventory size for " + t.Id.SubtypeName + " is: " + inventory);
                                    Log.CleanLine("PCU for " + t.Id.SubtypeName + " is: " + blockDef.PCU);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
