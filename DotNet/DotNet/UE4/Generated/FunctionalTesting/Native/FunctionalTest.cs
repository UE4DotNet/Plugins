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

using UE4.Engine;

namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=1312 )]
    internal unsafe struct FunctionalTest_fields {
        [FieldOffset(1008)]  public IntPtr  SpriteComponent;
        [FieldOffset(1016)] public bool bIsEnabled;
        [FieldOffset(1016)] public bool bWarningsAsErrors;
        [FieldOffset(1024)] byte Author; //TODO: string FString Author
        [FieldOffset(1040)] byte Description; //TODO: string FString Description
        [FieldOffset(1056)]  public IntPtr  ObservationPoint;
        [FieldOffset(1064)] public RandomStream RandomNumbersStream;
        [FieldOffset(1072)] byte Result; //TODO: enum EFunctionalTestResult Result
        [FieldOffset(1076)] public float PreparationTimeLimit;
        [FieldOffset(1080)] public float TimeLimit;
        [FieldOffset(1088)] byte TimesUpMessage; //TODO: text FText TimesUpMessage
        [FieldOffset(1112)] byte TimesUpResult; //TODO: enum EFunctionalTestResult TimesUpResult
        [FieldOffset(1120)] byte OnTestPrepare; //TODO: multicast delegate FFunctionalTestEventSignature OnTestPrepare
        [FieldOffset(1136)] byte OnTestStart; //TODO: multicast delegate FFunctionalTestEventSignature OnTestStart
        [FieldOffset(1152)] byte OnTestFinished; //TODO: multicast delegate FFunctionalTestEventSignature OnTestFinished
        [FieldOffset(1168)] public NativeArray AutoDestroyActors;
        [FieldOffset(1200)]  public IntPtr  RenderComp;
        [FieldOffset(1208)]  public IntPtr  TestName;
        [FieldOffset(1264)] public bool bIsRunning;
        [FieldOffset(1288)] public float TotalTime;
    }
    internal unsafe struct FunctionalTest_methods {
        internal struct AddError_method {
            static internal IntPtr AddError_ptr;
            static AddError_method() {
                AddError_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AddError");
            }

            internal static unsafe void Invoke(IntPtr obj, string Message) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Message.Length;
                *(int*)(b+IntPtr.Size+4+0) = Message.Length;
                Main.GetProcessEvent(obj, AddError_ptr, new IntPtr(p)); ;
                Message_handle.Free();
            }
        }
        internal struct AddRerun_method {
            static internal IntPtr AddRerun_ptr;
            static AddRerun_method() {
                AddRerun_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AddRerun");
            }

            internal static unsafe void Invoke(IntPtr obj, Name Reason) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Reason;
                Main.GetProcessEvent(obj, AddRerun_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddWarning_method {
            static internal IntPtr AddWarning_ptr;
            static AddWarning_method() {
                AddWarning_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AddWarning");
            }

            internal static unsafe void Invoke(IntPtr obj, string Message) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Message.Length;
                *(int*)(b+IntPtr.Size+4+0) = Message.Length;
                Main.GetProcessEvent(obj, AddWarning_ptr, new IntPtr(p)); ;
                Message_handle.Free();
            }
        }
        internal struct AssertEqual_Bool_method {
            static internal IntPtr AssertEqual_Bool_ptr;
            static AssertEqual_Bool_method() {
                AssertEqual_Bool_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Bool");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool Actual, bool Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Actual;
                *((bool*)(b+1)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = What.Length;
                *(int*)(b+IntPtr.Size+4+8) = What.Length;
                *((IntPtr*)(b+24)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Bool_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct AssertEqual_Float_method {
            static internal IntPtr AssertEqual_Float_ptr;
            static AssertEqual_Float_method() {
                AssertEqual_Float_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Float");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Actual, float Expected, string What, float Tolerance, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Actual;
                *((float*)(b+4)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = What.Length;
                *(int*)(b+IntPtr.Size+4+8) = What.Length;
                *((float*)(b+24)) = Tolerance;
                *((IntPtr*)(b+32)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Float_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+40));
            }
        }
        internal struct AssertEqual_Int_method {
            static internal IntPtr AssertEqual_Int_ptr;
            static AssertEqual_Int_method() {
                AssertEqual_Int_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Int");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Actual, int Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Actual;
                *((int*)(b+4)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = What.Length;
                *(int*)(b+IntPtr.Size+4+8) = What.Length;
                *((IntPtr*)(b+24)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Int_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct AssertEqual_Name_method {
            static internal IntPtr AssertEqual_Name_ptr;
            static AssertEqual_Name_method() {
                AssertEqual_Name_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Name");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name Actual, Name Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Actual;
                *((Name*)(b+12)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((IntPtr*)(b+40)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Name_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct AssertEqual_Rotator_method {
            static internal IntPtr AssertEqual_Rotator_ptr;
            static AssertEqual_Rotator_method() {
                AssertEqual_Rotator_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Rotator");
            }

            internal static unsafe bool Invoke(IntPtr obj, Rotator Actual, Rotator Expected, string What, float Tolerance, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Actual;
                *((Rotator*)(b+12)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((float*)(b+40)) = Tolerance;
                *((IntPtr*)(b+48)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Rotator_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+56));
            }
        }
        internal struct AssertEqual_String_method {
            static internal IntPtr AssertEqual_String_ptr;
            static AssertEqual_String_method() {
                AssertEqual_String_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_String");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Actual, string Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Actual_handle = GCHandle.Alloc(Actual, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Actual_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Actual.Length;
                *(int*)(b+IntPtr.Size+4+0) = Actual.Length;
                var Expected_handle = GCHandle.Alloc(Expected, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Expected_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Expected.Length;
                *(int*)(b+IntPtr.Size+4+16) = Expected.Length;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = What.Length;
                *(int*)(b+IntPtr.Size+4+32) = What.Length;
                *((IntPtr*)(b+48)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_String_ptr, new IntPtr(p)); ;
                Actual_handle.Free();
                Expected_handle.Free();
                What_handle.Free();
                return *((bool*)(b+56));
            }
        }
        internal struct AssertEqual_TraceQueryResults_method {
            static internal IntPtr AssertEqual_TraceQueryResults_ptr;
            static AssertEqual_TraceQueryResults_method() {
                AssertEqual_TraceQueryResults_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_TraceQueryResults");
            }

            internal static unsafe bool Invoke(IntPtr obj, TraceQueryTestResults Actual, TraceQueryTestResults Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actual;
                *((IntPtr*)(b+8)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = What.Length;
                *(int*)(b+IntPtr.Size+4+16) = What.Length;
                *((IntPtr*)(b+32)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_TraceQueryResults_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+40));
            }
        }
        internal struct AssertEqual_Transform_method {
            static internal IntPtr AssertEqual_Transform_ptr;
            static AssertEqual_Transform_method() {
                AssertEqual_Transform_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Transform");
            }

            internal static unsafe bool Invoke(IntPtr obj, Transform Actual, Transform Expected, string What, float Tolerance, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Actual;
                *((Transform*)(b+48)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+96) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+96) = What.Length;
                *(int*)(b+IntPtr.Size+4+96) = What.Length;
                *((float*)(b+112)) = Tolerance;
                *((IntPtr*)(b+120)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Transform_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+128));
            }
        }
        internal struct AssertEqual_Vector_method {
            static internal IntPtr AssertEqual_Vector_ptr;
            static AssertEqual_Vector_method() {
                AssertEqual_Vector_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertEqual_Vector");
            }

            internal static unsafe bool Invoke(IntPtr obj, Vector Actual, Vector Expected, string What, float Tolerance, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Actual;
                *((Vector*)(b+12)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((float*)(b+40)) = Tolerance;
                *((IntPtr*)(b+48)) = ContextObject;
                Main.GetProcessEvent(obj, AssertEqual_Vector_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+56));
            }
        }
        internal struct AssertFalse_method {
            static internal IntPtr AssertFalse_ptr;
            static AssertFalse_method() {
                AssertFalse_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertFalse");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool Condition, string Message, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Condition;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Message.Length;
                *(int*)(b+IntPtr.Size+4+8) = Message.Length;
                *((IntPtr*)(b+24)) = ContextObject;
                Main.GetProcessEvent(obj, AssertFalse_ptr, new IntPtr(p)); ;
                Message_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct AssertIsValid_method {
            static internal IntPtr AssertIsValid_ptr;
            static AssertIsValid_method() {
                AssertIsValid_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertIsValid");
            }

            internal static unsafe bool Invoke(IntPtr obj, UObject UObject, string Message, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Message.Length;
                *(int*)(b+IntPtr.Size+4+8) = Message.Length;
                *((IntPtr*)(b+24)) = ContextObject;
                Main.GetProcessEvent(obj, AssertIsValid_ptr, new IntPtr(p)); ;
                Message_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct AssertNotEqual_Rotator_method {
            static internal IntPtr AssertNotEqual_Rotator_ptr;
            static AssertNotEqual_Rotator_method() {
                AssertNotEqual_Rotator_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertNotEqual_Rotator");
            }

            internal static unsafe bool Invoke(IntPtr obj, Rotator Actual, Rotator NotExpected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Actual;
                *((Rotator*)(b+12)) = NotExpected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((IntPtr*)(b+40)) = ContextObject;
                Main.GetProcessEvent(obj, AssertNotEqual_Rotator_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct AssertNotEqual_String_method {
            static internal IntPtr AssertNotEqual_String_ptr;
            static AssertNotEqual_String_method() {
                AssertNotEqual_String_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertNotEqual_String");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Actual, string NotExpected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Actual_handle = GCHandle.Alloc(Actual, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Actual_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Actual.Length;
                *(int*)(b+IntPtr.Size+4+0) = Actual.Length;
                var NotExpected_handle = GCHandle.Alloc(NotExpected, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = NotExpected_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = NotExpected.Length;
                *(int*)(b+IntPtr.Size+4+16) = NotExpected.Length;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = What.Length;
                *(int*)(b+IntPtr.Size+4+32) = What.Length;
                *((IntPtr*)(b+48)) = ContextObject;
                Main.GetProcessEvent(obj, AssertNotEqual_String_ptr, new IntPtr(p)); ;
                Actual_handle.Free();
                NotExpected_handle.Free();
                What_handle.Free();
                return *((bool*)(b+56));
            }
        }
        internal struct AssertNotEqual_Transform_method {
            static internal IntPtr AssertNotEqual_Transform_ptr;
            static AssertNotEqual_Transform_method() {
                AssertNotEqual_Transform_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertNotEqual_Transform");
            }

            internal static unsafe bool Invoke(IntPtr obj, Transform Actual, Transform NotExpected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Actual;
                *((Transform*)(b+48)) = NotExpected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+96) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+96) = What.Length;
                *(int*)(b+IntPtr.Size+4+96) = What.Length;
                *((IntPtr*)(b+112)) = ContextObject;
                Main.GetProcessEvent(obj, AssertNotEqual_Transform_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+120));
            }
        }
        internal struct AssertNotEqual_Vector_method {
            static internal IntPtr AssertNotEqual_Vector_ptr;
            static AssertNotEqual_Vector_method() {
                AssertNotEqual_Vector_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertNotEqual_Vector");
            }

            internal static unsafe bool Invoke(IntPtr obj, Vector Actual, Vector NotExpected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Actual;
                *((Vector*)(b+12)) = NotExpected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((IntPtr*)(b+40)) = ContextObject;
                Main.GetProcessEvent(obj, AssertNotEqual_Vector_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct AssertTrue_method {
            static internal IntPtr AssertTrue_ptr;
            static AssertTrue_method() {
                AssertTrue_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertTrue");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool Condition, string Message, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Condition;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Message.Length;
                *(int*)(b+IntPtr.Size+4+8) = Message.Length;
                *((IntPtr*)(b+24)) = ContextObject;
                Main.GetProcessEvent(obj, AssertTrue_ptr, new IntPtr(p)); ;
                Message_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct AssertValue_DateTime_method {
            static internal IntPtr AssertValue_DateTime_ptr;
            static AssertValue_DateTime_method() {
                AssertValue_DateTime_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertValue_DateTime");
            }

            internal static unsafe bool Invoke(IntPtr obj, FDateTime Actual, EComparisonMethod ShouldBe, FDateTime Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = Actual;
                *(b+8) = (byte)ShouldBe;
                *((FDateTime*)(b+16)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = What.Length;
                *(int*)(b+IntPtr.Size+4+24) = What.Length;
                *((IntPtr*)(b+40)) = ContextObject;
                Main.GetProcessEvent(obj, AssertValue_DateTime_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct AssertValue_Float_method {
            static internal IntPtr AssertValue_Float_ptr;
            static AssertValue_Float_method() {
                AssertValue_Float_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertValue_Float");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Actual, EComparisonMethod ShouldBe, float Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Actual;
                *(b+4) = (byte)ShouldBe;
                *((float*)(b+8)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = What.Length;
                *(int*)(b+IntPtr.Size+4+16) = What.Length;
                *((IntPtr*)(b+32)) = ContextObject;
                Main.GetProcessEvent(obj, AssertValue_Float_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+40));
            }
        }
        internal struct AssertValue_Int_method {
            static internal IntPtr AssertValue_Int_ptr;
            static AssertValue_Int_method() {
                AssertValue_Int_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "AssertValue_Int");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Actual, EComparisonMethod ShouldBe, int Expected, string What, UObject ContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Actual;
                *(b+4) = (byte)ShouldBe;
                *((int*)(b+8)) = Expected;
                var What_handle = GCHandle.Alloc(What, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = What_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = What.Length;
                *(int*)(b+IntPtr.Size+4+16) = What.Length;
                *((IntPtr*)(b+32)) = ContextObject;
                Main.GetProcessEvent(obj, AssertValue_Int_ptr, new IntPtr(p)); ;
                What_handle.Free();
                return *((bool*)(b+40));
            }
        }
        internal struct FinishTest_method {
            static internal IntPtr FinishTest_ptr;
            static FinishTest_method() {
                FinishTest_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "FinishTest");
            }

            internal static unsafe void Invoke(IntPtr obj, EFunctionalTestResult TestResult, string Message) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TestResult;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Message.Length;
                *(int*)(b+IntPtr.Size+4+8) = Message.Length;
                Main.GetProcessEvent(obj, FinishTest_ptr, new IntPtr(p)); ;
                Message_handle.Free();
            }
        }
        internal struct GetCurrentRerunReason_method {
            static internal IntPtr GetCurrentRerunReason_ptr;
            static GetCurrentRerunReason_method() {
                GetCurrentRerunReason_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "GetCurrentRerunReason");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentRerunReason_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct IsEnabled_method {
            static internal IntPtr IsEnabled_ptr;
            static IsEnabled_method() {
                IsEnabled_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "IsEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsRunning_method {
            static internal IntPtr IsRunning_ptr;
            static IsRunning_method() {
                IsRunning_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "IsRunning");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsRunning_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LogMessage_method {
            static internal IntPtr LogMessage_ptr;
            static LogMessage_method() {
                LogMessage_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "LogMessage");
            }

            internal static unsafe void Invoke(IntPtr obj, string Message) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Message_handle = GCHandle.Alloc(Message, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Message_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Message.Length;
                *(int*)(b+IntPtr.Size+4+0) = Message.Length;
                Main.GetProcessEvent(obj, LogMessage_ptr, new IntPtr(p)); ;
                Message_handle.Free();
            }
        }
        internal struct RegisterAutoDestroyActor_method {
            static internal IntPtr RegisterAutoDestroyActor_ptr;
            static RegisterAutoDestroyActor_method() {
                RegisterAutoDestroyActor_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "RegisterAutoDestroyActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor ActorToAutoDestroy) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ActorToAutoDestroy;
                Main.GetProcessEvent(obj, RegisterAutoDestroyActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTimeLimit_method {
            static internal IntPtr SetTimeLimit_ptr;
            static SetTimeLimit_method() {
                SetTimeLimit_ptr = Main.GetMethodUFunction(FunctionalTest.StaticClass, "SetTimeLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewTimeLimit, EFunctionalTestResult ResultWhenTimeRunsOut) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewTimeLimit;
                *(b+4) = (byte)ResultWhenTimeRunsOut;
                Main.GetProcessEvent(obj, SetTimeLimit_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct FunctionalTest_events {
        //TODO: event_native: event with array parameterDebugGatherRelevantActors
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct OnAdditionalTestFinishedMessageRequest_event {
            private static DelegateHolder<NativeFuncDelegate> OnAdditionalTestFinishedMessageRequest_link;
            private static unsafe void OnAdditionalTestFinishedMessageRequest_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<FunctionalTest>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnAdditionalTestFinishedMessageRequest(*(EFunctionalTestResult*)(b+0), FString.Get(b+8));
            }
            internal static void Setup() {
                OnAdditionalTestFinishedMessageRequest_link = new DelegateHolder<NativeFuncDelegate>(OnAdditionalTestFinishedMessageRequest_process_event);
                var uf = Main.GetUFunction("OnAdditionalTestFinishedMessageRequest");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnAdditionalTestFinishedMessageRequest_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct OnWantsReRunCheck_event {
            private static DelegateHolder<NativeFuncDelegate> OnWantsReRunCheck_link;
            private static unsafe void OnWantsReRunCheck_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<FunctionalTest>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnWantsReRunCheck(*(bool*)(b+0));
            }
            internal static void Setup() {
                OnWantsReRunCheck_link = new DelegateHolder<NativeFuncDelegate>(OnWantsReRunCheck_process_event);
                var uf = Main.GetUFunction("OnWantsReRunCheck");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnWantsReRunCheck_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceivePrepareTest_event {
            private static DelegateHolder<NativeFuncDelegate> ReceivePrepareTest_link;
            private static unsafe void ReceivePrepareTest_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<FunctionalTest>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceivePrepareTest();
            }
            internal static void Setup() {
                ReceivePrepareTest_link = new DelegateHolder<NativeFuncDelegate>(ReceivePrepareTest_process_event);
                var uf = Main.GetUFunction("ReceivePrepareTest");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceivePrepareTest_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveStartTest_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveStartTest_link;
            private static unsafe void ReceiveStartTest_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<FunctionalTest>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveStartTest();
            }
            internal static void Setup() {
                ReceiveStartTest_link = new DelegateHolder<NativeFuncDelegate>(ReceiveStartTest_process_event);
                var uf = Main.GetUFunction("ReceiveStartTest");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveStartTest_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct IsReady_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> IsReady_link;
            private static unsafe void IsReady_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<FunctionalTest>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_IsReady(*(bool*)result);
            }
            internal static void Setup() {
                IsReady_link = new DelegateHolder<NativeFuncDelegate>(IsReady_process_event);
                var uf = Main.GetUFunction("IsReady");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(IsReady_link.Delegate));
            }
        }
    }
}
