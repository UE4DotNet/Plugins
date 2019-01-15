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
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct PawnActionsComponent_fields {
        [FieldOffset(256)]  public IntPtr  ControlledPawn;
        [FieldOffset(264)] public NativeArray ActionStacks;
        [FieldOffset(280)] public NativeArray ActionEvents;
        [FieldOffset(296)]  public IntPtr  CurrentAction;
    }
    internal unsafe struct PawnActionsComponent_methods {
        internal struct K2_AbortAction_method {
            static internal IntPtr K2_AbortAction_ptr;
            static K2_AbortAction_method() {
                K2_AbortAction_ptr = Main.GetMethodUFunction(PawnActionsComponent.StaticClass, "K2_AbortAction");
            }

            internal static unsafe byte Invoke(IntPtr obj, PawnAction ActionToAbort) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ActionToAbort;
                Main.GetProcessEvent(obj, K2_AbortAction_ptr, new IntPtr(p)); ;
                return *(b+8);
            }
        }
        internal struct K2_ForceAbortAction_method {
            static internal IntPtr K2_ForceAbortAction_ptr;
            static K2_ForceAbortAction_method() {
                K2_ForceAbortAction_ptr = Main.GetMethodUFunction(PawnActionsComponent.StaticClass, "K2_ForceAbortAction");
            }

            internal static unsafe byte Invoke(IntPtr obj, PawnAction ActionToAbort) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ActionToAbort;
                Main.GetProcessEvent(obj, K2_ForceAbortAction_ptr, new IntPtr(p)); ;
                return *(b+8);
            }
        }
        internal struct K2_PerformAction_method {
            static internal IntPtr K2_PerformAction_ptr;
            static K2_PerformAction_method() {
                K2_PerformAction_ptr = Main.GetMethodUFunction(PawnActionsComponent.StaticClass, "K2_PerformAction");
            }

            internal static unsafe bool Invoke(Pawn Pawn, PawnAction Action, byte Priority) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Pawn;
                *((IntPtr*)(b+8)) = Action;
                *(b+16) = Priority;
                Main.GetProcessEvent(PawnActionsComponent.DefaultObject, K2_PerformAction_ptr, new IntPtr(p)); ;
                return *((bool*)(b+17));
            }
        }
        internal struct K2_PushAction_method {
            static internal IntPtr K2_PushAction_ptr;
            static K2_PushAction_method() {
                K2_PushAction_ptr = Main.GetMethodUFunction(PawnActionsComponent.StaticClass, "K2_PushAction");
            }

            internal static unsafe bool Invoke(IntPtr obj, PawnAction NewAction, byte Priority, UObject Instigator) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewAction;
                *(b+8) = Priority;
                *((IntPtr*)(b+16)) = Instigator;
                Main.GetProcessEvent(obj, K2_PushAction_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
    }
    internal unsafe struct PawnActionsComponent_events {
    }
}
