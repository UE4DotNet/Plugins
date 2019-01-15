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


namespace UE4.ApexDestruction.Native {
    [StructLayout( LayoutKind.Explicit, Size=2224 )]
    internal unsafe struct DestructibleComponent_fields {
        [FieldOffset(2000)] public bool bFractureEffectOverride;
        [FieldOffset(2008)] byte FractureEffects; //TODO: array TArray FractureEffects
        [FieldOffset(2024)] public bool bEnableHardSleeping;
        [FieldOffset(2028)] public float LargeChunkThreshold;
        [FieldOffset(2032)]  public IntPtr  DestructibleMesh;
        [FieldOffset(2056)] byte OnComponentFracture; //TODO: multicast delegate FComponentFractureSignature OnComponentFracture
    }
    internal unsafe struct DestructibleComponent_methods {
        internal struct ApplyDamage_method {
            static internal IntPtr ApplyDamage_ptr;
            static ApplyDamage_method() {
                ApplyDamage_ptr = Main.GetMethodUFunction(DestructibleComponent.StaticClass, "ApplyDamage");
            }

            internal static unsafe void Invoke(IntPtr obj, float DamageAmount, Vector HitLocation, Vector ImpulseDir, float ImpulseStrength) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DamageAmount;
                *((Vector*)(b+4)) = HitLocation;
                *((Vector*)(b+16)) = ImpulseDir;
                *((float*)(b+28)) = ImpulseStrength;
                Main.GetProcessEvent(obj, ApplyDamage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyRadiusDamage_method {
            static internal IntPtr ApplyRadiusDamage_ptr;
            static ApplyRadiusDamage_method() {
                ApplyRadiusDamage_ptr = Main.GetMethodUFunction(DestructibleComponent.StaticClass, "ApplyRadiusDamage");
            }

            internal static unsafe void Invoke(IntPtr obj, float BaseDamage, Vector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = BaseDamage;
                *((Vector*)(b+4)) = HurtOrigin;
                *((float*)(b+16)) = DamageRadius;
                *((float*)(b+20)) = ImpulseStrength;
                *((bool*)(b+24)) = bFullDamage;
                Main.GetProcessEvent(obj, ApplyRadiusDamage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetDestructibleMesh_method {
            static internal IntPtr GetDestructibleMesh_ptr;
            static GetDestructibleMesh_method() {
                GetDestructibleMesh_ptr = Main.GetMethodUFunction(DestructibleComponent.StaticClass, "GetDestructibleMesh");
            }

            internal static unsafe DestructibleMesh Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDestructibleMesh_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetDestructibleMesh_method {
            static internal IntPtr SetDestructibleMesh_ptr;
            static SetDestructibleMesh_method() {
                SetDestructibleMesh_ptr = Main.GetMethodUFunction(DestructibleComponent.StaticClass, "SetDestructibleMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, DestructibleMesh NewMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMesh;
                Main.GetProcessEvent(obj, SetDestructibleMesh_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DestructibleComponent_events {
    }
}
