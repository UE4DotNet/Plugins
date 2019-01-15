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


namespace UE4.GameplayTasks.Native {
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct GameplayTask_fields {
        [FieldOffset(64)] public Name InstanceName;
        [FieldOffset(78)] byte ResourceOverlapPolicy; //TODO: enum ETaskResourceOverlapPolicy ResourceOverlapPolicy
        [FieldOffset(112)]  public IntPtr  ChildTask;
    }
    internal unsafe struct GameplayTask_methods {
        internal struct EndTask_method {
            static internal IntPtr EndTask_ptr;
            static EndTask_method() {
                EndTask_ptr = Main.GetMethodUFunction(GameplayTask.StaticClass, "EndTask");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndTask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReadyForActivation_method {
            static internal IntPtr ReadyForActivation_ptr;
            static ReadyForActivation_method() {
                ReadyForActivation_ptr = Main.GetMethodUFunction(GameplayTask.StaticClass, "ReadyForActivation");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReadyForActivation_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GameplayTask_events {
    }
}
