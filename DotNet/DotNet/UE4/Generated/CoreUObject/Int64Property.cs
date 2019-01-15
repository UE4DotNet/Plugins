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
    ///<summary>Int 64Property</summary>
    public unsafe partial class Int64Property : NumericProperty  {
        static Int64Property() {
            StaticClass = Main.GetClass("Int64Property");
        }
        internal unsafe Int64Property_fields* Int64Property_ptr => (Int64Property_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Int64Property(IntPtr p) => UObject.Make<Int64Property>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Int64Property DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Int64Property New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
