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

namespace UE4.MagicLeapGestures.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapGesturesFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapGesturesFunctionLibrary_methods {
        internal struct GetConfiguration_method {
            static internal IntPtr GetConfiguration_ptr;
            static GetConfiguration_method() {
                GetConfiguration_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetConfiguration");
            }

            internal static unsafe (IReadOnlyCollection<EStaticGestures>, EGestureKeypointsFilterLevel, EGestureRecognitionFilterLevel, EGestureRecognitionFilterLevel, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetConfiguration_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActiveStaticGestures
                return (UObject.ToUnmangedCollection<EStaticGestures>(b+0),*((EGestureKeypointsFilterLevel*)(b+16)),*((EGestureRecognitionFilterLevel*)(b+17)),*((EGestureRecognitionFilterLevel*)(b+18)),*((bool*)(b+19)));
            }
        }
        internal struct GetCurrentGesture_method {
            static internal IntPtr GetCurrentGesture_ptr;
            static GetCurrentGesture_method() {
                GetCurrentGesture_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetCurrentGesture");
            }

            internal static unsafe (EStaticGestures, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetCurrentGesture_ptr, new IntPtr(p)); ;
                return (*((EStaticGestures*)(b+1)),*((bool*)(b+2)));
            }
        }
        internal struct GetGestureKeypoints_method {
            static internal IntPtr GetGestureKeypoints_ptr;
            static GetGestureKeypoints_method() {
                GetGestureKeypoints_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetGestureKeypoints");
            }

            internal static unsafe (IReadOnlyCollection<Transform>, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetGestureKeypoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Keypoints
                return (UObject.ToUnmangedCollection<Transform>(b+8),*((bool*)(b+24)));
            }
        }
        internal struct GetHandCenter_method {
            static internal IntPtr GetHandCenter_ptr;
            static GetHandCenter_method() {
                GetHandCenter_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetHandCenter");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetHandCenter_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetHandCenterNormalized_method {
            static internal IntPtr GetHandCenterNormalized_ptr;
            static GetHandCenterNormalized_method() {
                GetHandCenterNormalized_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetHandCenterNormalized");
            }

            internal static unsafe (Vector, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetHandCenterNormalized_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((bool*)(b+16)));
            }
        }
        internal struct GetHandGestureConfidence_method {
            static internal IntPtr GetHandGestureConfidence_ptr;
            static GetHandGestureConfidence_method() {
                GetHandGestureConfidence_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetHandGestureConfidence");
            }

            internal static unsafe (float, bool) Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetHandGestureConfidence_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((bool*)(b+8)));
            }
        }
        internal struct GetHandPointer_method {
            static internal IntPtr GetHandPointer_ptr;
            static GetHandPointer_method() {
                GetHandPointer_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetHandPointer");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand, EGestureTransformSpace TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)TransformSpace;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetHandPointer_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetHandSecondary_method {
            static internal IntPtr GetHandSecondary_ptr;
            static GetHandSecondary_method() {
                GetHandSecondary_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetHandSecondary");
            }

            internal static unsafe (Transform, bool) Invoke(EControllerHand Hand, EGestureTransformSpace TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)TransformSpace;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetHandSecondary_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetStaticGestureConfidenceThreshold_method {
            static internal IntPtr GetStaticGestureConfidenceThreshold_ptr;
            static GetStaticGestureConfidenceThreshold_method() {
                GetStaticGestureConfidenceThreshold_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "GetStaticGestureConfidenceThreshold");
            }

            internal static unsafe float Invoke(EStaticGestures Gesture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Gesture;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, GetStaticGestureConfidenceThreshold_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct SetConfiguration_method {
            static internal IntPtr SetConfiguration_ptr;
            static SetConfiguration_method() {
                SetConfiguration_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "SetConfiguration");
            }

            internal static unsafe bool Invoke(byte StaticGesturesToActivate /*TODO: array TArray */, EGestureKeypointsFilterLevel KeypointsFilterLevel, EGestureRecognitionFilterLevel GestureFilterLevel, EGestureRecognitionFilterLevel HandSwitchingFilterLevel) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray StaticGesturesToActivate
                *(b+16) = (byte)KeypointsFilterLevel;
                *(b+17) = (byte)GestureFilterLevel;
                *(b+18) = (byte)HandSwitchingFilterLevel;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, SetConfiguration_ptr, new IntPtr(p)); ;
                 //TODO: array TArray StaticGesturesToActivate
                return *((bool*)(b+19));
            }
        }
        internal struct SetStaticGestureConfidenceThreshold_method {
            static internal IntPtr SetStaticGestureConfidenceThreshold_ptr;
            static SetStaticGestureConfidenceThreshold_method() {
                SetStaticGestureConfidenceThreshold_ptr = Main.GetMethodUFunction(MagicLeapGesturesFunctionLibrary.StaticClass, "SetStaticGestureConfidenceThreshold");
            }

            internal static unsafe void Invoke(EStaticGestures Gesture, float Confidence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Gesture;
                *((float*)(b+4)) = Confidence;
                Main.GetProcessEvent(MagicLeapGesturesFunctionLibrary.DefaultObject, SetStaticGestureConfidenceThreshold_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MagicLeapGesturesFunctionLibrary_events {
    }
}
