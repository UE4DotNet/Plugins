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
    [StructLayout( LayoutKind.Explicit, Size=1024 )]
    internal unsafe struct SpotLightComponent_fields {
        [FieldOffset(1000)] public float InnerConeAngle;
        [FieldOffset(1004)] public float OuterConeAngle;
        [FieldOffset(1008)] public float LightShaftConeAngle;
    }
    internal unsafe struct SpotLightComponent_methods {
        internal struct SetInnerConeAngle_method {
            static internal IntPtr SetInnerConeAngle_ptr;
            static SetInnerConeAngle_method() {
                SetInnerConeAngle_ptr = Main.GetMethodUFunction(SpotLightComponent.StaticClass, "SetInnerConeAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewInnerConeAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewInnerConeAngle;
                Main.GetProcessEvent(obj, SetInnerConeAngle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOuterConeAngle_method {
            static internal IntPtr SetOuterConeAngle_ptr;
            static SetOuterConeAngle_method() {
                SetOuterConeAngle_ptr = Main.GetMethodUFunction(SpotLightComponent.StaticClass, "SetOuterConeAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewOuterConeAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewOuterConeAngle;
                Main.GetProcessEvent(obj, SetOuterConeAngle_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SpotLightComponent_events {
    }
}
