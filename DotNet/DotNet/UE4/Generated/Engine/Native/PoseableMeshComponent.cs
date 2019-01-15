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
    [StructLayout( LayoutKind.Explicit, Size=2304 )]
    internal unsafe struct PoseableMeshComponent_fields {
    }
    internal unsafe struct PoseableMeshComponent_methods {
        internal struct CopyPoseFromSkeletalComponent_method {
            static internal IntPtr CopyPoseFromSkeletalComponent_ptr;
            static CopyPoseFromSkeletalComponent_method() {
                CopyPoseFromSkeletalComponent_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "CopyPoseFromSkeletalComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SkeletalMeshComponent InComponentToCopy) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InComponentToCopy;
                Main.GetProcessEvent(obj, CopyPoseFromSkeletalComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBoneLocationByName_method {
            static internal IntPtr GetBoneLocationByName_ptr;
            static GetBoneLocationByName_method() {
                GetBoneLocationByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "GetBoneLocationByName");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *(b+12) = BoneSpace;
                Main.GetProcessEvent(obj, GetBoneLocationByName_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct GetBoneRotationByName_method {
            static internal IntPtr GetBoneRotationByName_ptr;
            static GetBoneRotationByName_method() {
                GetBoneRotationByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "GetBoneRotationByName");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, Name BoneName, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *(b+12) = BoneSpace;
                Main.GetProcessEvent(obj, GetBoneRotationByName_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+16));
            }
        }
        internal struct GetBoneScaleByName_method {
            static internal IntPtr GetBoneScaleByName_ptr;
            static GetBoneScaleByName_method() {
                GetBoneScaleByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "GetBoneScaleByName");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *(b+12) = BoneSpace;
                Main.GetProcessEvent(obj, GetBoneScaleByName_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct GetBoneTransformByName_method {
            static internal IntPtr GetBoneTransformByName_ptr;
            static GetBoneTransformByName_method() {
                GetBoneTransformByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "GetBoneTransformByName");
            }

            internal static unsafe Transform Invoke(IntPtr obj, Name BoneName, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *(b+12) = BoneSpace;
                Main.GetProcessEvent(obj, GetBoneTransformByName_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct ResetBoneTransformByName_method {
            static internal IntPtr ResetBoneTransformByName_ptr;
            static ResetBoneTransformByName_method() {
                ResetBoneTransformByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "ResetBoneTransformByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, ResetBoneTransformByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoneLocationByName_method {
            static internal IntPtr SetBoneLocationByName_ptr;
            static SetBoneLocationByName_method() {
                SetBoneLocationByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "SetBoneLocationByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, Vector InLocation, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Vector*)(b+12)) = InLocation;
                *(b+24) = BoneSpace;
                Main.GetProcessEvent(obj, SetBoneLocationByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoneRotationByName_method {
            static internal IntPtr SetBoneRotationByName_ptr;
            static SetBoneRotationByName_method() {
                SetBoneRotationByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "SetBoneRotationByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, Rotator InRotation, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Rotator*)(b+12)) = InRotation;
                *(b+24) = BoneSpace;
                Main.GetProcessEvent(obj, SetBoneRotationByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoneScaleByName_method {
            static internal IntPtr SetBoneScaleByName_ptr;
            static SetBoneScaleByName_method() {
                SetBoneScaleByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "SetBoneScaleByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, Vector InScale3D, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Vector*)(b+12)) = InScale3D;
                *(b+24) = BoneSpace;
                Main.GetProcessEvent(obj, SetBoneScaleByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoneTransformByName_method {
            static internal IntPtr SetBoneTransformByName_ptr;
            static SetBoneTransformByName_method() {
                SetBoneTransformByName_ptr = Main.GetMethodUFunction(PoseableMeshComponent.StaticClass, "SetBoneTransformByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, Transform InTransform, byte BoneSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Transform*)(b+16)) = InTransform;
                *(b+64) = BoneSpace;
                Main.GetProcessEvent(obj, SetBoneTransformByName_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PoseableMeshComponent_events {
    }
}
