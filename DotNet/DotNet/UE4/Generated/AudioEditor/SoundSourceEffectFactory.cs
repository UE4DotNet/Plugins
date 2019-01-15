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
using UE4.Engine;

namespace UE4.AudioEditor {
    ///<summary>Sound Source Effect Factory</summary>
    public unsafe partial class SoundSourceEffectFactory : Factory  {
        ///<summary>The type of sound source effect preset that will be created</summary>
        public unsafe SubclassOf<SoundEffectSourcePreset> SoundEffectSourcepresetClass {
            get {return SoundSourceEffectFactory_ptr->SoundEffectSourcepresetClass;}
            set {SoundSourceEffectFactory_ptr->SoundEffectSourcepresetClass = value;}
        }
        static SoundSourceEffectFactory() {
            StaticClass = Main.GetClass("SoundSourceEffectFactory");
        }
        internal unsafe SoundSourceEffectFactory_fields* SoundSourceEffectFactory_ptr => (SoundSourceEffectFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSourceEffectFactory(IntPtr p) => UObject.Make<SoundSourceEffectFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSourceEffectFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSourceEffectFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
