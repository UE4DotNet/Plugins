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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=416 )]
    internal unsafe struct PawnMovementComponent_fields {
        [FieldOffset(408)]  public IntPtr  PawnOwner;
    }
    internal unsafe struct PawnMovementComponent_methods {
        internal struct AddInputVector_method {
            static internal IntPtr AddInputVector_ptr;
            static AddInputVector_method() {
                AddInputVector_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "AddInputVector");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector WorldVector, bool bForce) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldVector;
                *((bool*)(b+12)) = bForce;
                Main.GetProcessEvent(obj, AddInputVector_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ConsumeInputVector_method {
            static internal IntPtr ConsumeInputVector_ptr;
            static ConsumeInputVector_method() {
                ConsumeInputVector_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "ConsumeInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ConsumeInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetLastInputVector_method {
            static internal IntPtr GetLastInputVector_ptr;
            static GetLastInputVector_method() {
                GetLastInputVector_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "GetLastInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLastInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetPawnOwner_method {
            static internal IntPtr GetPawnOwner_ptr;
            static GetPawnOwner_method() {
                GetPawnOwner_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "GetPawnOwner");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPawnOwner_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetPendingInputVector_method {
            static internal IntPtr GetPendingInputVector_ptr;
            static GetPendingInputVector_method() {
                GetPendingInputVector_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "GetPendingInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPendingInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct IsMoveInputIgnored_method {
            static internal IntPtr IsMoveInputIgnored_ptr;
            static IsMoveInputIgnored_method() {
                IsMoveInputIgnored_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "IsMoveInputIgnored");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsMoveInputIgnored_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_GetInputVector_method {
            static internal IntPtr K2_GetInputVector_ptr;
            static K2_GetInputVector_method() {
                K2_GetInputVector_ptr = Main.GetMethodUFunction(PawnMovementComponent.StaticClass, "K2_GetInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
    }
    internal unsafe struct PawnMovementComponent_events {
    }
}
