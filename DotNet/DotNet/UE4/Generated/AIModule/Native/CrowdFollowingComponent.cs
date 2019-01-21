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
    [StructLayout( LayoutKind.Explicit, Size=776 )]
    internal unsafe struct CrowdFollowingComponent_fields {
        [FieldOffset(712)]  public IntPtr  CharacterMovement;
        [FieldOffset(720)] public Vector CrowdAgentMoveDirection;
    }
    internal unsafe struct CrowdFollowingComponent_methods {
        internal struct SuspendCrowdSteering_method {
            static internal IntPtr SuspendCrowdSteering_ptr;
            static SuspendCrowdSteering_method() {
                SuspendCrowdSteering_ptr = Main.GetMethodUFunction(CrowdFollowingComponent.StaticClass, "SuspendCrowdSteering");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bSuspend) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSuspend;
                Main.GetProcessEvent(obj, SuspendCrowdSteering_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CrowdFollowingComponent_events {
    }
}
