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
using UE4.SlateCore.Native;

namespace UE4.SlateCore {
    ///<summary>HACK: We need a UClass here or UHT will complain.</summary>
    public unsafe partial class SlateTypes : UObject  {
        static SlateTypes() {
            StaticClass = Main.GetClass("SlateTypes");
        }
        internal unsafe SlateTypes_fields* SlateTypes_ptr => (SlateTypes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateTypes(IntPtr p) => UObject.Make<SlateTypes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateTypes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateTypes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
