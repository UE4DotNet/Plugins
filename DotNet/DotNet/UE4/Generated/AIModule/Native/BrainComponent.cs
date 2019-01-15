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
    [StructLayout( LayoutKind.Explicit, Size=352 )]
    internal unsafe struct BrainComponent_fields {
        [FieldOffset(264)]  public IntPtr  BlackboardComp;
        [FieldOffset(272)]  public IntPtr  AIOwner;
    }
    internal unsafe struct BrainComponent_methods {
        internal struct IsPaused_method {
            static internal IntPtr IsPaused_ptr;
            static IsPaused_method() {
                IsPaused_ptr = Main.GetMethodUFunction(BrainComponent.StaticClass, "IsPaused");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsRunning_method {
            static internal IntPtr IsRunning_ptr;
            static IsRunning_method() {
                IsRunning_ptr = Main.GetMethodUFunction(BrainComponent.StaticClass, "IsRunning");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsRunning_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RestartLogic_method {
            static internal IntPtr RestartLogic_ptr;
            static RestartLogic_method() {
                RestartLogic_ptr = Main.GetMethodUFunction(BrainComponent.StaticClass, "RestartLogic");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RestartLogic_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopLogic_method {
            static internal IntPtr StopLogic_ptr;
            static StopLogic_method() {
                StopLogic_ptr = Main.GetMethodUFunction(BrainComponent.StaticClass, "StopLogic");
            }

            internal static unsafe void Invoke(IntPtr obj, string Reason) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Reason_handle = GCHandle.Alloc(Reason, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Reason_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Reason.Length;
                *(int*)(b+IntPtr.Size+4+0) = Reason.Length;
                Main.GetProcessEvent(obj, StopLogic_ptr, new IntPtr(p)); ;
                Reason_handle.Free();
            }
        }
    }
    internal unsafe struct BrainComponent_events {
    }
}
