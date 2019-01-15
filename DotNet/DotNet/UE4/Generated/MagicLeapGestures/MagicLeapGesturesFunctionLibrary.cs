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

#pragma warning disable CS0108
using UE4.MagicLeapGestures.Native;
using UE4.InputCore;
using UE4.Engine;

namespace UE4.MagicLeapGestures {
    ///<summary>Magic Leap Gestures Function Library</summary>
    public unsafe partial class MagicLeapGesturesFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Gets the list of static and dynamic gestures currently set to be identified by the gesture recognition system.</summary>
        ///<remarks>
        ///@param StaticGesturesToActivate Output parameter to list the static gestures that can be detected by the system.
        ///@param KeypointsFilterLevel Filtering for the keypoints and hand centers.
        ///@param GestureFilterLevel Filtering for the static gesture recognition.
        ///@param HandSwitchingFilterLevel Filtering for if the left or right hand is present.
        ///@return true if the output params were populated with a valid value, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<EStaticGestures>, EGestureKeypointsFilterLevel, EGestureRecognitionFilterLevel, EGestureRecognitionFilterLevel, bool) GetConfiguration()  => 
            MagicLeapGesturesFunctionLibrary_methods.GetConfiguration_method.Invoke();

        ///<summary>The current gesture being performed by the given hand.</summary>
        ///<remarks>
        ///@param Hand Hand to query the gesture for. Only Left and Right hand are supported.
        ///@param Gesture Output parameter containing the given hand's gesture, or NoHand if there isn't one or the system isnt working now.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (EStaticGestures, bool) GetCurrentGesture(EControllerHand Hand)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetCurrentGesture_method.Invoke(Hand);

        ///<summary>List of keypoints detected on the given hand.</summary>
        ///<remarks>
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to the following.
        ///Special_3 - Left keypoint 0
        ///Special_5 - Left keypoint 1
        ///Special_4 - Right keypoint 0
        ///Special_6 - Right keypoint 1
        ///
        ///@param Hand Hand to query the keypoints for. Only Left and Right hand are supported.
        ///@param Keypoints Output paramter containing transforms of the keypoints detected on the given hand.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Transform>, bool) GetGestureKeypoints(EControllerHand Hand)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetGestureKeypoints_method.Invoke(Hand);

        ///<summary>Transform of the center of the hand.</summary>
        ///<remarks>
        ///Approximately the center of the palm.
        ///
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to EControllerHand::Special_1
        ///for the left hand center and EControllerHand::Special_2 for the right hand center.
        ///
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param HandCenter Output parameter containing the position and orientation of the given hand.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (Transform, bool) GetHandCenter(EControllerHand Hand)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetHandCenter_method.Invoke(Hand);

        ///<summary>Normalized position of the center of the given hand.</summary>
        ///<remarks>
        ///This can be used to detect and warn the users that the hand is out of the gesture detection frame.
        ///
        ///@param Hand Hand to query the normalized hand center position for. Only Left and Right hand are supported.
        ///@param HandCenterNormalized Output paramter containing the normalized position of the given hand.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (Vector, bool) GetHandCenterNormalized(EControllerHand Hand)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetHandCenterNormalized_method.Invoke(Hand);

        ///<summary>The confidence level of the current gesture being performed by the given hand.</summary>
        ///<remarks>
        ///Value is between [0, 1], 0 is low, 1 is high degree of confidence. For a NoHand, the confidence is always set to 1.
        ///
        ///@param Hand Hand to query the gesture confidence value for. Only Left and Right hand are supported.
        ///@param Confidence Output parameter containing the confidence value for the given hand's gesture.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (float, bool) GetHandGestureConfidence(EControllerHand Hand)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetHandGestureConfidence_method.Invoke(Hand);

        ///<summary>Transform of Keypoint 0.</summary>
        ///<remarks>
        ///For the Finger, Pinch, L, OK, and C gestures this is the index finger tip.
        ///For the Fist gesture this is the first knuckle of the middle finger.
        ///For the Thumb gesture this is the thumb tip.
        ///For the Open Hand Back gesture this is the middle finger tip.
        ///
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to EControllerHand::Special_3
        ///for the left hand pointer and EControllerHand::Special_4 for the right hand pointer.
        ///
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param TransformSpace Get the transform relative to the world, tracking space, or the hand center.
        ///@param Pointer Output parameter containing the position and orientation.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (Transform, bool) GetHandPointer(EControllerHand Hand, EGestureTransformSpace TransformSpace)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetHandPointer_method.Invoke(Hand, TransformSpace);

        ///<summary>Transform of Keypoint 1.</summary>
        ///<remarks>
        ///Fist and OpenHandBack do not have this, so we return HandCenter.
        ///For the C and L gestures this is the thumb tip.
        ///For Finger, OK, and Pinch this is the first knuckle of the index finger.
        ///For Thumb this is the first knuckle of the thumb.
        ///
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to EControllerHand::Special_5
        ///for the left hand secondary and EControllerHand::Special_6 for the right hand secondary.
        ///
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param TransformSpace Get the transform relative to the world, tracking space, or the hand center.
        ///@param Secondary Output parameter containing the position and orientation.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (Transform, bool) GetHandSecondary(EControllerHand Hand, EGestureTransformSpace TransformSpace)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetHandSecondary_method.Invoke(Hand, TransformSpace);

        ///<summary>Gets the minimum gesture confidence used to filter out the detected static gesture.</summary>
        ///<remarks>
        ///@param Gesture The gesture to get the confidence threshold for.
        ///@return The gesture confidence threshold.
        ///</remarks>
        public static float GetStaticGestureConfidenceThreshold(EStaticGestures Gesture)  => 
            MagicLeapGesturesFunctionLibrary_methods.GetStaticGestureConfidenceThreshold_method.Invoke(Gesture);

        ///<summary>Enables and disables the gestures to be detected by the gesture recognition system.</summary>
        ///<remarks>
        ///@param StaticGesturesToActivate List of static gestures to be detected by the system.
        ///@param KeypointsFilterLevel Filtering for the keypoints and hand centers.
        ///@param GestureFilterLevel Filtering for the static gesture recognition.
        ///@param HandSwitchingFilterLevel Filtering for if the left or right hand is present.
        ///@return true if the configuration was set successfully.
        ///</remarks>
        public static bool SetConfiguration(byte StaticGesturesToActivate /*TODO: array TArray */, EGestureKeypointsFilterLevel KeypointsFilterLevel, EGestureRecognitionFilterLevel GestureFilterLevel, EGestureRecognitionFilterLevel HandSwitchingFilterLevel)  => 
            MagicLeapGesturesFunctionLibrary_methods.SetConfiguration_method.Invoke(StaticGesturesToActivate, KeypointsFilterLevel, GestureFilterLevel, HandSwitchingFilterLevel);

        ///<summary>Sets the minimum gesture confidence to filter out the detected static gesture.</summary>
        ///<remarks>
        ///@param Gesture The gesture to set the confidence threshold for.
        ///@param Confidence The gesture confidence threshold.
        ///</remarks>
        public static void SetStaticGestureConfidenceThreshold(EStaticGestures Gesture, float Confidence)  => 
            MagicLeapGesturesFunctionLibrary_methods.SetStaticGestureConfidenceThreshold_method.Invoke(Gesture, Confidence);
        static MagicLeapGesturesFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapGesturesFunctionLibrary");
        }
        internal unsafe MagicLeapGesturesFunctionLibrary_fields* MagicLeapGesturesFunctionLibrary_ptr => (MagicLeapGesturesFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapGesturesFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapGesturesFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapGesturesFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapGesturesFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
