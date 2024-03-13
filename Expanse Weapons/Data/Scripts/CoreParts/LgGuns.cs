using System.Collections.Generic;
using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;


namespace Scripts
{
    partial class Parts
    {
        public struct BaseGunStats
        {
            public string SubtypeID;
            public double NumberOfMagazines;
        }
        // Belter Weapons
        public static BaseGunStats VoltaireCollectiveAntiPersonnelPDC = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats OstmanJazinskiFlakCannon = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats OstmanJazinskiFlakCannonMES = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats OPAPointDefenceCannon = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats GlapionCollectiveGatlingCannon = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        }; 

        public static BaseGunStats KessHashari180mmCannon = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 100.5
        };

        public static BaseGunStats ZakosetaraHeavyRailgun = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 10.5
        };

        public static BaseGunStats ZakosetaraHeavyRailgunMES = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 10.5
        };

        public static BaseGunStats TychoClassTorpedoMount = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats TychoClassTorpedoMountMES = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats ApolloClassTorpedoLauncher = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 3.5
        };

        public static BaseGunStats ApolloClassTorpedoLauncherMES = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 3.5
        };

        // End of Belter Weapons



        // UNN Weapons

        public static BaseGunStats RedfieldBallisticsPDC = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats DawsonPatternMediumRailgun = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 25.5
        };

        public static BaseGunStats FarrenPatternHeavyRailgun = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 15.5
        };

        // End of UNN Weapons



        // MCRN Weapons

        public static BaseGunStats NarimanDynamicsPDC = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 1.5
        };

        public static BaseGunStats VX12FoehammerUltraHeavyRailgun = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 15.5
        };

        public static BaseGunStats V14StilettoLightRailgun = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 25.5
        };

        // End of MCRN Weapons



        // Shared Torpedo Launchers
        public static BaseGunStats AresClassTorpedoLauncherFlat = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 4.5
        };

        public static BaseGunStats AresClassTorpedoLauncher = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 4.5
        };

        public static BaseGunStats ZeusClassRapidTorpedoLauncher = new BaseGunStats
        {
            SubtypeID = "",
            NumberOfMagazines = 9.5
        };

        // End of Shared Torpedo Launchers

    }
}
