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
    ///<summary>Defines how concurrent sounds are mixed together</summary>
    public unsafe partial class SoundNodeMixer : SoundNode  {
         //TODO: array not UObject TArray InputVolume
        static SoundNodeMixer() {
            StaticClass = Main.GetClass("SoundNodeMixer");
        }
        internal unsafe SoundNodeMixer_fields* SoundNodeMixer_ptr => (SoundNodeMixer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeMixer(IntPtr p) => UObject.Make<SoundNodeMixer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeMixer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeMixer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
