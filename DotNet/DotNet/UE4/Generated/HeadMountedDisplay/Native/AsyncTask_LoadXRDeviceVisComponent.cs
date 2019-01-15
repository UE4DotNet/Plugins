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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct AsyncTask_LoadXRDeviceVisComponent_fields {
        [FieldOffset(64)] byte OnModelLoaded; //TODO: multicast delegate FDeviceModelLoadedDelegate OnModelLoaded
        [FieldOffset(80)] byte OnLoadFailure; //TODO: multicast delegate FDeviceModelLoadedDelegate OnLoadFailure
        [FieldOffset(104)]  public IntPtr  SpawnedComponent;
    }
    internal unsafe struct AsyncTask_LoadXRDeviceVisComponent_methods {
        internal struct AddDeviceVisualizationComponentAsync_method {
            static internal IntPtr AddDeviceVisualizationComponentAsync_ptr;
            static AddDeviceVisualizationComponentAsync_method() {
                AddDeviceVisualizationComponentAsync_ptr = Main.GetMethodUFunction(AsyncTask_LoadXRDeviceVisComponent.StaticClass, "AddDeviceVisualizationComponentAsync");
            }

            internal static unsafe (PrimitiveComponent, AsyncTask_LoadXRDeviceVisComponent) Invoke(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((XRDeviceId*)(b+8)) = XRDeviceId;
                *((bool*)(b+24)) = bManualAttachment;
                *((Transform*)(b+32)) = RelativeTransform;
                Main.GetProcessEvent(AsyncTask_LoadXRDeviceVisComponent.DefaultObject, AddDeviceVisualizationComponentAsync_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+80)),*((IntPtr*)(b+88)));
            }
        }
        internal struct AddNamedDeviceVisualizationComponentAsync_method {
            static internal IntPtr AddNamedDeviceVisualizationComponentAsync_ptr;
            static AddNamedDeviceVisualizationComponentAsync_method() {
                AddNamedDeviceVisualizationComponentAsync_ptr = Main.GetMethodUFunction(AsyncTask_LoadXRDeviceVisComponent.StaticClass, "AddNamedDeviceVisualizationComponentAsync");
            }

            internal static unsafe (XRDeviceId, PrimitiveComponent, AsyncTask_LoadXRDeviceVisComponent) Invoke(Actor Target, Name SystemName, Name DeviceName, bool bManualAttachment, Transform RelativeTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((Name*)(b+8)) = SystemName;
                *((Name*)(b+20)) = DeviceName;
                *((bool*)(b+32)) = bManualAttachment;
                *((Transform*)(b+48)) = RelativeTransform;
                Main.GetProcessEvent(AsyncTask_LoadXRDeviceVisComponent.DefaultObject, AddNamedDeviceVisualizationComponentAsync_ptr, new IntPtr(p)); ;
                return (*((XRDeviceId*)(b+96)),*((IntPtr*)(b+112)),*((IntPtr*)(b+120)));
            }
        }
    }
    internal unsafe struct AsyncTask_LoadXRDeviceVisComponent_events {
    }
}
