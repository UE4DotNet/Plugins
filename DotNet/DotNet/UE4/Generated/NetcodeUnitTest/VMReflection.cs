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
using UE4.NetcodeUnitTest.Native;

namespace UE4.NetcodeUnitTest {
    ///<summary>Internal unit test for verifying the functionality of the UScript/BP VM reflection helper</summary>
    public unsafe partial class VMReflection : UnitTest  {
        static VMReflection() {
            StaticClass = Main.GetClass("VMReflection");
        }
        internal unsafe VMReflection_fields* VMReflection_ptr => (VMReflection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VMReflection(IntPtr p) => UObject.Make<VMReflection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VMReflection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VMReflection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
