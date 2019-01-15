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
using UE4.CoreUObject.Native;

namespace UE4.CoreUObject {
    ///<summary>Linker Placeholder Class</summary>
    public unsafe partial class LinkerPlaceholderClass : Class  {
        static LinkerPlaceholderClass() {
            StaticClass = Main.GetClass("LinkerPlaceholderClass");
        }
        internal unsafe LinkerPlaceholderClass_fields* LinkerPlaceholderClass_ptr => (LinkerPlaceholderClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LinkerPlaceholderClass(IntPtr p) => UObject.Make<LinkerPlaceholderClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LinkerPlaceholderClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LinkerPlaceholderClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
