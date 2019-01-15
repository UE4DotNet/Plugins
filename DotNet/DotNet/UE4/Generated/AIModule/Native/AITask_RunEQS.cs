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
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct AITask_RunEQS_fields {
    }
    internal unsafe struct AITask_RunEQS_methods {
        internal struct RunEQS_method {
            static internal IntPtr RunEQS_ptr;
            static RunEQS_method() {
                RunEQS_ptr = Main.GetMethodUFunction(AITask_RunEQS.StaticClass, "RunEQS");
            }

            internal static unsafe AITask_RunEQS Invoke(AIController Controller, EnvQuery QueryTemplate) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((IntPtr*)(b+8)) = QueryTemplate;
                Main.GetProcessEvent(AITask_RunEQS.DefaultObject, RunEQS_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct AITask_RunEQS_events {
    }
}
