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
    internal unsafe struct RadialForceComponent_fields {
        [FieldOffset(624)] public float Radius;
        [FieldOffset(628)] public byte Falloff;
        [FieldOffset(632)] public float ImpulseStrength;
        [FieldOffset(636)] public bool bImpulseVelChange;
        [FieldOffset(636)] public bool bIgnoreOwningActor;
        [FieldOffset(640)] public float ForceStrength;
        [FieldOffset(644)] public float DestructibleDamage;
        [FieldOffset(648)] public NativeArray ObjectTypesToAffect;
    }
    internal unsafe struct RadialForceComponent_methods {
        internal struct AddObjectTypeToAffect_method {
            static internal IntPtr AddObjectTypeToAffect_ptr;
            static AddObjectTypeToAffect_method() {
                AddObjectTypeToAffect_ptr = Main.GetMethodUFunction(RadialForceComponent.StaticClass, "AddObjectTypeToAffect");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ObjectType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ObjectType;
                Main.GetProcessEvent(obj, AddObjectTypeToAffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FireImpulse_method {
            static internal IntPtr FireImpulse_ptr;
            static FireImpulse_method() {
                FireImpulse_ptr = Main.GetMethodUFunction(RadialForceComponent.StaticClass, "FireImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, FireImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveObjectTypeToAffect_method {
            static internal IntPtr RemoveObjectTypeToAffect_ptr;
            static RemoveObjectTypeToAffect_method() {
                RemoveObjectTypeToAffect_ptr = Main.GetMethodUFunction(RadialForceComponent.StaticClass, "RemoveObjectTypeToAffect");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ObjectType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ObjectType;
                Main.GetProcessEvent(obj, RemoveObjectTypeToAffect_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct RadialForceComponent_events {
    }
}
