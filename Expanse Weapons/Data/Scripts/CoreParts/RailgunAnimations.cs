using System.Collections.Generic;
using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        private Structure.WeaponDefinition.AnimationDef RailgunAnimation => new Structure.WeaponDefinition.AnimationDef
        {

            EventParticles = new Dictionary<Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers, Structure.WeaponDefinition.AnimationDef.EventParticle[]>
            {
                [PreFire] = new[]{ //This particle fires in the Prefire state, during the 2 second windup.
                                   //Valid options include Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire.
                       new Structure.WeaponDefinition.AnimationDef.EventParticle
                       {
                           EmptyNames = Names("muzzle_missile_1"), //If you want an effect on your own dummy
                           MuzzleNames = Names("muzzle_missile_1"), //If you want an effect on the muzzle
                           StartDelay = 0, //ticks 60 = 1 second, delay until particle starts.
                           LoopDelay = 0, //ticks 60 = 1 second
                           ForceStop = false,
                           Particle = new Structure.WeaponDefinition.ParticleDef
                           {
                               Name = "Muzzle_Flash_RailgunLargeVaRe", //Particle subtypeID
                               Color = Color(red: 25, green: 25, blue: 25, alpha: 1), //This is redundant as recolouring is no longer supported.
                               Extras = new Structure.WeaponDefinition.ParticleOptionDef //do your particle colours in your particle file instead.
                               {
                                   Loop = true, //Should match your particle definition.
                                   Restart = false,
                                   MaxDistance = 1000, //meters
                                   MaxDuration = 0, //ticks 60 = 1 second
                                   Scale = 1, //How chunky the particle is.
                               }
                           }
                       },
                   },
            },

        };
    }
}