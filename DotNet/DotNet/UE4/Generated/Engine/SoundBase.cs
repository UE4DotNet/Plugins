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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Sound Base</summary>
    public unsafe partial class SoundBase : UObject  {
        ///<summary>Sound class this sound belongs to</summary>
        public unsafe SoundClass SoundClassObject {
            get {return SoundBase_ptr->SoundClassObject;}
            set {SoundBase_ptr->SoundClassObject = value;}
        }
        public bool bDebug {
            get {return Main.GetGetBoolPropertyByName(this, "bDebug"); }
            set {Main.SetGetBoolPropertyByName(this, "bDebug", value); }
        }
        public bool bOverrideConcurrency {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideConcurrency"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideConcurrency", value); }
        }
        public bool bOutputToBusOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bOutputToBusOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bOutputToBusOnly", value); }
        }
        public bool bHasDelayNode {
            get {return Main.GetGetBoolPropertyByName(this, "bHasDelayNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasDelayNode", value); }
        }
        public bool bHasConcatenatorNode {
            get {return Main.GetGetBoolPropertyByName(this, "bHasConcatenatorNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasConcatenatorNode", value); }
        }
        public bool bHasVirtualizeWhenSilent {
            get {return Main.GetGetBoolPropertyByName(this, "bHasVirtualizeWhenSilent"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasVirtualizeWhenSilent", value); }
        }
        public bool bBypassVolumeScaleForPriority {
            get {return Main.GetGetBoolPropertyByName(this, "bBypassVolumeScaleForPriority"); }
            set {Main.SetGetBoolPropertyByName(this, "bBypassVolumeScaleForPriority", value); }
        }
        ///<summary>If Override Concurrency is false, the sound concurrency settings to use for this sound.</summary>
        public unsafe SoundConcurrency SoundConcurrencySettings {
            get {return SoundBase_ptr->SoundConcurrencySettings;}
            set {SoundBase_ptr->SoundConcurrencySettings = value;}
        }
        ///<summary>If Override Concurrency is true, concurrency settings to use.</summary>
        public unsafe SoundConcurrencySettings ConcurrencyOverrides {
            get {return SoundBase_ptr->ConcurrencyOverrides;}
            set {SoundBase_ptr->ConcurrencyOverrides = value;}
        }
        ///<summary>Duration of sound in seconds.</summary>
        public unsafe float Duration {
            get {return SoundBase_ptr->Duration;}
        }
        ///<summary>The max distance of the asset, as determined by attenuation settings.</summary>
        public unsafe float MaxDistance {
            get {return SoundBase_ptr->MaxDistance;}
        }
        ///<summary>Total number of samples (in the thousands). Useful as a metric to analyze the relative size of a given sound asset in content browser.</summary>
        public unsafe float TotalSamples {
            get {return SoundBase_ptr->TotalSamples;}
        }
        ///<summary>Sound priority (higher value is higher priority) used for concurrency resolution. This priority value is weighted against the final volume of the sound.</summary>
        public unsafe float Priority {
            get {return SoundBase_ptr->Priority;}
            set {SoundBase_ptr->Priority = value;}
        }
        ///<summary>Attenuation settings package for the sound</summary>
        public unsafe SoundAttenuation AttenuationSettings {
            get {return SoundBase_ptr->AttenuationSettings;}
            set {SoundBase_ptr->AttenuationSettings = value;}
        }
        ///<summary>Sound submix this sound belongs to.</summary>
        ///<remarks>
        ///Audio will play here and traverse through the submix graph.
        ///A null entry will make the sound obey the default master effects graph.
        ///</remarks>
        public unsafe SoundSubmix SoundSubmixObject {
            get {return SoundBase_ptr->SoundSubmixObject;}
            set {SoundBase_ptr->SoundSubmixObject = value;}
        }
         //TODO: array not UObject TArray SoundSubmixSends
        ///<summary>The source effect chain to use for this sound.</summary>
        public unsafe SoundEffectSourcePresetChain SourceEffectChain {
            get {return SoundBase_ptr->SourceEffectChain;}
            set {SoundBase_ptr->SourceEffectChain = value;}
        }
         //TODO: array not UObject TArray BusSends
         //TODO: array not UObject TArray PreEffectBusSends
        static SoundBase() {
            StaticClass = Main.GetClass("SoundBase");
        }
        internal unsafe SoundBase_fields* SoundBase_ptr => (SoundBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundBase(IntPtr p) => UObject.Make<SoundBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
