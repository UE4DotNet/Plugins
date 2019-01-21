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
    [StructLayout( LayoutKind.Explicit, Size=832 )]
    internal unsafe struct SceneCaptureComponentCube_fields {
        [FieldOffset(792)]  public IntPtr  TextureTarget;
        [FieldOffset(800)]  public IntPtr  TextureTargetLeft;
        [FieldOffset(808)]  public IntPtr  TextureTargetRight;
        [FieldOffset(816)]  public IntPtr  TextureTargetODS;
        [FieldOffset(824)] public float IPD;
    }
    internal unsafe struct SceneCaptureComponentCube_methods {
        internal struct CaptureScene_method {
            static internal IntPtr CaptureScene_ptr;
            static CaptureScene_method() {
                CaptureScene_ptr = Main.GetMethodUFunction(SceneCaptureComponentCube.StaticClass, "CaptureScene");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CaptureScene_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SceneCaptureComponentCube_events {
    }
}
