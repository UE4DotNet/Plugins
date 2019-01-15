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
    ///<summary>
    ///Base class for the unit test framework event implementation
    ///(all engine/external-triggered events are wrapped, in order to hook logs triggered during their execution)
    ///</summary>
    ///<remarks>NOTE: All wrapped functions/events, begin with 'UT'</remarks>
    public unsafe partial class UnitTestBase : UObject  {
        static UnitTestBase() {
            StaticClass = Main.GetClass("UnitTestBase");
        }
        internal unsafe UnitTestBase_fields* UnitTestBase_ptr => (UnitTestBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestBase(IntPtr p) => UObject.Make<UnitTestBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
