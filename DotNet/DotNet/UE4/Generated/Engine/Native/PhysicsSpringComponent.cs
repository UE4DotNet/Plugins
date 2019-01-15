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
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct PhysicsSpringComponent_fields {
        [FieldOffset(624)] public float SpringStiffness;
        [FieldOffset(628)] public float SpringDamping;
        [FieldOffset(632)] public float SpringLengthAtRest;
        [FieldOffset(636)] public float SpringRadius;
        [FieldOffset(640)] public byte SpringChannel;
        [FieldOffset(641)] public bool bIgnoreSelf;
        [FieldOffset(644)] public float SpringCompression;
    }
    internal unsafe struct PhysicsSpringComponent_methods {
        internal struct GetNormalizedCompressionScalar_method {
            static internal IntPtr GetNormalizedCompressionScalar_ptr;
            static GetNormalizedCompressionScalar_method() {
                GetNormalizedCompressionScalar_ptr = Main.GetMethodUFunction(PhysicsSpringComponent.StaticClass, "GetNormalizedCompressionScalar");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNormalizedCompressionScalar_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetSpringCurrentEndPoint_method {
            static internal IntPtr GetSpringCurrentEndPoint_ptr;
            static GetSpringCurrentEndPoint_method() {
                GetSpringCurrentEndPoint_ptr = Main.GetMethodUFunction(PhysicsSpringComponent.StaticClass, "GetSpringCurrentEndPoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSpringCurrentEndPoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetSpringDirection_method {
            static internal IntPtr GetSpringDirection_ptr;
            static GetSpringDirection_method() {
                GetSpringDirection_ptr = Main.GetMethodUFunction(PhysicsSpringComponent.StaticClass, "GetSpringDirection");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSpringDirection_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetSpringRestingPoint_method {
            static internal IntPtr GetSpringRestingPoint_ptr;
            static GetSpringRestingPoint_method() {
                GetSpringRestingPoint_ptr = Main.GetMethodUFunction(PhysicsSpringComponent.StaticClass, "GetSpringRestingPoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSpringRestingPoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
    }
    internal unsafe struct PhysicsSpringComponent_events {
    }
}
