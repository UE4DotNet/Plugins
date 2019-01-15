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

namespace UE4.HeadMountedDisplay.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct XRAssetFunctionLibrary_fields {
    }
    internal unsafe struct XRAssetFunctionLibrary_methods {
        internal struct AddDeviceVisualizationComponentBlocking_method {
            static internal IntPtr AddDeviceVisualizationComponentBlocking_ptr;
            static AddDeviceVisualizationComponentBlocking_method() {
                AddDeviceVisualizationComponentBlocking_ptr = Main.GetMethodUFunction(XRAssetFunctionLibrary.StaticClass, "AddDeviceVisualizationComponentBlocking");
            }

            internal static unsafe PrimitiveComponent Invoke(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((XRDeviceId*)(b+8)) = XRDeviceId;
                *((bool*)(b+24)) = bManualAttachment;
                *((Transform*)(b+32)) = RelativeTransform;
                Main.GetProcessEvent(XRAssetFunctionLibrary.DefaultObject, AddDeviceVisualizationComponentBlocking_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct AddNamedDeviceVisualizationComponentBlocking_method {
            static internal IntPtr AddNamedDeviceVisualizationComponentBlocking_ptr;
            static AddNamedDeviceVisualizationComponentBlocking_method() {
                AddNamedDeviceVisualizationComponentBlocking_ptr = Main.GetMethodUFunction(XRAssetFunctionLibrary.StaticClass, "AddNamedDeviceVisualizationComponentBlocking");
            }

            internal static unsafe (XRDeviceId, PrimitiveComponent) Invoke(Actor Target, Name SystemName, Name DeviceName, bool bManualAttachment, Transform RelativeTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((Name*)(b+8)) = SystemName;
                *((Name*)(b+20)) = DeviceName;
                *((bool*)(b+32)) = bManualAttachment;
                *((Transform*)(b+48)) = RelativeTransform;
                Main.GetProcessEvent(XRAssetFunctionLibrary.DefaultObject, AddNamedDeviceVisualizationComponentBlocking_ptr, new IntPtr(p)); ;
                return (*((XRDeviceId*)(b+96)),*((IntPtr*)(b+112)));
            }
        }
    }
    internal unsafe struct XRAssetFunctionLibrary_events {
    }
}
