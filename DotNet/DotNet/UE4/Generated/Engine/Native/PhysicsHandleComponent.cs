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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct PhysicsHandleComponent_fields {
        [FieldOffset(256)]  public IntPtr  GrabbedComponent;
        [FieldOffset(280)] public bool bSoftAngularConstraint;
        [FieldOffset(280)] public bool bSoftLinearConstraint;
        [FieldOffset(280)] public bool bInterpolateTarget;
        [FieldOffset(284)] public float LinearDamping;
        [FieldOffset(288)] public float LinearStiffness;
        [FieldOffset(292)] public float AngularDamping;
        [FieldOffset(296)] public float AngularStiffness;
        [FieldOffset(400)] public float InterpolationSpeed;
    }
    internal unsafe struct PhysicsHandleComponent_methods {
        internal struct GetGrabbedComponent_method {
            static internal IntPtr GetGrabbedComponent_ptr;
            static GetGrabbedComponent_method() {
                GetGrabbedComponent_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "GetGrabbedComponent");
            }

            internal static unsafe PrimitiveComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetGrabbedComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetTargetLocationAndRotation_method {
            static internal IntPtr GetTargetLocationAndRotation_ptr;
            static GetTargetLocationAndRotation_method() {
                GetTargetLocationAndRotation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "GetTargetLocationAndRotation");
            }

            internal static unsafe (Vector, Rotator) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTargetLocationAndRotation_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Rotator*)(b+12)));
            }
        }
        internal struct GrabComponent_method {
            static internal IntPtr GrabComponent_ptr;
            static GrabComponent_method() {
                GrabComponent_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "GrabComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent Component, Name InBoneName, Vector GrabLocation, bool bConstrainRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Name*)(b+8)) = InBoneName;
                *((Vector*)(b+20)) = GrabLocation;
                *((bool*)(b+32)) = bConstrainRotation;
                Main.GetProcessEvent(obj, GrabComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GrabComponentAtLocation_method {
            static internal IntPtr GrabComponentAtLocation_ptr;
            static GrabComponentAtLocation_method() {
                GrabComponentAtLocation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "GrabComponentAtLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent Component, Name InBoneName, Vector GrabLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Name*)(b+8)) = InBoneName;
                *((Vector*)(b+20)) = GrabLocation;
                Main.GetProcessEvent(obj, GrabComponentAtLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GrabComponentAtLocationWithRotation_method {
            static internal IntPtr GrabComponentAtLocationWithRotation_ptr;
            static GrabComponentAtLocationWithRotation_method() {
                GrabComponentAtLocationWithRotation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "GrabComponentAtLocationWithRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent Component, Name InBoneName, Vector Location, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Name*)(b+8)) = InBoneName;
                *((Vector*)(b+20)) = Location;
                *((Rotator*)(b+32)) = Rotation;
                Main.GetProcessEvent(obj, GrabComponentAtLocationWithRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReleaseComponent_method {
            static internal IntPtr ReleaseComponent_ptr;
            static ReleaseComponent_method() {
                ReleaseComponent_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "ReleaseComponent");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReleaseComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularDamping_method {
            static internal IntPtr SetAngularDamping_ptr;
            static SetAngularDamping_method() {
                SetAngularDamping_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetAngularDamping");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewAngularDamping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewAngularDamping;
                Main.GetProcessEvent(obj, SetAngularDamping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularStiffness_method {
            static internal IntPtr SetAngularStiffness_ptr;
            static SetAngularStiffness_method() {
                SetAngularStiffness_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetAngularStiffness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewAngularStiffness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewAngularStiffness;
                Main.GetProcessEvent(obj, SetAngularStiffness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInterpolationSpeed_method {
            static internal IntPtr SetInterpolationSpeed_ptr;
            static SetInterpolationSpeed_method() {
                SetInterpolationSpeed_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetInterpolationSpeed");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewInterpolationSpeed) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewInterpolationSpeed;
                Main.GetProcessEvent(obj, SetInterpolationSpeed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearDamping_method {
            static internal IntPtr SetLinearDamping_ptr;
            static SetLinearDamping_method() {
                SetLinearDamping_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetLinearDamping");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLinearDamping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLinearDamping;
                Main.GetProcessEvent(obj, SetLinearDamping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearStiffness_method {
            static internal IntPtr SetLinearStiffness_ptr;
            static SetLinearStiffness_method() {
                SetLinearStiffness_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetLinearStiffness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLinearStiffness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLinearStiffness;
                Main.GetProcessEvent(obj, SetLinearStiffness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTargetLocation_method {
            static internal IntPtr SetTargetLocation_ptr;
            static SetTargetLocation_method() {
                SetTargetLocation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetTargetLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLocation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                Main.GetProcessEvent(obj, SetTargetLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTargetLocationAndRotation_method {
            static internal IntPtr SetTargetLocationAndRotation_ptr;
            static SetTargetLocationAndRotation_method() {
                SetTargetLocationAndRotation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetTargetLocationAndRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                Main.GetProcessEvent(obj, SetTargetLocationAndRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTargetRotation_method {
            static internal IntPtr SetTargetRotation_ptr;
            static SetTargetRotation_method() {
                SetTargetRotation_ptr = Main.GetMethodUFunction(PhysicsHandleComponent.StaticClass, "SetTargetRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, Rotator NewRotation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRotation;
                Main.GetProcessEvent(obj, SetTargetRotation_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PhysicsHandleComponent_events {
    }
}
