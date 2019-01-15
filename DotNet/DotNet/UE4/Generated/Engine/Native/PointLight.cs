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
    internal unsafe struct PointLight_fields {
        [FieldOffset(1024)]  public IntPtr  PointLightComponent;
    }
    internal unsafe struct PointLight_methods {
        internal struct SetLightFalloffExponent_method {
            static internal IntPtr SetLightFalloffExponent_ptr;
            static SetLightFalloffExponent_method() {
                SetLightFalloffExponent_ptr = Main.GetMethodUFunction(PointLight.StaticClass, "SetLightFalloffExponent");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLightFalloffExponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLightFalloffExponent;
                Main.GetProcessEvent(obj, SetLightFalloffExponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRadius_method {
            static internal IntPtr SetRadius_ptr;
            static SetRadius_method() {
                SetRadius_ptr = Main.GetMethodUFunction(PointLight.StaticClass, "SetRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewRadius) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewRadius;
                Main.GetProcessEvent(obj, SetRadius_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PointLight_events {
    }
}
