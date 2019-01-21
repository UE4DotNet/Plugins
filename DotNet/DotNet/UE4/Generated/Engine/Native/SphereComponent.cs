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
    [StructLayout( LayoutKind.Explicit, Size=1536 )]
    internal unsafe struct SphereComponent_fields {
        [FieldOffset(1528)] public float SphereRadius;
    }
    internal unsafe struct SphereComponent_methods {
        internal struct GetScaledSphereRadius_method {
            static internal IntPtr GetScaledSphereRadius_ptr;
            static GetScaledSphereRadius_method() {
                GetScaledSphereRadius_ptr = Main.GetMethodUFunction(SphereComponent.StaticClass, "GetScaledSphereRadius");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledSphereRadius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetShapeScale_method {
            static internal IntPtr GetShapeScale_ptr;
            static GetShapeScale_method() {
                GetShapeScale_ptr = Main.GetMethodUFunction(SphereComponent.StaticClass, "GetShapeScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetShapeScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetUnscaledSphereRadius_method {
            static internal IntPtr GetUnscaledSphereRadius_ptr;
            static GetUnscaledSphereRadius_method() {
                GetUnscaledSphereRadius_ptr = Main.GetMethodUFunction(SphereComponent.StaticClass, "GetUnscaledSphereRadius");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledSphereRadius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetSphereRadius_method {
            static internal IntPtr SetSphereRadius_ptr;
            static SetSphereRadius_method() {
                SetSphereRadius_ptr = Main.GetMethodUFunction(SphereComponent.StaticClass, "SetSphereRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float InSphereRadius, bool bUpdateOverlaps) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InSphereRadius;
                *((bool*)(b+4)) = bUpdateOverlaps;
                Main.GetProcessEvent(obj, SetSphereRadius_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SphereComponent_events {
    }
}
