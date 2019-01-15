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
    ///<summary>Base class for all unit tests</summary>
    public unsafe partial class UnitTest : UnitTestBase  {
         //TODO: numeric uint64 PeakMemoryUsage
        ///<summary>The amount of time it takes to reach 'PeakMemoryUsage' (or within 90% of its value)</summary>
        public unsafe float TimeToPeakMem {
            get {return UnitTest_ptr->TimeToPeakMem;}
            set {UnitTest_ptr->TimeToPeakMem = value;}
        }
        ///<summary>The amount of time it took to execute the unit test the last time it was run</summary>
        public unsafe float LastExecutionTime {
            get {return UnitTest_ptr->LastExecutionTime;}
            set {UnitTest_ptr->LastExecutionTime = value;}
        }
        ///<summary>UnitTask's which must be run before different stages of the unit test can execute</summary>
        public ObjectArrayField<UnitTask> UnitTasks{ get {
            if(UnitTasks_store == null) UnitTasks_store = new ObjectArrayField<UnitTask> (&UnitTest_ptr->UnitTasks);
            return UnitTasks_store;
        } }
        private ObjectArrayField<UnitTask> UnitTasks_store;

         //TODO: enum EUnitTestVerification VerificationState
        static UnitTest() {
            StaticClass = Main.GetClass("UnitTest");
        }
        internal unsafe UnitTest_fields* UnitTest_ptr => (UnitTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTest(IntPtr p) => UObject.Make<UnitTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
