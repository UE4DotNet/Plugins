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
    ///<summary>Sound Concurrency</summary>
    public unsafe partial class SoundConcurrency : UObject  {
        ///<summary>Concurrency</summary>
        public unsafe SoundConcurrencySettings Concurrency {
            get {return SoundConcurrency_ptr->Concurrency;}
        }
        static SoundConcurrency() {
            StaticClass = Main.GetClass("SoundConcurrency");
        }
        internal unsafe SoundConcurrency_fields* SoundConcurrency_ptr => (SoundConcurrency_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundConcurrency(IntPtr p) => UObject.Make<SoundConcurrency>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundConcurrency DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundConcurrency New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
