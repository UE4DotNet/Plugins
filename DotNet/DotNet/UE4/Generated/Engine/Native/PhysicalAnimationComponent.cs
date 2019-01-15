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
    [StructLayout( LayoutKind.Explicit, Size=320 )]
    internal unsafe struct PhysicalAnimationComponent_fields {
        [FieldOffset(256)] public float StrengthMultiplyer;
        [FieldOffset(264)]  public IntPtr  SkeletalMeshComponent;
    }
    internal unsafe struct PhysicalAnimationComponent_methods {
        internal struct ApplyPhysicalAnimationProfileBelow_method {
            static internal IntPtr ApplyPhysicalAnimationProfileBelow_ptr;
            static ApplyPhysicalAnimationProfileBelow_method() {
                ApplyPhysicalAnimationProfileBelow_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "ApplyPhysicalAnimationProfileBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BodyName, Name ProfileName, bool bIncludeSelf, bool bClearNotFound) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BodyName;
                *((Name*)(b+12)) = ProfileName;
                *((bool*)(b+24)) = bIncludeSelf;
                *((bool*)(b+25)) = bClearNotFound;
                Main.GetProcessEvent(obj, ApplyPhysicalAnimationProfileBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyPhysicalAnimationSettings_method {
            static internal IntPtr ApplyPhysicalAnimationSettings_ptr;
            static ApplyPhysicalAnimationSettings_method() {
                ApplyPhysicalAnimationSettings_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "ApplyPhysicalAnimationSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BodyName, PhysicalAnimationData PhysicalAnimationData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BodyName;
                *((PhysicalAnimationData*)(b+12)) = PhysicalAnimationData;
                Main.GetProcessEvent(obj, ApplyPhysicalAnimationSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyPhysicalAnimationSettingsBelow_method {
            static internal IntPtr ApplyPhysicalAnimationSettingsBelow_ptr;
            static ApplyPhysicalAnimationSettingsBelow_method() {
                ApplyPhysicalAnimationSettingsBelow_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "ApplyPhysicalAnimationSettingsBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BodyName, PhysicalAnimationData PhysicalAnimationData, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BodyName;
                *((PhysicalAnimationData*)(b+12)) = PhysicalAnimationData;
                *((bool*)(b+52)) = bIncludeSelf;
                Main.GetProcessEvent(obj, ApplyPhysicalAnimationSettingsBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBodyTargetTransform_method {
            static internal IntPtr GetBodyTargetTransform_ptr;
            static GetBodyTargetTransform_method() {
                GetBodyTargetTransform_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "GetBodyTargetTransform");
            }

            internal static unsafe Transform Invoke(IntPtr obj, Name BodyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BodyName;
                Main.GetProcessEvent(obj, GetBodyTargetTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct SetSkeletalMeshComponent_method {
            static internal IntPtr SetSkeletalMeshComponent_ptr;
            static SetSkeletalMeshComponent_method() {
                SetSkeletalMeshComponent_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "SetSkeletalMeshComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SkeletalMeshComponent InSkeletalMeshComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InSkeletalMeshComponent;
                Main.GetProcessEvent(obj, SetSkeletalMeshComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStrengthMultiplyer_method {
            static internal IntPtr SetStrengthMultiplyer_ptr;
            static SetStrengthMultiplyer_method() {
                SetStrengthMultiplyer_ptr = Main.GetMethodUFunction(PhysicalAnimationComponent.StaticClass, "SetStrengthMultiplyer");
            }

            internal static unsafe void Invoke(IntPtr obj, float InStrengthMultiplyer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InStrengthMultiplyer;
                Main.GetProcessEvent(obj, SetStrengthMultiplyer_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PhysicalAnimationComponent_events {
    }
}
