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

namespace UE4.AnimGraphRuntime.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetAnimationLibrary_fields {
    }
    internal unsafe struct KismetAnimationLibrary_methods {
        internal struct K2_DirectionBetweenSockets_method {
            static internal IntPtr K2_DirectionBetweenSockets_ptr;
            static K2_DirectionBetweenSockets_method() {
                K2_DirectionBetweenSockets_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_DirectionBetweenSockets");
            }

            internal static unsafe Vector Invoke(SkeletalMeshComponent Component, Name SocketOrBoneNameFrom, Name SocketOrBoneNameTo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Name*)(b+8)) = SocketOrBoneNameFrom;
                *((Name*)(b+20)) = SocketOrBoneNameTo;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_DirectionBetweenSockets_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct K2_DistanceBetweenTwoSocketsAndMapRange_method {
            static internal IntPtr K2_DistanceBetweenTwoSocketsAndMapRange_ptr;
            static K2_DistanceBetweenTwoSocketsAndMapRange_method() {
                K2_DistanceBetweenTwoSocketsAndMapRange_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_DistanceBetweenTwoSocketsAndMapRange");
            }

            internal static unsafe float Invoke(SkeletalMeshComponent Component, Name SocketOrBoneNameA, byte SocketSpaceA, Name SocketOrBoneNameB, byte SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Name*)(b+8)) = SocketOrBoneNameA;
                *(b+20) = SocketSpaceA;
                *((Name*)(b+24)) = SocketOrBoneNameB;
                *(b+36) = SocketSpaceB;
                *((bool*)(b+37)) = bRemapRange;
                *((float*)(b+40)) = InRangeMin;
                *((float*)(b+44)) = InRangeMax;
                *((float*)(b+48)) = OutRangeMin;
                *((float*)(b+52)) = OutRangeMax;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_DistanceBetweenTwoSocketsAndMapRange_ptr, new IntPtr(p)); ;
                return *((float*)(b+56));
            }
        }
        internal struct K2_LookAt_method {
            static internal IntPtr K2_LookAt_ptr;
            static K2_LookAt_method() {
                K2_LookAt_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_LookAt");
            }

            internal static unsafe Transform Invoke(Transform CurrentTransform, Vector TargetPosition, Vector LookAtVector, bool bUseUpVector, Vector UpVector, float ClampConeInDegree) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = CurrentTransform;
                *((Vector*)(b+48)) = TargetPosition;
                *((Vector*)(b+60)) = LookAtVector;
                *((bool*)(b+72)) = bUseUpVector;
                *((Vector*)(b+76)) = UpVector;
                *((float*)(b+88)) = ClampConeInDegree;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_LookAt_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+96));
            }
        }
        internal struct K2_MakePerlinNoiseAndRemap_method {
            static internal IntPtr K2_MakePerlinNoiseAndRemap_ptr;
            static K2_MakePerlinNoiseAndRemap_method() {
                K2_MakePerlinNoiseAndRemap_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_MakePerlinNoiseAndRemap");
            }

            internal static unsafe float Invoke(float Value, float RangeOutMin, float RangeOutMax) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = RangeOutMin;
                *((float*)(b+8)) = RangeOutMax;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_MakePerlinNoiseAndRemap_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct K2_MakePerlinNoiseVectorAndRemap_method {
            static internal IntPtr K2_MakePerlinNoiseVectorAndRemap_ptr;
            static K2_MakePerlinNoiseVectorAndRemap_method() {
                K2_MakePerlinNoiseVectorAndRemap_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_MakePerlinNoiseVectorAndRemap");
            }

            internal static unsafe Vector Invoke(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = X;
                *((float*)(b+4)) = Y;
                *((float*)(b+8)) = Z;
                *((float*)(b+12)) = RangeOutMinX;
                *((float*)(b+16)) = RangeOutMaxX;
                *((float*)(b+20)) = RangeOutMinY;
                *((float*)(b+24)) = RangeOutMaxY;
                *((float*)(b+28)) = RangeOutMinZ;
                *((float*)(b+32)) = RangeOutMaxZ;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_MakePerlinNoiseVectorAndRemap_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+36));
            }
        }
        internal struct K2_TwoBoneIK_method {
            static internal IntPtr K2_TwoBoneIK_ptr;
            static K2_TwoBoneIK_method() {
                K2_TwoBoneIK_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_TwoBoneIK");
            }

            internal static unsafe (Vector, Vector) Invoke(Vector RootPos, Vector JointPos, Vector EndPos, Vector JointTarget, Vector Effector, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = RootPos;
                *((Vector*)(b+12)) = JointPos;
                *((Vector*)(b+24)) = EndPos;
                *((Vector*)(b+36)) = JointTarget;
                *((Vector*)(b+48)) = Effector;
                *((bool*)(b+84)) = bAllowStretching;
                *((float*)(b+88)) = StartStretchRatio;
                *((float*)(b+92)) = MaxStretchScale;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_TwoBoneIK_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+60)),*((Vector*)(b+72)));
            }
        }
    }
    internal unsafe struct KismetAnimationLibrary_events {
    }
}
