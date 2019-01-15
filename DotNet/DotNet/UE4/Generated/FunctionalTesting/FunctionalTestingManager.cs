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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Functional Testing Manager</summary>
    public unsafe partial class FunctionalTestingManager : BlueprintFunctionLibrary  {

        ///<summary>Triggers in sequence all functional tests found on the level.</summary>
        ///<remarks>
        ///@return true if any tests have been triggered
        ///</remarks>
        public static bool RunAllFunctionalTests(UObject WorldContextObject, bool bNewLog, bool bRunLooped, string FailedTestsReproString)  => 
            FunctionalTestingManager_methods.RunAllFunctionalTests_method.Invoke(WorldContextObject, bNewLog, bRunLooped, FailedTestsReproString);
        ///<summary>Tests Left</summary>
        public ObjectArrayField<FunctionalTest> TestsLeft{ get {
            if(TestsLeft_store == null) TestsLeft_store = new ObjectArrayField<FunctionalTest> (&FunctionalTestingManager_ptr->TestsLeft);
            return TestsLeft_store;
        } }
        private ObjectArrayField<FunctionalTest> TestsLeft_store;

        ///<summary>All Tests</summary>
        public ObjectArrayField<FunctionalTest> AllTests{ get {
            if(AllTests_store == null) AllTests_store = new ObjectArrayField<FunctionalTest> (&FunctionalTestingManager_ptr->AllTests);
            return AllTests_store;
        } }
        private ObjectArrayField<FunctionalTest> AllTests_store;

         //TODO: multicast delegate FFunctionalTestEventSignature OnSetupTests
         //TODO: multicast delegate FFunctionalTestEventSignature OnTestsComplete
         //TODO: multicast delegate FFunctionalTestEventSignature OnTestsBegin
        static FunctionalTestingManager() {
            StaticClass = Main.GetClass("FunctionalTestingManager");
        }
        internal unsafe FunctionalTestingManager_fields* FunctionalTestingManager_ptr => (FunctionalTestingManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FunctionalTestingManager(IntPtr p) => UObject.Make<FunctionalTestingManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FunctionalTestingManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FunctionalTestingManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
