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
    ///<summary>Sound node that takes a runtime parameter for the wave to play</summary>
    public unsafe partial class SoundNodeWaveParam : SoundNode  {
        ///<summary>The name of the wave parameter to use to look up the SoundWave we should play</summary>
        public unsafe Name WaveParameterName {
            get {return SoundNodeWaveParam_ptr->WaveParameterName;}
            set {SoundNodeWaveParam_ptr->WaveParameterName = value;}
        }
        static SoundNodeWaveParam() {
            StaticClass = Main.GetClass("SoundNodeWaveParam");
        }
        internal unsafe SoundNodeWaveParam_fields* SoundNodeWaveParam_ptr => (SoundNodeWaveParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeWaveParam(IntPtr p) => UObject.Make<SoundNodeWaveParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeWaveParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeWaveParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
