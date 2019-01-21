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
    [StructLayout( LayoutKind.Explicit, Size=1552 )]
    internal unsafe struct VectorFieldComponent_fields {
        [FieldOffset(1504)]  public IntPtr  VectorField;
        [FieldOffset(1512)] public float Intensity;
        [FieldOffset(1516)] public float Tightness;
        [FieldOffset(1520)] public bool bPreviewVectorField;
    }
    internal unsafe struct VectorFieldComponent_methods {
        internal struct SetIntensity_method {
            static internal IntPtr SetIntensity_ptr;
            static SetIntensity_method() {
                SetIntensity_ptr = Main.GetMethodUFunction(VectorFieldComponent.StaticClass, "SetIntensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensity;
                Main.GetProcessEvent(obj, SetIntensity_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct VectorFieldComponent_events {
    }
}
