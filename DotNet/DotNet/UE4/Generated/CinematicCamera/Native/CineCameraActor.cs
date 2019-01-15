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


namespace UE4.CinematicCamera.Native {
    [StructLayout( LayoutKind.Explicit, Size=2432 )]
    internal unsafe struct CineCameraActor_fields {
        [FieldOffset(2368)] public CameraLookatTrackingSettings LookatTrackingSettings;
    }
    internal unsafe struct CineCameraActor_methods {
        internal struct GetCineCameraComponent_method {
            static internal IntPtr GetCineCameraComponent_ptr;
            static GetCineCameraComponent_method() {
                GetCineCameraComponent_ptr = Main.GetMethodUFunction(CineCameraActor.StaticClass, "GetCineCameraComponent");
            }

            internal static unsafe CineCameraComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCineCameraComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct CineCameraActor_events {
    }
}
