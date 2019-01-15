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
    ///<summary>Functional Test</summary>
    public unsafe partial class FunctionalTest : Actor  {
        //TODO: class_event: event with array parameter DebugGatherRelevantActors

        ///<summary>On Additional Test Finished Message Request</summary>
        public event OnAdditionalTestFinishedMessageRequest_delegate OnAdditionalTestFinishedMessageRequest;
        public delegate string OnAdditionalTestFinishedMessageRequest_delegate(EFunctionalTestResult TestResult, string ReturnValue);
        internal string on_OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult, string ReturnValue) =>
            OnAdditionalTestFinishedMessageRequest != null ? OnAdditionalTestFinishedMessageRequest(TestResult, ReturnValue) : ReturnValue;


        ///<summary>retrieves information whether test wants to have another run just after finishing</summary>
        public event OnWantsReRunCheck_delegate OnWantsReRunCheck;
        public delegate bool OnWantsReRunCheck_delegate(bool ReturnValue);
        internal bool on_OnWantsReRunCheck(bool ReturnValue) =>
            OnWantsReRunCheck != null ? OnWantsReRunCheck(ReturnValue) : ReturnValue;


        ///<summary>Prepare Test is fired once the test starts up, before the test IsReady() and thus before Start Test is called.</summary>
        ///<remarks>
        ///So if there's some initial conditions or setup that you might need for your IsReady() check, you might want
        ///to do that here.
        ///</remarks>
        public event ReceivePrepareTest_delegate ReceivePrepareTest;
        public delegate void ReceivePrepareTest_delegate();
        internal void on_ReceivePrepareTest() =>
            ReceivePrepareTest?.Invoke();


        ///<summary>Called once the IsReady() check for the test returns true.</summary>
        ///<remarks>
        ///After that happens the test has Officially started,
        ///and it will begin receiving Ticks in the blueprint.
        ///</remarks>
        public event ReceiveStartTest_delegate ReceiveStartTest;
        public delegate void ReceiveStartTest_delegate();
        internal void on_ReceiveStartTest() =>
            ReceiveStartTest?.Invoke();


        ///<summary>IsReady() is called once per frame after a test is run, until it returns true.</summary>
        ///<remarks>
        ///You should use this function to
        ///delay Start being called on the test until preconditions are met.
        ///</remarks>
        public event IsReady_delegate IsReady;
        public delegate bool IsReady_delegate(bool ReturnValue);
        internal bool on_IsReady(bool ReturnValue) =>
            IsReady != null ? IsReady(ReturnValue) : ReturnValue;


        ///<summary>Add Error</summary>
        public void AddError(string Message)  => 
            FunctionalTest_methods.AddError_method.Invoke(ObjPointer, Message);

        ///<summary>Causes the test to be rerun for a specific named reason.</summary>
        public void AddRerun(Name Reason)  => 
            FunctionalTest_methods.AddRerun_method.Invoke(ObjPointer, Reason);

        ///<summary>Add Warning</summary>
        public void AddWarning(string Message)  => 
            FunctionalTest_methods.AddWarning_method.Invoke(ObjPointer, Message);

        ///<summary>
        ///Assert that two bools are equal
        ///@
        ///</summary>
        ///<remarks>param What   A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')</remarks>
        public bool AssertEqual_Bool(bool Actual, bool Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Bool_method.Invoke(ObjPointer, Actual, Expected, What, ContextObject);

        ///<summary>Assert that two floats are equal within tolerance between two floats.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} within Tolerance for context '')
        ///</remarks>
        public bool AssertEqual_Float(float Actual, float Expected, string What, float Tolerance, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Float_method.Invoke(ObjPointer, Actual, Expected, What, Tolerance, ContextObject);

        ///<summary>
        ///Assert that two ints are equal
        ///@
        ///</summary>
        ///<remarks>param What   A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')</remarks>
        public bool AssertEqual_Int(int Actual, int Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Int_method.Invoke(ObjPointer, Actual, Expected, What, ContextObject);

        ///<summary>
        ///Assert that two FNames are equal
        ///@
        ///</summary>
        ///<remarks>param What   A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')</remarks>
        public bool AssertEqual_Name(Name Actual, Name Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Name_method.Invoke(ObjPointer, Actual, Expected, What, ContextObject);

        ///<summary>Assert that the component angles of two rotators are all equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertEqual_Rotator(Rotator Actual, Rotator Expected, string What, float Tolerance, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Rotator_method.Invoke(ObjPointer, Actual, Expected, What, Tolerance, ContextObject);

        ///<summary>Assert that two Strings are equal.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertEqual_String(string Actual, string Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_String_method.Invoke(ObjPointer, Actual, Expected, What, ContextObject);

        ///<summary>Assert that two TraceQueryResults are equal.</summary>
        ///<remarks>
        ///@param What   A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertEqual_TraceQueryResults(TraceQueryTestResults Actual, TraceQueryTestResults Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_TraceQueryResults_method.Invoke(ObjPointer, Actual, Expected, What, ContextObject);

        ///<summary>Assert that two transforms are (components memberwise - translation, rotation, scale) equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertEqual_Transform(Transform Actual, Transform Expected, string What, float Tolerance, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Transform_method.Invoke(ObjPointer, Actual, Expected, What, Tolerance, ContextObject);

        ///<summary>Assert that two vectors are (memberwise) equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertEqual_Vector(Vector Actual, Vector Expected, string What, float Tolerance, UObject ContextObject)  => 
            FunctionalTest_methods.AssertEqual_Vector_method.Invoke(ObjPointer, Actual, Expected, What, Tolerance, ContextObject);

        ///<summary>Assert that a boolean value is false.</summary>
        ///<remarks>
        ///@param Message       The message to display if the assert fails ("Assertion Failed: 'Message' for context ''")
        ///</remarks>
        public bool AssertFalse(bool Condition, string Message, UObject ContextObject)  => 
            FunctionalTest_methods.AssertFalse_method.Invoke(ObjPointer, Condition, Message, ContextObject);

        ///<summary>
        ///Assert that a UObject is valid
        ///@
        ///</summary>
        ///<remarks>param Message       The message to display if the object is invalid ("Invalid object: 'Message' for context ''")</remarks>
        public bool AssertIsValid(UObject UObject, string Message, UObject ContextObject)  => 
            FunctionalTest_methods.AssertIsValid_method.Invoke(ObjPointer, UObject, Message, ContextObject);

        ///<summary>Assert that the component angles of two rotators are all not equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertNotEqual_Rotator(Rotator Actual, Rotator NotExpected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertNotEqual_Rotator_method.Invoke(ObjPointer, Actual, NotExpected, What, ContextObject);

        ///<summary>Assert that two Strings are not equal.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertNotEqual_String(string Actual, string NotExpected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertNotEqual_String_method.Invoke(ObjPointer, Actual, NotExpected, What, ContextObject);

        ///<summary>Assert that two transforms are (components memberwise - translation, rotation, scale) not equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertNotEqual_Transform(Transform Actual, Transform NotExpected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertNotEqual_Transform_method.Invoke(ObjPointer, Actual, NotExpected, What, ContextObject);

        ///<summary>Assert that two vectors are (memberwise) not equal within a small tolerance.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
        ///</remarks>
        public bool AssertNotEqual_Vector(Vector Actual, Vector NotExpected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertNotEqual_Vector_method.Invoke(ObjPointer, Actual, NotExpected, What, ContextObject);

        ///<summary>Assert that a boolean value is true.</summary>
        ///<remarks>
        ///@param Message       The message to display if the assert fails ("Assertion Failed: 'Message' for context ''")
        ///</remarks>
        public bool AssertTrue(bool Condition, string Message, UObject ContextObject)  => 
            FunctionalTest_methods.AssertTrue_method.Invoke(ObjPointer, Condition, Message, ContextObject);

        ///<summary>Assert on a relationship between two DateTimes.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
        ///</remarks>
        public bool AssertValue_DateTime(FDateTime Actual, EComparisonMethod ShouldBe, FDateTime Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertValue_DateTime_method.Invoke(ObjPointer, Actual, ShouldBe, Expected, What, ContextObject);

        ///<summary>Assert on a relationship between two floats.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
        ///</remarks>
        public bool AssertValue_Float(float Actual, EComparisonMethod ShouldBe, float Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertValue_Float_method.Invoke(ObjPointer, Actual, ShouldBe, Expected, What, ContextObject);

        ///<summary>Assert on a relationship between two integers.</summary>
        ///<remarks>
        ///@param What  A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
        ///</remarks>
        public bool AssertValue_Int(int Actual, EComparisonMethod ShouldBe, int Expected, string What, UObject ContextObject)  => 
            FunctionalTest_methods.AssertValue_Int_method.Invoke(ObjPointer, Actual, ShouldBe, Expected, What, ContextObject);

        ///<summary>Finish Test</summary>
        public void FinishTest(EFunctionalTestResult TestResult, string Message)  => 
            FunctionalTest_methods.FinishTest_method.Invoke(ObjPointer, TestResult, Message);

        ///<summary>Returns the current re-run reason if we're in a named re-run.</summary>
        public Name GetCurrentRerunReason()  => 
            FunctionalTest_methods.GetCurrentRerunReason_method.Invoke(ObjPointer);

        ///<summary>Is Enabled</summary>
        public bool IsEnabled()  => 
            FunctionalTest_methods.IsEnabled_method.Invoke(ObjPointer);

        ///<summary>AActor interface end</summary>
        public bool IsRunning()  => 
            FunctionalTest_methods.IsRunning_method.Invoke(ObjPointer);

        ///<summary>Log Message</summary>
        public void LogMessage(string Message)  => 
            FunctionalTest_methods.LogMessage_method.Invoke(ObjPointer, Message);

        ///<summary>ACtors registered this way will be automatically destroyed (by limiting their lifespan)</summary>
        ///<remarks>on test finish</remarks>
        public void RegisterAutoDestroyActor(Actor ActorToAutoDestroy)  => 
            FunctionalTest_methods.RegisterAutoDestroyActor_method.Invoke(ObjPointer, ActorToAutoDestroy);

        ///<summary>Set Time Limit</summary>
        public void SetTimeLimit(float NewTimeLimit, EFunctionalTestResult ResultWhenTimeRunsOut)  => 
            FunctionalTest_methods.SetTimeLimit_method.Invoke(ObjPointer, NewTimeLimit, ResultWhenTimeRunsOut);
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return FunctionalTest_ptr->SpriteComponent;}
            set {FunctionalTest_ptr->SpriteComponent = value;}
        }
        public bool bIsEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEnabled"); }
        }
        public bool bWarningsAsErrors {
            get {return Main.GetGetBoolPropertyByName(this, "bWarningsAsErrors"); }
        }
         //TODO: string FString Author
         //TODO: string FString Description
        ///<summary>Allows you to specify another actor to view the test from.</summary>
        ///<remarks>
        ///Usually this is a camera you place
        ///in the map to observe the test.  Not useful when running on a build farm, but provides a handy
        ///way to observe the test from a different location than you place the functional test actor.
        ///</remarks>
        public unsafe Actor ObservationPoint {
            get {return FunctionalTest_ptr->ObservationPoint;}
            set {FunctionalTest_ptr->ObservationPoint = value;}
        }
        ///<summary>A random number stream that you can use during testing.</summary>
        ///<remarks>
        ///This number stream will be consistent
        ///every time the test is run.
        ///</remarks>
        public unsafe RandomStream RandomNumbersStream {
            get {return FunctionalTest_ptr->RandomNumbersStream;}
            set {FunctionalTest_ptr->RandomNumbersStream = value;}
        }
         //TODO: enum EFunctionalTestResult Result
        ///<summary>The Test's time limit for preparation, this is the time it has to return true when checking IsReady(). '0' means no limit.</summary>
        public unsafe float PreparationTimeLimit {
            get {return FunctionalTest_ptr->PreparationTimeLimit;}
        }
        ///<summary>Test's time limit. '0' means no limit</summary>
        public unsafe float TimeLimit {
            get {return FunctionalTest_ptr->TimeLimit;}
        }
         //TODO: text FText TimesUpMessage
         //TODO: enum EFunctionalTestResult TimesUpResult
         //TODO: multicast delegate FFunctionalTestEventSignature OnTestPrepare
         //TODO: multicast delegate FFunctionalTestEventSignature OnTestStart
         //TODO: multicast delegate FFunctionalTestEventSignature OnTestFinished
        ///<summary>Auto Destroy Actors</summary>
        public ObjectArrayField<Actor> AutoDestroyActors{ get {
            if(AutoDestroyActors_store == null) AutoDestroyActors_store = new ObjectArrayField<Actor> (&FunctionalTest_ptr->AutoDestroyActors);
            return AutoDestroyActors_store;
        } }
        private ObjectArrayField<Actor> AutoDestroyActors_store;

        ///<summary>Render Comp</summary>
        public unsafe FuncTestRenderingComponent RenderComp {
            get {return FunctionalTest_ptr->RenderComp;}
            set {FunctionalTest_ptr->RenderComp = value;}
        }
        ///<summary>Test Name</summary>
        public unsafe TextRenderComponent TestName {
            get {return FunctionalTest_ptr->TestName;}
            set {FunctionalTest_ptr->TestName = value;}
        }
        public bool bIsRunning {
            get {return Main.GetGetBoolPropertyByName(this, "bIsRunning"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsRunning", value); }
        }
        ///<summary>Total Time</summary>
        public unsafe float TotalTime {
            get {return FunctionalTest_ptr->TotalTime;}
        }
        static FunctionalTest() {
            StaticClass = Main.GetClass("FunctionalTest");
            //TODO: call_event_setup: event with array parameter: DebugGatherRelevantActors
            FunctionalTest_events.OnAdditionalTestFinishedMessageRequest_event.Setup();
            FunctionalTest_events.OnWantsReRunCheck_event.Setup();
            FunctionalTest_events.ReceivePrepareTest_event.Setup();
            FunctionalTest_events.ReceiveStartTest_event.Setup();
            FunctionalTest_events.IsReady_event.Setup();
        }
        internal unsafe FunctionalTest_fields* FunctionalTest_ptr => (FunctionalTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FunctionalTest(IntPtr p) => UObject.Make<FunctionalTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FunctionalTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FunctionalTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
