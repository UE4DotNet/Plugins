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
    ///<summary>PawnNoiseEmitterComponent tracks noise event data used by SensingComponents to hear a Pawn.</summary>
    ///<remarks>This component is intended to exist on either a Pawn or its Controller. It does nothing on network clients.</remarks>
    public unsafe partial class PawnNoiseEmitterComponent : ActorComponent  {

        ///<summary>
        ///Cache noises instigated by the owning pawn for AI sensing
        ///@
        ///</summary>
        ///<remarks>
        ///param NoiseMaker - is the actual actor which made the noise
        ///@param Loudness - is the relative loudness of the noise (0.0 to 1.0)
        ///@param NoiseLocation - is the position of the noise
        ///</remarks>
        public void MakeNoise(Actor NoiseMaker, float Loudness, Vector NoiseLocation)  => 
            PawnNoiseEmitterComponent_methods.MakeNoise_method.Invoke(ObjPointer, NoiseMaker, Loudness, NoiseLocation);
        public bool bAIPerceptionSystemCompatibilityMode {
            get {return Main.GetGetBoolPropertyByName(this, "bAIPerceptionSystemCompatibilityMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bAIPerceptionSystemCompatibilityMode", value); }
        }
        ///<summary>Most recent noise made by this pawn not at its own location</summary>
        public unsafe Vector LastRemoteNoisePosition {
            get {return PawnNoiseEmitterComponent_ptr->LastRemoteNoisePosition;}
            set {PawnNoiseEmitterComponent_ptr->LastRemoteNoisePosition = value;}
        }
        ///<summary>After this amount of time, new sound events will overwrite previous sounds even if they are not louder (allows old sounds to decay)</summary>
        public unsafe float NoiseLifetime {
            get {return PawnNoiseEmitterComponent_ptr->NoiseLifetime;}
            set {PawnNoiseEmitterComponent_ptr->NoiseLifetime = value;}
        }
        ///<summary>Most recent volume of noise made by this pawn not at its own location</summary>
        public unsafe float LastRemoteNoiseVolume {
            get {return PawnNoiseEmitterComponent_ptr->LastRemoteNoiseVolume;}
            set {PawnNoiseEmitterComponent_ptr->LastRemoteNoiseVolume = value;}
        }
        ///<summary>Time of last remote noise update</summary>
        public unsafe float LastRemoteNoiseTime {
            get {return PawnNoiseEmitterComponent_ptr->LastRemoteNoiseTime;}
            set {PawnNoiseEmitterComponent_ptr->LastRemoteNoiseTime = value;}
        }
        ///<summary>Most recent noise made by this pawn at its own location</summary>
        public unsafe float LastLocalNoiseVolume {
            get {return PawnNoiseEmitterComponent_ptr->LastLocalNoiseVolume;}
            set {PawnNoiseEmitterComponent_ptr->LastLocalNoiseVolume = value;}
        }
        ///<summary>Time of last local noise update</summary>
        public unsafe float LastLocalNoiseTime {
            get {return PawnNoiseEmitterComponent_ptr->LastLocalNoiseTime;}
            set {PawnNoiseEmitterComponent_ptr->LastLocalNoiseTime = value;}
        }
        static PawnNoiseEmitterComponent() {
            StaticClass = Main.GetClass("PawnNoiseEmitterComponent");
        }
        internal unsafe PawnNoiseEmitterComponent_fields* PawnNoiseEmitterComponent_ptr => (PawnNoiseEmitterComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnNoiseEmitterComponent(IntPtr p) => UObject.Make<PawnNoiseEmitterComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnNoiseEmitterComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnNoiseEmitterComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
