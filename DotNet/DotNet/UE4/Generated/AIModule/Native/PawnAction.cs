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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct PawnAction_fields {
        [FieldOffset(56)]  public IntPtr  ChildAction;
        [FieldOffset(64)]  public IntPtr  ParentAction;
        [FieldOffset(72)]  public IntPtr  OwnerComponent;
        [FieldOffset(80)]  public IntPtr  Instigator;
        [FieldOffset(88)]  public IntPtr  BrainComp;
        [FieldOffset(144)] public bool bAllowNewSameClassInstance;
        [FieldOffset(144)] public bool bReplaceActiveSameClassInstance;
        [FieldOffset(144)] public bool bShouldPauseMovement;
        [FieldOffset(144)] public bool bAlwaysNotifyOnFinished;
    }
    internal unsafe struct PawnAction_methods {
        internal struct CreateActionInstance_method {
            static internal IntPtr CreateActionInstance_ptr;
            static CreateActionInstance_method() {
                CreateActionInstance_ptr = Main.GetMethodUFunction(PawnAction.StaticClass, "CreateActionInstance");
            }

            internal static unsafe PawnAction Invoke(UObject WorldContextObject, SubclassOf<PawnAction> ActionClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ActionClass;
                Main.GetProcessEvent(PawnAction.DefaultObject, CreateActionInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct Finish_method {
            static internal IntPtr Finish_ptr;
            static Finish_method() {
                Finish_ptr = Main.GetMethodUFunction(PawnAction.StaticClass, "Finish");
            }

            internal static unsafe void Invoke(IntPtr obj, byte WithResult) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = WithResult;
                Main.GetProcessEvent(obj, Finish_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActionPriority_method {
            static internal IntPtr GetActionPriority_ptr;
            static GetActionPriority_method() {
                GetActionPriority_ptr = Main.GetMethodUFunction(PawnAction.StaticClass, "GetActionPriority");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActionPriority_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
    }
    internal unsafe struct PawnAction_events {
    }
}
