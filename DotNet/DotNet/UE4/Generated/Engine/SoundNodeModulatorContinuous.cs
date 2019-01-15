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
    ///<summary>Allows named parameter based manipulation of pitch and volume</summary>
    public unsafe partial class SoundNodeModulatorContinuous : SoundNode  {
        ///<summary>Pitch Modulation Params</summary>
        public unsafe ModulatorContinuousParams PitchModulationParams {
            get {return SoundNodeModulatorContinuous_ptr->PitchModulationParams;}
            set {SoundNodeModulatorContinuous_ptr->PitchModulationParams = value;}
        }
        ///<summary>Volume Modulation Params</summary>
        public unsafe ModulatorContinuousParams VolumeModulationParams {
            get {return SoundNodeModulatorContinuous_ptr->VolumeModulationParams;}
            set {SoundNodeModulatorContinuous_ptr->VolumeModulationParams = value;}
        }
        static SoundNodeModulatorContinuous() {
            StaticClass = Main.GetClass("SoundNodeModulatorContinuous");
        }
        internal unsafe SoundNodeModulatorContinuous_fields* SoundNodeModulatorContinuous_ptr => (SoundNodeModulatorContinuous_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeModulatorContinuous(IntPtr p) => UObject.Make<SoundNodeModulatorContinuous>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeModulatorContinuous DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeModulatorContinuous New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
