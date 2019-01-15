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
    [StructLayout( LayoutKind.Explicit, Size=1032 )]
    internal unsafe struct SceneCaptureCube_fields {
        [FieldOffset(1016)]  public IntPtr  CaptureComponentCube;
        [FieldOffset(1024)]  public IntPtr  DrawFrustum;
    }
    internal unsafe struct SceneCaptureCube_methods {
        internal struct OnInterpToggle_method {
            static internal IntPtr OnInterpToggle_ptr;
            static OnInterpToggle_method() {
                OnInterpToggle_ptr = Main.GetMethodUFunction(SceneCaptureCube.StaticClass, "OnInterpToggle");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(obj, OnInterpToggle_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SceneCaptureCube_events {
    }
}
