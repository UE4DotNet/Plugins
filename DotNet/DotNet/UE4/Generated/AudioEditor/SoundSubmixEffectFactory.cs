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
    ///<summary>Sound Submix Effect Factory</summary>
    public unsafe partial class SoundSubmixEffectFactory : Factory  {
        ///<summary>The type of sound source effect preset that will be created</summary>
        public unsafe SubclassOf<SoundEffectSubmixPreset> SoundEffectSubmixPresetClass {
            get {return SoundSubmixEffectFactory_ptr->SoundEffectSubmixPresetClass;}
            set {SoundSubmixEffectFactory_ptr->SoundEffectSubmixPresetClass = value;}
        }
        static SoundSubmixEffectFactory() {
            StaticClass = Main.GetClass("SoundSubmixEffectFactory");
        }
        internal unsafe SoundSubmixEffectFactory_fields* SoundSubmixEffectFactory_ptr => (SoundSubmixEffectFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSubmixEffectFactory(IntPtr p) => UObject.Make<SoundSubmixEffectFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSubmixEffectFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSubmixEffectFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
