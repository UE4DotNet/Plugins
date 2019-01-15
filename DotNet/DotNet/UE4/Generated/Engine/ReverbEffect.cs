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
    ///<summary>Reverb Effect</summary>
    public unsafe partial class ReverbEffect : UObject  {
        ///<summary>Density - 0.0 < 1.0 < 1.0 - Coloration of the late reverb - lower value is more grainy</summary>
        public unsafe float Density {
            get {return ReverbEffect_ptr->Density;}
            set {ReverbEffect_ptr->Density = value;}
        }
        ///<summary>Diffusion - 0.0 < 1.0 < 1.0 - Echo density in the reverberation decay - lower is more grainy</summary>
        public unsafe float Diffusion {
            get {return ReverbEffect_ptr->Diffusion;}
            set {ReverbEffect_ptr->Diffusion = value;}
        }
        ///<summary>Reverb Gain - 0.0 < 0.32 < 1.0 - overall reverb gain - master volume control</summary>
        public unsafe float Gain {
            get {return ReverbEffect_ptr->Gain;}
            set {ReverbEffect_ptr->Gain = value;}
        }
        ///<summary>Reverb Gain High Frequency - 0.0 < 0.89 < 1.0 - attenuates the high frequency reflected sound</summary>
        public unsafe float GainHF {
            get {return ReverbEffect_ptr->GainHF;}
            set {ReverbEffect_ptr->GainHF = value;}
        }
        ///<summary>Decay Time - 0.1 < 1.49 < 20.0 Seconds - larger is more reverb</summary>
        public unsafe float DecayTime {
            get {return ReverbEffect_ptr->DecayTime;}
            set {ReverbEffect_ptr->DecayTime = value;}
        }
        ///<summary>Decay High Frequency Ratio - 0.1 < 0.83 < 2.0 - how much the quicker or slower the high frequencies decay relative to the lower frequencies.</summary>
        public unsafe float DecayHFRatio {
            get {return ReverbEffect_ptr->DecayHFRatio;}
            set {ReverbEffect_ptr->DecayHFRatio = value;}
        }
        ///<summary>Reflections Gain - 0.0 < 0.05 < 3.16 - controls the amount of initial reflections</summary>
        public unsafe float ReflectionsGain {
            get {return ReverbEffect_ptr->ReflectionsGain;}
            set {ReverbEffect_ptr->ReflectionsGain = value;}
        }
        ///<summary>Reflections Delay - 0.0 < 0.007 < 0.3 Seconds - the time between the listener receiving the direct path sound and the first reflection</summary>
        public unsafe float ReflectionsDelay {
            get {return ReverbEffect_ptr->ReflectionsDelay;}
            set {ReverbEffect_ptr->ReflectionsDelay = value;}
        }
        ///<summary>Late Reverb Gain - 0.0 < 1.26 < 10.0 - gain of the late reverb</summary>
        public unsafe float LateGain {
            get {return ReverbEffect_ptr->LateGain;}
            set {ReverbEffect_ptr->LateGain = value;}
        }
        ///<summary>Late Reverb Delay - 0.0 < 0.011 < 0.1 Seconds - time difference between late reverb and first reflections</summary>
        public unsafe float LateDelay {
            get {return ReverbEffect_ptr->LateDelay;}
            set {ReverbEffect_ptr->LateDelay = value;}
        }
        ///<summary>Air Absorption - 0.0 < 0.994 < 1.0 - lower value means more absorption</summary>
        public unsafe float AirAbsorptionGainHF {
            get {return ReverbEffect_ptr->AirAbsorptionGainHF;}
            set {ReverbEffect_ptr->AirAbsorptionGainHF = value;}
        }
        ///<summary>Room Rolloff - 0.0 < 0.0 < 10.0 - multiplies the attenuation due to distance</summary>
        public unsafe float RoomRolloffFactor {
            get {return ReverbEffect_ptr->RoomRolloffFactor;}
            set {ReverbEffect_ptr->RoomRolloffFactor = value;}
        }
        public bool bChanged {
            get {return Main.GetGetBoolPropertyByName(this, "bChanged"); }
            set {Main.SetGetBoolPropertyByName(this, "bChanged", value); }
        }
        static ReverbEffect() {
            StaticClass = Main.GetClass("ReverbEffect");
        }
        internal unsafe ReverbEffect_fields* ReverbEffect_ptr => (ReverbEffect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReverbEffect(IntPtr p) => UObject.Make<ReverbEffect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReverbEffect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReverbEffect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
