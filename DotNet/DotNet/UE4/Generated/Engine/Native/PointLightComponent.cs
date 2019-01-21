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
    [StructLayout( LayoutKind.Explicit, Size=1008 )]
    internal unsafe struct PointLightComponent_fields {
        [FieldOffset(976)] public bool bUseInverseSquaredFalloff;
        [FieldOffset(980)] public float LightFalloffExponent;
        [FieldOffset(984)] public float SourceRadius;
        [FieldOffset(988)] public float SoftSourceRadius;
        [FieldOffset(992)] public float SourceLength;
    }
    internal unsafe struct PointLightComponent_methods {
        internal struct SetLightFalloffExponent_method {
            static internal IntPtr SetLightFalloffExponent_ptr;
            static SetLightFalloffExponent_method() {
                SetLightFalloffExponent_ptr = Main.GetMethodUFunction(PointLightComponent.StaticClass, "SetLightFalloffExponent");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLightFalloffExponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLightFalloffExponent;
                Main.GetProcessEvent(obj, SetLightFalloffExponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSoftSourceRadius_method {
            static internal IntPtr SetSoftSourceRadius_ptr;
            static SetSoftSourceRadius_method() {
                SetSoftSourceRadius_ptr = Main.GetMethodUFunction(PointLightComponent.StaticClass, "SetSoftSourceRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetSoftSourceRadius_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSourceLength_method {
            static internal IntPtr SetSourceLength_ptr;
            static SetSourceLength_method() {
                SetSourceLength_ptr = Main.GetMethodUFunction(PointLightComponent.StaticClass, "SetSourceLength");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetSourceLength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSourceRadius_method {
            static internal IntPtr SetSourceRadius_ptr;
            static SetSourceRadius_method() {
                SetSourceRadius_ptr = Main.GetMethodUFunction(PointLightComponent.StaticClass, "SetSourceRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetSourceRadius_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PointLightComponent_events {
    }
}
