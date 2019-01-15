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
    ///<summary>Particle Module Beam Noise</summary>
    public unsafe partial class ParticleModuleBeamNoise : ParticleModuleBeamBase  {
        public bool bLowFreq_Enabled {
            get {return Main.GetGetBoolPropertyByName(this, "bLowFreq_Enabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bLowFreq_Enabled", value); }
        }
        ///<summary>The frequency of noise points.</summary>
        public unsafe int Frequency {
            get {return ParticleModuleBeamNoise_ptr->Frequency;}
            set {ParticleModuleBeamNoise_ptr->Frequency = value;}
        }
        ///<summary>
        ///If not 0, then the frequency will select a random value in the range
        ///        [Frequency_LowRange.
        ///</summary>
        ///<remarks>.Frequency]</remarks>
        public unsafe int Frequency_LowRange {
            get {return ParticleModuleBeamNoise_ptr->Frequency_LowRange;}
            set {ParticleModuleBeamNoise_ptr->Frequency_LowRange = value;}
        }
        ///<summary>The noise point ranges.</summary>
        public unsafe RawDistributionVector NoiseRange {
            get {return ParticleModuleBeamNoise_ptr->NoiseRange;}
            set {ParticleModuleBeamNoise_ptr->NoiseRange = value;}
        }
        ///<summary>A scale factor that will be applied to the noise range.</summary>
        public unsafe RawDistributionFloat NoiseRangeScale {
            get {return ParticleModuleBeamNoise_ptr->NoiseRangeScale;}
            set {ParticleModuleBeamNoise_ptr->NoiseRangeScale = value;}
        }
        public bool bNRScaleEmitterTime {
            get {return Main.GetGetBoolPropertyByName(this, "bNRScaleEmitterTime"); }
            set {Main.SetGetBoolPropertyByName(this, "bNRScaleEmitterTime", value); }
        }
        ///<summary>The speed with which to move each noise point.</summary>
        public unsafe RawDistributionVector NoiseSpeed {
            get {return ParticleModuleBeamNoise_ptr->NoiseSpeed;}
            set {ParticleModuleBeamNoise_ptr->NoiseSpeed = value;}
        }
        public bool bSmooth {
            get {return Main.GetGetBoolPropertyByName(this, "bSmooth"); }
            set {Main.SetGetBoolPropertyByName(this, "bSmooth", value); }
        }
        ///<summary>Default target-point information to use if the beam method is endpoint.</summary>
        public unsafe float NoiseLockRadius {
            get {return ParticleModuleBeamNoise_ptr->NoiseLockRadius;}
            set {ParticleModuleBeamNoise_ptr->NoiseLockRadius = value;}
        }
        public bool bNoiseLock {
            get {return Main.GetGetBoolPropertyByName(this, "bNoiseLock"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoiseLock", value); }
        }
        public bool bOscillate {
            get {return Main.GetGetBoolPropertyByName(this, "bOscillate"); }
            set {Main.SetGetBoolPropertyByName(this, "bOscillate", value); }
        }
        ///<summary>How long the  noise points should be locked - 0.0 indicates forever.</summary>
        public unsafe float NoiseLockTime {
            get {return ParticleModuleBeamNoise_ptr->NoiseLockTime;}
            set {ParticleModuleBeamNoise_ptr->NoiseLockTime = value;}
        }
        ///<summary>The tension to apply to the tessellated noise line.</summary>
        public unsafe float NoiseTension {
            get {return ParticleModuleBeamNoise_ptr->NoiseTension;}
            set {ParticleModuleBeamNoise_ptr->NoiseTension = value;}
        }
        public bool bUseNoiseTangents {
            get {return Main.GetGetBoolPropertyByName(this, "bUseNoiseTangents"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseNoiseTangents", value); }
        }
        ///<summary>The strength of noise tangents, if enabled.</summary>
        public unsafe RawDistributionFloat NoiseTangentStrength {
            get {return ParticleModuleBeamNoise_ptr->NoiseTangentStrength;}
            set {ParticleModuleBeamNoise_ptr->NoiseTangentStrength = value;}
        }
        ///<summary>The amount of tessellation between noise points.</summary>
        public unsafe int NoiseTessellation {
            get {return ParticleModuleBeamNoise_ptr->NoiseTessellation;}
            set {ParticleModuleBeamNoise_ptr->NoiseTessellation = value;}
        }
        public bool bTargetNoise {
            get {return Main.GetGetBoolPropertyByName(this, "bTargetNoise"); }
            set {Main.SetGetBoolPropertyByName(this, "bTargetNoise", value); }
        }
        ///<summary>The distance at which to deposit noise points.</summary>
        ///<remarks>
        ///If 0.0, then use the static frequency value.
        ///If not, distribute noise points at the given distance, up to the static Frequency value.
        ///At that point, evenly distribute them along the beam.
        ///</remarks>
        public unsafe float FrequencyDistance {
            get {return ParticleModuleBeamNoise_ptr->FrequencyDistance;}
            set {ParticleModuleBeamNoise_ptr->FrequencyDistance = value;}
        }
        public bool bApplyNoiseScale {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyNoiseScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyNoiseScale", value); }
        }
        ///<summary>The scale factor to apply to noise range.</summary>
        ///<remarks>
        ///The lookup value is determined by dividing the number of noise points present by the
        ///maximum number of noise points (Frequency).
        ///</remarks>
        public unsafe RawDistributionFloat NoiseScale {
            get {return ParticleModuleBeamNoise_ptr->NoiseScale;}
            set {ParticleModuleBeamNoise_ptr->NoiseScale = value;}
        }
        static ParticleModuleBeamNoise() {
            StaticClass = Main.GetClass("ParticleModuleBeamNoise");
        }
        internal unsafe ParticleModuleBeamNoise_fields* ParticleModuleBeamNoise_ptr => (ParticleModuleBeamNoise_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleBeamNoise(IntPtr p) => UObject.Make<ParticleModuleBeamNoise>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleBeamNoise DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleBeamNoise New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
