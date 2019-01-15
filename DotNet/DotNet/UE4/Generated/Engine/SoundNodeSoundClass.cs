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
    ///<summary>Remaps the SoundClass of SoundWaves underneath this</summary>
    public unsafe partial class SoundNodeSoundClass : SoundNode  {
        ///<summary>Sound Class Override</summary>
        public unsafe SoundClass SoundClassOverride {
            get {return SoundNodeSoundClass_ptr->SoundClassOverride;}
            set {SoundNodeSoundClass_ptr->SoundClassOverride = value;}
        }
        static SoundNodeSoundClass() {
            StaticClass = Main.GetClass("SoundNodeSoundClass");
        }
        internal unsafe SoundNodeSoundClass_fields* SoundNodeSoundClass_ptr => (SoundNodeSoundClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeSoundClass(IntPtr p) => UObject.Make<SoundNodeSoundClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeSoundClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeSoundClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
