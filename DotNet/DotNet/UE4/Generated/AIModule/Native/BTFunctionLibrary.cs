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

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct BTFunctionLibrary_fields {
    }
    internal unsafe struct BTFunctionLibrary_methods {
        internal struct ClearBlackboardValue_method {
            static internal IntPtr ClearBlackboardValue_ptr;
            static ClearBlackboardValue_method() {
                ClearBlackboardValue_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "ClearBlackboardValue");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, ClearBlackboardValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearBlackboardValueAsVector_method {
            static internal IntPtr ClearBlackboardValueAsVector_ptr;
            static ClearBlackboardValueAsVector_method() {
                ClearBlackboardValueAsVector_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "ClearBlackboardValueAsVector");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, ClearBlackboardValueAsVector_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBlackboardValueAsActor_method {
            static internal IntPtr GetBlackboardValueAsActor_ptr;
            static GetBlackboardValueAsActor_method() {
                GetBlackboardValueAsActor_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsActor");
            }

            internal static unsafe Actor Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsBool_method {
            static internal IntPtr GetBlackboardValueAsBool_ptr;
            static GetBlackboardValueAsBool_method() {
                GetBlackboardValueAsBool_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsBool");
            }

            internal static unsafe bool Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsClass_method {
            static internal IntPtr GetBlackboardValueAsClass_ptr;
            static GetBlackboardValueAsClass_method() {
                GetBlackboardValueAsClass_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsEnum_method {
            static internal IntPtr GetBlackboardValueAsEnum_ptr;
            static GetBlackboardValueAsEnum_method() {
                GetBlackboardValueAsEnum_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsEnum");
            }

            internal static unsafe byte Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsEnum_ptr, new IntPtr(p)); ;
                return *(b+56);
            }
        }
        internal struct GetBlackboardValueAsFloat_method {
            static internal IntPtr GetBlackboardValueAsFloat_ptr;
            static GetBlackboardValueAsFloat_method() {
                GetBlackboardValueAsFloat_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsFloat");
            }

            internal static unsafe float Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsInt_method {
            static internal IntPtr GetBlackboardValueAsInt_ptr;
            static GetBlackboardValueAsInt_method() {
                GetBlackboardValueAsInt_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsInt");
            }

            internal static unsafe int Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsName_method {
            static internal IntPtr GetBlackboardValueAsName_ptr;
            static GetBlackboardValueAsName_method() {
                GetBlackboardValueAsName_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsName");
            }

            internal static unsafe Name Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsObject_method {
            static internal IntPtr GetBlackboardValueAsObject_ptr;
            static GetBlackboardValueAsObject_method() {
                GetBlackboardValueAsObject_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsObject");
            }

            internal static unsafe UObject Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsRotator_method {
            static internal IntPtr GetBlackboardValueAsRotator_ptr;
            static GetBlackboardValueAsRotator_method() {
                GetBlackboardValueAsRotator_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsRotator");
            }

            internal static unsafe Rotator Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+56));
            }
        }
        internal struct GetBlackboardValueAsString_method {
            static internal IntPtr GetBlackboardValueAsString_ptr;
            static GetBlackboardValueAsString_method() {
                GetBlackboardValueAsString_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsString");
            }

            internal static unsafe string Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsString_ptr, new IntPtr(p)); ;
                return FString.Get(b+56);
            }
        }
        internal struct GetBlackboardValueAsVector_method {
            static internal IntPtr GetBlackboardValueAsVector_ptr;
            static GetBlackboardValueAsVector_method() {
                GetBlackboardValueAsVector_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetBlackboardValueAsVector");
            }

            internal static unsafe Vector Invoke(BTNode NodeOwner, BlackboardKeySelector Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetBlackboardValueAsVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+56));
            }
        }
        internal struct GetOwnerComponent_method {
            static internal IntPtr GetOwnerComponent_ptr;
            static GetOwnerComponent_method() {
                GetOwnerComponent_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetOwnerComponent");
            }

            internal static unsafe BehaviorTreeComponent Invoke(BTNode NodeOwner) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetOwnerComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetOwnersBlackboard_method {
            static internal IntPtr GetOwnersBlackboard_ptr;
            static GetOwnersBlackboard_method() {
                GetOwnersBlackboard_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "GetOwnersBlackboard");
            }

            internal static unsafe BlackboardComponent Invoke(BTNode NodeOwner) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, GetOwnersBlackboard_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetBlackboardValueAsBool_method {
            static internal IntPtr SetBlackboardValueAsBool_ptr;
            static SetBlackboardValueAsBool_method() {
                SetBlackboardValueAsBool_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsBool");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, bool Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((bool*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsBool_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsClass_method {
            static internal IntPtr SetBlackboardValueAsClass_ptr;
            static SetBlackboardValueAsClass_method() {
                SetBlackboardValueAsClass_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsClass");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, SubclassOf<UObject> Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((IntPtr*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsClass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsEnum_method {
            static internal IntPtr SetBlackboardValueAsEnum_ptr;
            static SetBlackboardValueAsEnum_method() {
                SetBlackboardValueAsEnum_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsEnum");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, byte Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *(b+56) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsEnum_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsFloat_method {
            static internal IntPtr SetBlackboardValueAsFloat_ptr;
            static SetBlackboardValueAsFloat_method() {
                SetBlackboardValueAsFloat_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsFloat");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, float Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((float*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsFloat_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsInt_method {
            static internal IntPtr SetBlackboardValueAsInt_ptr;
            static SetBlackboardValueAsInt_method() {
                SetBlackboardValueAsInt_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsInt");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, int Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((int*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsInt_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsName_method {
            static internal IntPtr SetBlackboardValueAsName_ptr;
            static SetBlackboardValueAsName_method() {
                SetBlackboardValueAsName_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsName");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, Name Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((Name*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsObject_method {
            static internal IntPtr SetBlackboardValueAsObject_ptr;
            static SetBlackboardValueAsObject_method() {
                SetBlackboardValueAsObject_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsObject");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, UObject Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((IntPtr*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsObject_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsRotator_method {
            static internal IntPtr SetBlackboardValueAsRotator_ptr;
            static SetBlackboardValueAsRotator_method() {
                SetBlackboardValueAsRotator_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsRotator");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, Rotator Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((Rotator*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsRotator_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlackboardValueAsString_method {
            static internal IntPtr SetBlackboardValueAsString_ptr;
            static SetBlackboardValueAsString_method() {
                SetBlackboardValueAsString_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsString");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, string Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                var Value_handle = GCHandle.Alloc(Value, GCHandleType.Pinned);
                *(IntPtr*)(b+56) = Value_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+56) = Value.Length;
                *(int*)(b+IntPtr.Size+4+56) = Value.Length;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsString_ptr, new IntPtr(p)); ;
                Value_handle.Free();
            }
        }
        internal struct SetBlackboardValueAsVector_method {
            static internal IntPtr SetBlackboardValueAsVector_ptr;
            static SetBlackboardValueAsVector_method() {
                SetBlackboardValueAsVector_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "SetBlackboardValueAsVector");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, BlackboardKeySelector Key, Vector Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((BlackboardKeySelector*)(b+8)) = Key;
                *((Vector*)(b+56)) = Value;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, SetBlackboardValueAsVector_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartUsingExternalEvent_method {
            static internal IntPtr StartUsingExternalEvent_ptr;
            static StartUsingExternalEvent_method() {
                StartUsingExternalEvent_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "StartUsingExternalEvent");
            }

            internal static unsafe void Invoke(BTNode NodeOwner, Actor OwningActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                *((IntPtr*)(b+8)) = OwningActor;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, StartUsingExternalEvent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopUsingExternalEvent_method {
            static internal IntPtr StopUsingExternalEvent_ptr;
            static StopUsingExternalEvent_method() {
                StopUsingExternalEvent_ptr = Main.GetMethodUFunction(BTFunctionLibrary.StaticClass, "StopUsingExternalEvent");
            }

            internal static unsafe void Invoke(BTNode NodeOwner) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NodeOwner;
                Main.GetProcessEvent(BTFunctionLibrary.DefaultObject, StopUsingExternalEvent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BTFunctionLibrary_events {
    }
}
