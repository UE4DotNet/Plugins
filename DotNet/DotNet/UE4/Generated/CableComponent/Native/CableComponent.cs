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

namespace UE4.CableComponent.Native {
    [StructLayout( LayoutKind.Explicit, Size=1680 )]
    internal unsafe struct CableComponent_fields {
        [FieldOffset(1544)] public bool bAttachStart;
        [FieldOffset(1545)] public bool bAttachEnd;
        [FieldOffset(1552)] public ComponentReference AttachEndTo;
        [FieldOffset(1584)] public Name AttachEndToSocketName;
        [FieldOffset(1596)] public Vector EndLocation;
        [FieldOffset(1608)] public float CableLength;
        [FieldOffset(1612)] public int NumSegments;
        [FieldOffset(1616)] public float SubstepTime;
        [FieldOffset(1620)] public int SolverIterations;
        [FieldOffset(1624)] public bool bEnableStiffness;
        [FieldOffset(1625)] public bool bEnableCollision;
        [FieldOffset(1628)] public float CollisionFriction;
        [FieldOffset(1632)] public Vector CableForce;
        [FieldOffset(1644)] public float CableGravityScale;
        [FieldOffset(1648)] public float CableWidth;
        [FieldOffset(1652)] public int NumSides;
        [FieldOffset(1656)] public float TileMaterial;
    }
    internal unsafe struct CableComponent_methods {
        internal struct GetAttachedActor_method {
            static internal IntPtr GetAttachedActor_ptr;
            static GetAttachedActor_method() {
                GetAttachedActor_ptr = Main.GetMethodUFunction(CableComponent.StaticClass, "GetAttachedActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachedActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetAttachedComponent_method {
            static internal IntPtr GetAttachedComponent_ptr;
            static GetAttachedComponent_method() {
                GetAttachedComponent_ptr = Main.GetMethodUFunction(CableComponent.StaticClass, "GetAttachedComponent");
            }

            internal static unsafe SceneComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachedComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetCableParticleLocations_method {
            static internal IntPtr GetCableParticleLocations_ptr;
            static GetCableParticleLocations_method() {
                GetCableParticleLocations_ptr = Main.GetMethodUFunction(CableComponent.StaticClass, "GetCableParticleLocations");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCableParticleLocations_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Locations
                return UObject.ToUnmangedCollection<Vector>(b+0);
            }
        }
        internal struct SetAttachEndTo_method {
            static internal IntPtr SetAttachEndTo_ptr;
            static SetAttachEndTo_method() {
                SetAttachEndTo_ptr = Main.GetMethodUFunction(CableComponent.StaticClass, "SetAttachEndTo");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor Actor, Name ComponentProperty, Name SocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                *((Name*)(b+8)) = ComponentProperty;
                *((Name*)(b+20)) = SocketName;
                Main.GetProcessEvent(obj, SetAttachEndTo_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CableComponent_events {
    }
}
