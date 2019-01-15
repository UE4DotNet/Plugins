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
    ///<summary>Sound Concurrency Factory</summary>
    public unsafe partial class SoundConcurrencyFactory : Factory  {
        static SoundConcurrencyFactory() {
            StaticClass = Main.GetClass("SoundConcurrencyFactory");
        }
        internal unsafe SoundConcurrencyFactory_fields* SoundConcurrencyFactory_ptr => (SoundConcurrencyFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundConcurrencyFactory(IntPtr p) => UObject.Make<SoundConcurrencyFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundConcurrencyFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundConcurrencyFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
