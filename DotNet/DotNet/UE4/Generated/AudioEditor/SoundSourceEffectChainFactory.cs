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
using UE4.AudioEditor.Native;
using UE4.UnrealEd;

namespace UE4.AudioEditor {
    ///<summary>Sound Source Effect Chain Factory</summary>
    public unsafe partial class SoundSourceEffectChainFactory : Factory  {
        static SoundSourceEffectChainFactory() {
            StaticClass = Main.GetClass("SoundSourceEffectChainFactory");
        }
        internal unsafe SoundSourceEffectChainFactory_fields* SoundSourceEffectChainFactory_ptr => (SoundSourceEffectChainFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSourceEffectChainFactory(IntPtr p) => UObject.Make<SoundSourceEffectChainFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSourceEffectChainFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSourceEffectChainFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
