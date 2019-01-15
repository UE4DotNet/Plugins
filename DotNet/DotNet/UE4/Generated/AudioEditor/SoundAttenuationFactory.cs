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
    ///<summary>Sound Attenuation Factory</summary>
    public unsafe partial class SoundAttenuationFactory : Factory  {
        static SoundAttenuationFactory() {
            StaticClass = Main.GetClass("SoundAttenuationFactory");
        }
        internal unsafe SoundAttenuationFactory_fields* SoundAttenuationFactory_ptr => (SoundAttenuationFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundAttenuationFactory(IntPtr p) => UObject.Make<SoundAttenuationFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundAttenuationFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundAttenuationFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
