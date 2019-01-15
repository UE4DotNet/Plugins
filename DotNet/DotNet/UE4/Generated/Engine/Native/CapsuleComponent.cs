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
    [StructLayout( LayoutKind.Explicit, Size=1568 )]
    internal unsafe struct CapsuleComponent_fields {
        [FieldOffset(1552)] public float CapsuleHalfHeight;
        [FieldOffset(1556)] public float CapsuleRadius;
    }
    internal unsafe struct CapsuleComponent_methods {
        internal struct GetScaledCapsuleHalfHeight_method {
            static internal IntPtr GetScaledCapsuleHalfHeight_ptr;
            static GetScaledCapsuleHalfHeight_method() {
                GetScaledCapsuleHalfHeight_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetScaledCapsuleHalfHeight");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledCapsuleHalfHeight_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetScaledCapsuleHalfHeight_WithoutHemisphere_method {
            static internal IntPtr GetScaledCapsuleHalfHeight_WithoutHemisphere_ptr;
            static GetScaledCapsuleHalfHeight_WithoutHemisphere_method() {
                GetScaledCapsuleHalfHeight_WithoutHemisphere_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetScaledCapsuleHalfHeight_WithoutHemisphere");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledCapsuleHalfHeight_WithoutHemisphere_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetScaledCapsuleRadius_method {
            static internal IntPtr GetScaledCapsuleRadius_ptr;
            static GetScaledCapsuleRadius_method() {
                GetScaledCapsuleRadius_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetScaledCapsuleRadius");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledCapsuleRadius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetScaledCapsuleSize_method {
            static internal IntPtr GetScaledCapsuleSize_ptr;
            static GetScaledCapsuleSize_method() {
                GetScaledCapsuleSize_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetScaledCapsuleSize");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledCapsuleSize_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetScaledCapsuleSize_WithoutHemisphere_method {
            static internal IntPtr GetScaledCapsuleSize_WithoutHemisphere_ptr;
            static GetScaledCapsuleSize_WithoutHemisphere_method() {
                GetScaledCapsuleSize_WithoutHemisphere_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetScaledCapsuleSize_WithoutHemisphere");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledCapsuleSize_WithoutHemisphere_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetShapeScale_method {
            static internal IntPtr GetShapeScale_ptr;
            static GetShapeScale_method() {
                GetShapeScale_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetShapeScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetShapeScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetUnscaledCapsuleHalfHeight_method {
            static internal IntPtr GetUnscaledCapsuleHalfHeight_ptr;
            static GetUnscaledCapsuleHalfHeight_method() {
                GetUnscaledCapsuleHalfHeight_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetUnscaledCapsuleHalfHeight");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledCapsuleHalfHeight_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetUnscaledCapsuleHalfHeight_WithoutHemisphere_method {
            static internal IntPtr GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ptr;
            static GetUnscaledCapsuleHalfHeight_WithoutHemisphere_method() {
                GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetUnscaledCapsuleHalfHeight_WithoutHemisphere");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetUnscaledCapsuleRadius_method {
            static internal IntPtr GetUnscaledCapsuleRadius_ptr;
            static GetUnscaledCapsuleRadius_method() {
                GetUnscaledCapsuleRadius_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetUnscaledCapsuleRadius");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledCapsuleRadius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetUnscaledCapsuleSize_method {
            static internal IntPtr GetUnscaledCapsuleSize_ptr;
            static GetUnscaledCapsuleSize_method() {
                GetUnscaledCapsuleSize_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetUnscaledCapsuleSize");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledCapsuleSize_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetUnscaledCapsuleSize_WithoutHemisphere_method {
            static internal IntPtr GetUnscaledCapsuleSize_WithoutHemisphere_ptr;
            static GetUnscaledCapsuleSize_WithoutHemisphere_method() {
                GetUnscaledCapsuleSize_WithoutHemisphere_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "GetUnscaledCapsuleSize_WithoutHemisphere");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledCapsuleSize_WithoutHemisphere_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct SetCapsuleHalfHeight_method {
            static internal IntPtr SetCapsuleHalfHeight_ptr;
            static SetCapsuleHalfHeight_method() {
                SetCapsuleHalfHeight_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "SetCapsuleHalfHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float HalfHeight, bool bUpdateOverlaps) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = HalfHeight;
                *((bool*)(b+4)) = bUpdateOverlaps;
                Main.GetProcessEvent(obj, SetCapsuleHalfHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCapsuleRadius_method {
            static internal IntPtr SetCapsuleRadius_ptr;
            static SetCapsuleRadius_method() {
                SetCapsuleRadius_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "SetCapsuleRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float Radius, bool bUpdateOverlaps) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Radius;
                *((bool*)(b+4)) = bUpdateOverlaps;
                Main.GetProcessEvent(obj, SetCapsuleRadius_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCapsuleSize_method {
            static internal IntPtr SetCapsuleSize_ptr;
            static SetCapsuleSize_method() {
                SetCapsuleSize_ptr = Main.GetMethodUFunction(CapsuleComponent.StaticClass, "SetCapsuleSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float InRadius, float InHalfHeight, bool bUpdateOverlaps) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InRadius;
                *((float*)(b+4)) = InHalfHeight;
                *((bool*)(b+8)) = bUpdateOverlaps;
                Main.GetProcessEvent(obj, SetCapsuleSize_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CapsuleComponent_events {
    }
}
