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
    ///<summary>Defines how a sound oscillates</summary>
    public unsafe partial class SoundNodeOscillator : SoundNode  {
        public bool bModulateVolume {
            get {return Main.GetGetBoolPropertyByName(this, "bModulateVolume"); }
            set {Main.SetGetBoolPropertyByName(this, "bModulateVolume", value); }
        }
        public bool bModulatePitch {
            get {return Main.GetGetBoolPropertyByName(this, "bModulatePitch"); }
            set {Main.SetGetBoolPropertyByName(this, "bModulatePitch", value); }
        }
        ///<summary>An amplitude of 0.25 would oscillate between 0.75 and 1.25.</summary>
        public unsafe float AmplitudeMin {
            get {return SoundNodeOscillator_ptr->AmplitudeMin;}
            set {SoundNodeOscillator_ptr->AmplitudeMin = value;}
        }
        ///<summary>An amplitude of 0.25 would oscillate between 0.75 and 1.25.</summary>
        public unsafe float AmplitudeMax {
            get {return SoundNodeOscillator_ptr->AmplitudeMax;}
            set {SoundNodeOscillator_ptr->AmplitudeMax = value;}
        }
        ///<summary>A frequency of 20 would oscillate at 10Hz.</summary>
        public unsafe float FrequencyMin {
            get {return SoundNodeOscillator_ptr->FrequencyMin;}
            set {SoundNodeOscillator_ptr->FrequencyMin = value;}
        }
        ///<summary>A frequency of 20 would oscillate at 10Hz.</summary>
        public unsafe float FrequencyMax {
            get {return SoundNodeOscillator_ptr->FrequencyMax;}
            set {SoundNodeOscillator_ptr->FrequencyMax = value;}
        }
        ///<summary>Offset into the sine wave. Value modded by 2 * PI.</summary>
        public unsafe float OffsetMin {
            get {return SoundNodeOscillator_ptr->OffsetMin;}
            set {SoundNodeOscillator_ptr->OffsetMin = value;}
        }
        ///<summary>Offset into the sine wave. Value modded by 2 * PI.</summary>
        public unsafe float OffsetMax {
            get {return SoundNodeOscillator_ptr->OffsetMax;}
            set {SoundNodeOscillator_ptr->OffsetMax = value;}
        }
        ///<summary>A center of 0.5 would oscillate around 0.5.</summary>
        public unsafe float CenterMin {
            get {return SoundNodeOscillator_ptr->CenterMin;}
            set {SoundNodeOscillator_ptr->CenterMin = value;}
        }
        ///<summary>A center of 0.5 would oscillate around 0.5.</summary>
        public unsafe float CenterMax {
            get {return SoundNodeOscillator_ptr->CenterMax;}
            set {SoundNodeOscillator_ptr->CenterMax = value;}
        }
        static SoundNodeOscillator() {
            StaticClass = Main.GetClass("SoundNodeOscillator");
        }
        internal unsafe SoundNodeOscillator_fields* SoundNodeOscillator_ptr => (SoundNodeOscillator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeOscillator(IntPtr p) => UObject.Make<SoundNodeOscillator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeOscillator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeOscillator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
