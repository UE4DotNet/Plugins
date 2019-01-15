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

using UE4.Engine;
using UE4.HeadMountedDisplay;

namespace UE4.OculusHMD.Native {
    [StructLayout( LayoutKind.Explicit, Size=656 )]
    internal unsafe struct DeprecatedGearVRControllerComponent_fields {
        [FieldOffset(624)]  public IntPtr  ControllerMesh;
    }
    internal unsafe struct DeprecatedGearVRControllerComponent_methods {
        internal struct GetControllerMesh_method {
            static internal IntPtr GetControllerMesh_ptr;
            static GetControllerMesh_method() {
                GetControllerMesh_ptr = Main.GetMethodUFunction(DeprecatedGearVRControllerComponent.StaticClass, "GetControllerMesh");
            }

            internal static unsafe StaticMeshComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetControllerMesh_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetMotionController_method {
            static internal IntPtr GetMotionController_ptr;
            static GetMotionController_method() {
                GetMotionController_ptr = Main.GetMethodUFunction(DeprecatedGearVRControllerComponent.StaticClass, "GetMotionController");
            }

            internal static unsafe MotionControllerComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMotionController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct DeprecatedGearVRControllerComponent_events {
    }
}
