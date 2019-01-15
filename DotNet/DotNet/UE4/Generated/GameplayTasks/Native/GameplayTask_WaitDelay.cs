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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct GameplayTask_WaitDelay_fields {
        [FieldOffset(136)] byte OnFinish; //TODO: multicast delegate FTaskDelayDelegate OnFinish
    }
    internal unsafe struct GameplayTask_WaitDelay_methods {
        internal struct TaskWaitDelay_method {
            static internal IntPtr TaskWaitDelay_ptr;
            static TaskWaitDelay_method() {
                TaskWaitDelay_ptr = Main.GetMethodUFunction(GameplayTask_WaitDelay.StaticClass, "TaskWaitDelay");
            }

            internal static unsafe GameplayTask_WaitDelay Invoke(byte TaskOwner /*TODO: interface TScriptInterface */, float Time, byte Priority) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TaskOwner
                *((float*)(b+16)) = Time;
                *(b+20) = Priority;
                Main.GetProcessEvent(GameplayTask_WaitDelay.DefaultObject, TaskWaitDelay_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface TaskOwner
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct GameplayTask_WaitDelay_events {
    }
}
