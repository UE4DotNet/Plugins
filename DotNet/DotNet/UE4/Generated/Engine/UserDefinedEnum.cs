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
    ///<summary>An Enumeration is a list of named values.</summary>
    public unsafe partial class UserDefinedEnum : UEnum  {
         //TODO: numeric uint32 UniqueNameIndex
         //TODO: text FText EnumDescription
         //TODO: map TMap DisplayNameMap
        static UserDefinedEnum() {
            StaticClass = Main.GetClass("UserDefinedEnum");
        }
        internal unsafe UserDefinedEnum_fields* UserDefinedEnum_ptr => (UserDefinedEnum_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserDefinedEnum(IntPtr p) => UObject.Make<UserDefinedEnum>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserDefinedEnum DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserDefinedEnum New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
