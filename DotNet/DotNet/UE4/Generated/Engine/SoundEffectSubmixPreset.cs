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
    ///<summary>This is here to make sure users don't mix up source and submix effects in the editor. Asset sorting, drag-n-drop, etc.</summary>
    public unsafe partial class SoundEffectSubmixPreset : SoundEffectPreset  {
        static SoundEffectSubmixPreset() {
            StaticClass = Main.GetClass("SoundEffectSubmixPreset");
        }
        internal unsafe SoundEffectSubmixPreset_fields* SoundEffectSubmixPreset_ptr => (SoundEffectSubmixPreset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundEffectSubmixPreset(IntPtr p) => UObject.Make<SoundEffectSubmixPreset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundEffectSubmixPreset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundEffectSubmixPreset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
