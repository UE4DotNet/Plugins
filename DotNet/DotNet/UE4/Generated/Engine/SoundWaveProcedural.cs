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
    ///<summary>Sound Wave Procedural</summary>
    public unsafe partial class SoundWaveProcedural : SoundWave  {
        static SoundWaveProcedural() {
            StaticClass = Main.GetClass("SoundWaveProcedural");
        }
        internal unsafe SoundWaveProcedural_fields* SoundWaveProcedural_ptr => (SoundWaveProcedural_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundWaveProcedural(IntPtr p) => UObject.Make<SoundWaveProcedural>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundWaveProcedural DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundWaveProcedural New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
