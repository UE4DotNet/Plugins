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
    [StructLayout( LayoutKind.Explicit, Size=2368 )]
    internal unsafe struct CameraActor_fields {
        [FieldOffset(1008)] public byte AutoActivateForPlayer;
        [FieldOffset(1016)]  public IntPtr  CameraComponent;
        [FieldOffset(1024)]  public IntPtr  SceneComponent;
    }
    internal unsafe struct CameraActor_methods {
        internal struct GetAutoActivatePlayerIndex_method {
            static internal IntPtr GetAutoActivatePlayerIndex_ptr;
            static GetAutoActivatePlayerIndex_method() {
                GetAutoActivatePlayerIndex_ptr = Main.GetMethodUFunction(CameraActor.StaticClass, "GetAutoActivatePlayerIndex");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAutoActivatePlayerIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
    }
    internal unsafe struct CameraActor_events {
    }
}
