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
    ///<summary>Manages centralized execution and tracking of unit tests, as well as handling console commands,</summary>
    ///<remarks>and some misc tasks like local log hooking</remarks>
    public unsafe partial class UnitTestManager : UObject  {
        public bool bCapUnitTestCount {
            get {return Main.GetGetBoolPropertyByName(this, "bCapUnitTestCount"); }
            set {Main.SetGetBoolPropertyByName(this, "bCapUnitTestCount", value); }
        }
        ///<summary>Specifies the maximum number of unit tests that can be run at any given time</summary>
        public unsafe byte MaxUnitTestCount {
            get {return UnitTestManager_ptr->MaxUnitTestCount;}
            set {UnitTestManager_ptr->MaxUnitTestCount = value;}
        }
        public bool bCapUnitTestMemory {
            get {return Main.GetGetBoolPropertyByName(this, "bCapUnitTestMemory"); }
            set {Main.SetGetBoolPropertyByName(this, "bCapUnitTestMemory", value); }
        }
        ///<summary>When total physical memory usage, as a percentage, reaches this limit, no new unit tests can be started</summary>
        public unsafe byte MaxMemoryPercent {
            get {return UnitTestManager_ptr->MaxMemoryPercent;}
            set {UnitTestManager_ptr->MaxMemoryPercent = value;}
        }
        ///<summary>As above, but when reaching this limit, recently started unit test(s) will be terminated/re-queued, to get back within limits</summary>
        public unsafe byte AutoCloseMemoryPercent {
            get {return UnitTestManager_ptr->AutoCloseMemoryPercent;}
            set {UnitTestManager_ptr->AutoCloseMemoryPercent = value;}
        }
        ///<summary>Limits the number of auto-aborts a particular unit test will allow, before it is no longer accepted for re-queueing</summary>
        public unsafe byte MaxAutoCloseCount {
            get {return UnitTestManager_ptr->MaxAutoCloseCount;}
            set {UnitTestManager_ptr->MaxAutoCloseCount = value;}
        }
         //TODO: numeric uint32 UnitTestSessionCount
        ///<summary>Holds a list of unit tests pending execution</summary>
        public ObjectArrayField<Class> PendingUnitTests{ get {
            if(PendingUnitTests_store == null) PendingUnitTests_store = new ObjectArrayField<Class> (&UnitTestManager_ptr->PendingUnitTests);
            return PendingUnitTests_store;
        } }
        private ObjectArrayField<Class> PendingUnitTests_store;

        ///<summary>Holds a list of currently active unit tests</summary>
        public ObjectArrayField<UnitTest> ActiveUnitTests{ get {
            if(ActiveUnitTests_store == null) ActiveUnitTests_store = new ObjectArrayField<UnitTest> (&UnitTestManager_ptr->ActiveUnitTests);
            return ActiveUnitTests_store;
        } }
        private ObjectArrayField<UnitTest> ActiveUnitTests_store;

        ///<summary>Unit tests which are finished, and are kept around until printing the final summary</summary>
        public ObjectArrayField<UnitTest> FinishedUnitTests{ get {
            if(FinishedUnitTests_store == null) FinishedUnitTests_store = new ObjectArrayField<UnitTest> (&UnitTestManager_ptr->FinishedUnitTests);
            return FinishedUnitTests_store;
        } }
        private ObjectArrayField<UnitTest> FinishedUnitTests_store;

        static UnitTestManager() {
            StaticClass = Main.GetClass("UnitTestManager");
        }
        internal unsafe UnitTestManager_fields* UnitTestManager_ptr => (UnitTestManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestManager(IntPtr p) => UObject.Make<UnitTestManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
