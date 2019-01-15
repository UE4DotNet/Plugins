// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

#pragma warning disable CS0108
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>
    ///SensingComponent encapsulates sensory (ie sight and hearing) settings and functionality for an Actor,
    ///allowing the actor to see/hear Pawns in the world.
    ///</summary>
    ///<remarks>It does nothing on network clients.</remarks>
    public unsafe partial class PawnSensingComponent : ActorComponent  {

        ///<summary>Get Peripheral Vision Angle</summary>
        public float GetPeripheralVisionAngle()  => 
            PawnSensingComponent_methods.GetPeripheralVisionAngle_method.Invoke(ObjPointer);

        ///<summary>Get Peripheral Vision Cosine</summary>
        public float GetPeripheralVisionCosine()  => 
            PawnSensingComponent_methods.GetPeripheralVisionCosine_method.Invoke(ObjPointer);

        ///<summary>Sets PeripheralVisionAngle. Calculates PeripheralVisionCosine from PeripheralVisionAngle</summary>
        public void SetPeripheralVisionAngle(float NewPeripheralVisionAngle)  => 
            PawnSensingComponent_methods.SetPeripheralVisionAngle_method.Invoke(ObjPointer, NewPeripheralVisionAngle);

        ///<summary>Changes the SensingInterval.</summary>
        ///<remarks>
        ///If we are currently waiting for an interval, this can either extend or shorten that interval.
        ///A value <= 0 prevents any updates.
        ///</remarks>
        public void SetSensingInterval(float NewSensingInterval)  => 
            PawnSensingComponent_methods.SetSensingInterval_method.Invoke(ObjPointer, NewSensingInterval);

        ///<summary>Enables or disables sensing updates. The timer is reset in either case.</summary>
        public void SetSensingUpdatesEnabled(bool bEnabled)  => 
            PawnSensingComponent_methods.SetSensingUpdatesEnabled_method.Invoke(ObjPointer, bEnabled);
        ///<summary>Max distance at which a makenoise(1.0) loudness sound can be heard, regardless of occlusion</summary>
        public unsafe float HearingThreshold {
            get {return PawnSensingComponent_ptr->HearingThreshold;}
            set {PawnSensingComponent_ptr->HearingThreshold = value;}
        }
        ///<summary>Max distance at which a makenoise(1.0) loudness sound can be heard if unoccluded (LOSHearingThreshold should be > HearingThreshold)</summary>
        public unsafe float LOSHearingThreshold {
            get {return PawnSensingComponent_ptr->LOSHearingThreshold;}
            set {PawnSensingComponent_ptr->LOSHearingThreshold = value;}
        }
        ///<summary>Maximum sight distance.</summary>
        public unsafe float SightRadius {
            get {return PawnSensingComponent_ptr->SightRadius;}
            set {PawnSensingComponent_ptr->SightRadius = value;}
        }
        ///<summary>Amount of time between pawn sensing updates. Use SetSensingInterval() to adjust this at runtime. A value <= 0 prevents any updates.</summary>
        public unsafe float SensingInterval {
            get {return PawnSensingComponent_ptr->SensingInterval;}
        }
        ///<summary>Max age of sounds we can hear. Should be greater than SensingInterval, or you might miss hearing some sounds!</summary>
        public unsafe float HearingMaxSoundAge {
            get {return PawnSensingComponent_ptr->HearingMaxSoundAge;}
            set {PawnSensingComponent_ptr->HearingMaxSoundAge = value;}
        }
        public bool bEnableSensingUpdates {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSensingUpdates"); }
        }
        public bool bOnlySensePlayers {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlySensePlayers"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlySensePlayers", value); }
        }
        public bool bSeePawns {
            get {return Main.GetGetBoolPropertyByName(this, "bSeePawns"); }
            set {Main.SetGetBoolPropertyByName(this, "bSeePawns", value); }
        }
        public bool bHearNoises {
            get {return Main.GetGetBoolPropertyByName(this, "bHearNoises"); }
            set {Main.SetGetBoolPropertyByName(this, "bHearNoises", value); }
        }
         //TODO: multicast delegate FSeePawnDelegate OnSeePawn
         //TODO: multicast delegate FHearNoiseDelegate OnHearNoise
        ///<summary>How far to the side AI can see, in degrees. Use SetPeripheralVisionAngle to change the value at runtime.</summary>
        public unsafe float PeripheralVisionAngle {
            get {return PawnSensingComponent_ptr->PeripheralVisionAngle;}
        }
        ///<summary>Cosine of limits of peripheral vision. Computed from PeripheralVisionAngle.</summary>
        public unsafe float PeripheralVisionCosine {
            get {return PawnSensingComponent_ptr->PeripheralVisionCosine;}
            set {PawnSensingComponent_ptr->PeripheralVisionCosine = value;}
        }
        static PawnSensingComponent() {
            StaticClass = Main.GetClass("PawnSensingComponent");
        }
        internal unsafe PawnSensingComponent_fields* PawnSensingComponent_ptr => (PawnSensingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnSensingComponent(IntPtr p) => UObject.Make<PawnSensingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnSensingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnSensingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
