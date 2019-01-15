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
    ///<summary>Base class for all unit tests which launch child processes, whether they be UE4 child processes, or other arbitrary programs.</summary>
    ///<remarks>Handles management of child processes, memory usage tracking, log/stdout output gathering/printing, and crash detection.</remarks>
    public unsafe partial class ProcessUnitTest : UnitTest  {
        static ProcessUnitTest() {
            StaticClass = Main.GetClass("ProcessUnitTest");
        }
        internal unsafe ProcessUnitTest_fields* ProcessUnitTest_ptr => (ProcessUnitTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProcessUnitTest(IntPtr p) => UObject.Make<ProcessUnitTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProcessUnitTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProcessUnitTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
