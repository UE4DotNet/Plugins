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


namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=1584 )]
    internal unsafe struct VoipListenerSynthComponent_fields {
    }
    internal unsafe struct VoipListenerSynthComponent_methods {
        internal struct IsIdling_method {
            static internal IntPtr IsIdling_ptr;
            static IsIdling_method() {
                IsIdling_ptr = Main.GetMethodUFunction(VoipListenerSynthComponent.StaticClass, "IsIdling");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsIdling_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct VoipListenerSynthComponent_events {
    }
}
