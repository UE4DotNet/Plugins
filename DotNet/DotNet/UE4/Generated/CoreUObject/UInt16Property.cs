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
    ///<summary>UInt 16Property</summary>
    public unsafe partial class UInt16Property : NumericProperty  {
        static UInt16Property() {
            StaticClass = Main.GetClass("UInt16Property");
        }
        internal unsafe UInt16Property_fields* UInt16Property_ptr => (UInt16Property_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UInt16Property(IntPtr p) => UObject.Make<UInt16Property>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UInt16Property DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UInt16Property New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
