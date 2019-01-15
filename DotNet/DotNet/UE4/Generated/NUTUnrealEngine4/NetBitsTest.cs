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
using UE4.NUTUnrealEngine4.Native;
using UE4.NetcodeUnitTest;

namespace UE4.NUTUnrealEngine4 {
    ///<summary>@todo JohnB</summary>
    public unsafe partial class NetBitsTest : UnitTest  {
        static NetBitsTest() {
            StaticClass = Main.GetClass("NetBitsTest");
        }
        internal unsafe NetBitsTest_fields* NetBitsTest_ptr => (NetBitsTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NetBitsTest(IntPtr p) => UObject.Make<NetBitsTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NetBitsTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NetBitsTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
