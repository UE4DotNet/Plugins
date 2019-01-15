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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=768 )]
    internal unsafe struct PlanesComponent_fields {
        [FieldOffset(624)] public NativeArray QueryFlags;
        [FieldOffset(640)]  public IntPtr  SearchVolume;
        [FieldOffset(648)] public int MaxResults;
        [FieldOffset(652)] public float MinHolePerimeter;
        [FieldOffset(656)] public float MinPlaneArea;
        [FieldOffset(660)] public bool IgnoreBoundingVolume;
    }
    internal unsafe struct PlanesComponent_methods {
        internal struct RequestPlanes_method {
            static internal IntPtr RequestPlanes_ptr;
            static RequestPlanes_method() {
                RequestPlanes_ptr = Main.GetMethodUFunction(PlanesComponent.StaticClass, "RequestPlanes");
            }

            internal static unsafe bool Invoke(IntPtr obj, int UserData, byte ResultDelegate /*TODO: delegate FPlaneResultDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = UserData;
                throw new NotImplementedException(); //TODO: delegate FPlaneResultDelegate ResultDelegate
                Main.GetProcessEvent(obj, RequestPlanes_ptr, new IntPtr(p)); ;
                 //TODO: delegate FPlaneResultDelegate ResultDelegate
                return *((bool*)(b+24));
            }
        }
    }
    internal unsafe struct PlanesComponent_events {
    }
}
