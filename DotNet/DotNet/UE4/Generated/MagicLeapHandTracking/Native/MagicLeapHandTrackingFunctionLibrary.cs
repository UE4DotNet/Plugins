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

using UE4.InputCore;
using UE4.LiveLinkInterface;

namespace UE4.MagicLeapHandTracking.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapHandTrackingFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapHandTrackingFunctionLibrary_methods {
        internal struct GetConfiguration_method {
            static internal IntPtr GetConfiguration_ptr;
            static GetConfiguration_method() {
                GetConfiguration_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetConfiguration");
            }

            internal static unsafe (IReadOnlyCollection<EHandTrackingGesture>, EHandTrackingKeypointFilterLevel, EHandTrackingGestureFilterLevel, EHandTrackingGestureFilterLevel, bool, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetConfiguration_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActiveStaticGestures
                return (UObject.ToUnmangedCollection<EHandTrackingGesture>(b+0),*((EHandTrackingKeypointFilterLevel*)(b+16)),*((EHandTrackingGestureFilterLevel*)(b+17)),*((EHandTrackingGestureFilterLevel*)(b+18)),*((bool*)(b+19)),*((bool*)(b+20)));
            }
        }
        internal struct GetCurrentGesture_method {
            static internal IntPtr GetCurrentGesture_ptr;
            static GetCurrentGesture_method() {
                GetCurrentGesture_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetCurrentGesture");
            }

            internal static unsafe (EHandTrackingGesture, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetCurrentGesture_ptr, new IntPtr(p)); ;
                return (*((EHandTrackingGesture*)(b+1)),*((bool*)(b+2)));
            }
        }
        internal struct GetCurrentGestureConfidence_method {
            static internal IntPtr GetCurrentGestureConfidence_ptr;
            static GetCurrentGestureConfidence_method() {
                GetCurrentGestureConfidence_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetCurrentGestureConfidence");
            }

            internal static unsafe (float, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetCurrentGestureConfidence_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((bool*)(b+8)));
            }
        }
        internal struct GetGestureKeypoints_method {
            static internal IntPtr GetGestureKeypoints_ptr;
            static GetGestureKeypoints_method() {
                GetGestureKeypoints_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetGestureKeypoints");
            }

            internal static unsafe (IReadOnlyCollection<Transform>, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetGestureKeypoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Keypoints
                return (UObject.ToUnmangedCollection<Transform>(b+8),*((bool*)(b+24)));
            }
        }
        internal struct GetGestureKeypointTransform_method {
            static internal IntPtr GetGestureKeypointTransform_ptr;
            static GetGestureKeypointTransform_method() {
                GetGestureKeypointTransform_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetGestureKeypointTransform");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand, EHandTrackingKeypoint Keypoint, EGestureTransformSpace TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)Keypoint;
                *(b+2) = (byte)TransformSpace;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetGestureKeypointTransform_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetHandCenter_method {
            static internal IntPtr GetHandCenter_ptr;
            static GetHandCenter_method() {
                GetHandCenter_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetHandCenter");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetHandCenter_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetHandCenterNormalized_method {
            static internal IntPtr GetHandCenterNormalized_ptr;
            static GetHandCenterNormalized_method() {
                GetHandCenterNormalized_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetHandCenterNormalized");
            }

            internal static unsafe (Vector, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetHandCenterNormalized_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((bool*)(b+16)));
            }
        }
        internal struct GetHandIndexFingerTip_method {
            static internal IntPtr GetHandIndexFingerTip_ptr;
            static GetHandIndexFingerTip_method() {
                GetHandIndexFingerTip_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetHandIndexFingerTip");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand, EGestureTransformSpace TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)TransformSpace;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetHandIndexFingerTip_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetHandThumbTip_method {
            static internal IntPtr GetHandThumbTip_ptr;
            static GetHandThumbTip_method() {
                GetHandThumbTip_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetHandThumbTip");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand, EGestureTransformSpace TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)TransformSpace;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetHandThumbTip_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetMagicLeapHandTrackingLiveLinkSource_method {
            static internal IntPtr GetMagicLeapHandTrackingLiveLinkSource_ptr;
            static GetMagicLeapHandTrackingLiveLinkSource_method() {
                GetMagicLeapHandTrackingLiveLinkSource_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetMagicLeapHandTrackingLiveLinkSource");
            }

            internal static unsafe (LiveLinkSourceHandle, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetMagicLeapHandTrackingLiveLinkSource_ptr, new IntPtr(p)); ;
                return (*((LiveLinkSourceHandle*)(b+0)),*((bool*)(b+24)));
            }
        }
        internal struct GetStaticGestureConfidenceThreshold_method {
            static internal IntPtr GetStaticGestureConfidenceThreshold_ptr;
            static GetStaticGestureConfidenceThreshold_method() {
                GetStaticGestureConfidenceThreshold_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "GetStaticGestureConfidenceThreshold");
            }

            internal static unsafe float Invoke(EHandTrackingGesture Gesture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Gesture;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, GetStaticGestureConfidenceThreshold_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct SetConfiguration_method {
            static internal IntPtr SetConfiguration_ptr;
            static SetConfiguration_method() {
                SetConfiguration_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "SetConfiguration");
            }

            internal static unsafe bool Invoke(byte StaticGesturesToActivate /*TODO: array TArray */, EHandTrackingKeypointFilterLevel KeypointsFilterLevel, EHandTrackingGestureFilterLevel GestureFilterLevel, EHandTrackingGestureFilterLevel HandSwitchingFilterLevel, bool bTrackingEnabled) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray StaticGesturesToActivate
                *(b+16) = (byte)KeypointsFilterLevel;
                *(b+17) = (byte)GestureFilterLevel;
                *(b+18) = (byte)HandSwitchingFilterLevel;
                *((bool*)(b+19)) = bTrackingEnabled;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, SetConfiguration_ptr, new IntPtr(p)); ;
                 //TODO: array TArray StaticGesturesToActivate
                return *((bool*)(b+20));
            }
        }
        internal struct SetStaticGestureConfidenceThreshold_method {
            static internal IntPtr SetStaticGestureConfidenceThreshold_ptr;
            static SetStaticGestureConfidenceThreshold_method() {
                SetStaticGestureConfidenceThreshold_ptr = Main.GetMethodUFunction(MagicLeapHandTrackingFunctionLibrary.StaticClass, "SetStaticGestureConfidenceThreshold");
            }

            internal static unsafe void Invoke(EHandTrackingGesture Gesture, float Confidence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Gesture;
                *((float*)(b+4)) = Confidence;
                Main.GetProcessEvent(MagicLeapHandTrackingFunctionLibrary.DefaultObject, SetStaticGestureConfidenceThreshold_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MagicLeapHandTrackingFunctionLibrary_events {
    }
}
