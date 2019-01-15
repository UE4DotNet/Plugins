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
    ///<summary>Defines a random volume and pitch modification when a sound starts</summary>
    public unsafe partial class SoundNodeModulator : SoundNode  {
        ///<summary>The lower bound of pitch (1.0 is no change).</summary>
        public unsafe float PitchMin {
            get {return SoundNodeModulator_ptr->PitchMin;}
            set {SoundNodeModulator_ptr->PitchMin = value;}
        }
        ///<summary>The upper bound of pitch (1.0 is no change).</summary>
        public unsafe float PitchMax {
            get {return SoundNodeModulator_ptr->PitchMax;}
            set {SoundNodeModulator_ptr->PitchMax = value;}
        }
        ///<summary>The lower bound of volume (1.0 is no change).</summary>
        public unsafe float VolumeMin {
            get {return SoundNodeModulator_ptr->VolumeMin;}
            set {SoundNodeModulator_ptr->VolumeMin = value;}
        }
        ///<summary>The upper bound of volume (1.0 is no change).</summary>
        public unsafe float VolumeMax {
            get {return SoundNodeModulator_ptr->VolumeMax;}
            set {SoundNodeModulator_ptr->VolumeMax = value;}
        }
        static SoundNodeModulator() {
            StaticClass = Main.GetClass("SoundNodeModulator");
        }
        internal unsafe SoundNodeModulator_fields* SoundNodeModulator_ptr => (SoundNodeModulator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeModulator(IntPtr p) => UObject.Make<SoundNodeModulator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeModulator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeModulator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
