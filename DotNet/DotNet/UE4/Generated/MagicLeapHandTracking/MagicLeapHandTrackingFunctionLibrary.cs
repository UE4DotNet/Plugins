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
using UE4.MagicLeapHandTracking.Native;
using UE4.InputCore;
using UE4.LiveLinkInterface;
using UE4.Engine;

namespace UE4.MagicLeapHandTracking {
    ///<summary>Magic Leap Hand Tracking Function Library</summary>
    public unsafe partial class MagicLeapHandTrackingFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Gets the list of static and dynamic gestures currently set to be identified by the gesture recognition system.</summary>
        ///<remarks>
        ///@param StaticHandTrackingToActivate Output parameter to list the static gestures that can be detected by the system.
        ///@param KeypointsFilterLevel Filtering for the keypoints and hand centers.
        ///@param GestureFilterLevel Filtering for the static gesture recognition.
        ///@param HandSwitchingFilterLevel Filtering for if the left or right hand is present.
        ///@return true if the output params were populated with a valid value, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<EHandTrackingGesture>, EHandTrackingKeypointFilterLevel, EHandTrackingGestureFilterLevel, EHandTrackingGestureFilterLevel, bool, bool) GetConfiguration()  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetConfiguration_method.Invoke();

        ///<summary>The current gesture being performed by the given hand.</summary>
        ///<remarks>
        ///@param Hand Hand to query the gesture for. Only Left and Right hand are supported.
        ///@param Gesture Output parameter containing the given hand's gesture, or NoHand if there isn't one or the system isnt working now.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (EHandTrackingGesture, bool) GetCurrentGesture(EControllerHand Hand)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetCurrentGesture_method.Invoke(Hand);

        ///<summary>The confidence level of the current gesture being performed by the given hand.</summary>
        ///<remarks>
        ///Value is between [0, 1], 0 is low, 1 is high degree of confidence. For a NoHand, the confidence is always set to 1.
        ///
        ///@param Hand Hand to query the gesture confidence value for. Only Left and Right hand are supported.
        ///@param Confidence Output parameter containing the confidence value for the given hand's gesture.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (float, bool) GetCurrentGestureConfidence(EControllerHand Hand)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetCurrentGestureConfidence_method.Invoke(Hand);

        ///<summary>List of keypoints detected on the given hand.</summary>
        ///<remarks>
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to the following.
        ///Special_3 - Left Index Finger Tip
        ///Special_5 - Left Thumb Tip
        ///Special_4 - Right Index Finger Tip
        ///Special_6 - Right Thumb Tip
        ///
        ///@param Hand Hand to query the keypoints for. Only Left and Right hand are supported.
        ///@param Keypoints Output parameter containing transforms of the keypoints detected on the given hand.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Transform>, bool) GetGestureKeypoints(EControllerHand Hand)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetGestureKeypoints_method.Invoke(Hand);

        ///<summary>Get Transform for a point on the hand.</summary>
        ///<remarks>
        ///@param Hand
        ///@param Keypoint the specific joint or wrist point to fetch.
        ///@param Transform Output parameter to write the data to.
        ///@param TransformSpace Get the transform relative to the world, hand center, or tracking space.
        ///@return true if the output param was populated with a valid value, false means that is is either unchanged or populated with a stale value.
        ///</remarks>
        public static (Transform, bool) GetGestureKeypointTransform(EControllerHand Hand, EHandTrackingKeypoint Keypoint, EGestureTransformSpace TransformSpace)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetGestureKeypointTransform_method.Invoke(Hand, Keypoint, TransformSpace);

        ///<summary>Transform of the center of the hand.</summary>
        ///<remarks>
        ///Approximately the center of the palm.
        ///
        ///Note that this returns a transform in world space.
        ///
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param HandCenter Output parameter containing the position and orientation of the given hand.
        ///@return true if the output param was populated with a valid value, false means that is is either unchanged or populated with a stale value.
        ///</remarks>
        public static (Transform, bool) GetHandCenter(EControllerHand Hand)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetHandCenter_method.Invoke(Hand);

        ///<summary>Normalized position of the center of the given hand.</summary>
        ///<remarks>
        ///This can be used to detect and warn the users that the hand is out of the gesture detection frame.
        ///
        ///@param Hand Hand to query the normalized hand center position for. Only Left and Right hand are supported.
        ///@param HandCenterNormalized Output paramter containing the normalized position of the given hand.
        ///@return true if the output param was populated with a valid value, false otherwise.
        ///</remarks>
        public static (Vector, bool) GetHandCenterNormalized(EControllerHand Hand)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetHandCenterNormalized_method.Invoke(Hand);

        ///<summary>Transform of the Index Finger Tip.</summary>
        ///<remarks>
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param TransformSpace Get the transform relative to the world, hand center, or tracking space.
        ///@param Pointer Output parameter containing the position and orientation.
        ///@return true if the output param was populated with a valid value, false means that is is either unchanged or populated with a stale value.
        ///</remarks>
        public static (Transform, bool) GetHandIndexFingerTip(EControllerHand Hand, EGestureTransformSpace TransformSpace)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetHandIndexFingerTip_method.Invoke(Hand, TransformSpace);

        ///<summary>Transform of Thumb Tip.</summary>
        ///<remarks>
        ///Note that this returns a transform in the Tracking space. To get the transform in Unreal's
        ///world space, use the MotioController component as a child of the XRPawn with hand set to EControllerHand::Special_5
        ///for the left hand secondary and EControllerHand::Special_6 for the right hand secondary.
        ///
        ///@param Hand Hand to query the hand center transform for. Only Left and Right hand are supported.
        ///@param TransformSpace Get the transform relative to the world, hand center, or tracking space.
        ///@param Secondary Output parameter containing the position and orientation.
        ///@return true if the output param was populated with a valid value, false means that is is either unchanged or populated with a stale value.
        ///</remarks>
        public static (Transform, bool) GetHandThumbTip(EControllerHand Hand, EGestureTransformSpace TransformSpace)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetHandThumbTip_method.Invoke(Hand, TransformSpace);

        ///<summary>Get a LiveLinkSourceHandle for magic leap hand tracking.</summary>
        ///<remarks>
        ///@param SourceHandle Output parameter SourceHandle that will be filled in.
        ///@return true if a LiveLink Source was assigned.
        ///</remarks>
        public static (LiveLinkSourceHandle, bool) GetMagicLeapHandTrackingLiveLinkSource()  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetMagicLeapHandTrackingLiveLinkSource_method.Invoke();

        ///<summary>Gets the minimum gesture confidence used to filter out the detected static gesture.</summary>
        ///<remarks>
        ///@param Gesture The gesture to get the confidence threshold for.
        ///@return The gesture confidence threshold.
        ///</remarks>
        public static float GetStaticGestureConfidenceThreshold(EHandTrackingGesture Gesture)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.GetStaticGestureConfidenceThreshold_method.Invoke(Gesture);

        ///<summary>Enables and disables the gestures to be detected by the gesture recognition system.</summary>
        ///<remarks>
        ///@param StaticHandTrackingToActivate List of static gestures to be detected by the system.
        ///@param KeypointsFilterLevel Filtering for the keypoints and hand centers.
        ///@param GestureFilterLevel Filtering for the static gesture recognition.
        ///@param HandSwitchingFilterLevel Filtering for if the left or right hand is present.
        ///@return true if the configuration was set successfully.
        ///</remarks>
        public static bool SetConfiguration(byte StaticGesturesToActivate /*TODO: array TArray */, EHandTrackingKeypointFilterLevel KeypointsFilterLevel, EHandTrackingGestureFilterLevel GestureFilterLevel, EHandTrackingGestureFilterLevel HandSwitchingFilterLevel, bool bTrackingEnabled)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.SetConfiguration_method.Invoke(StaticGesturesToActivate, KeypointsFilterLevel, GestureFilterLevel, HandSwitchingFilterLevel, bTrackingEnabled);

        ///<summary>Sets the minimum gesture confidence to filter out the detected static gesture.</summary>
        ///<remarks>
        ///@param Gesture The gesture to set the confidence threshold for.
        ///@param Confidence The gesture confidence threshold.
        ///</remarks>
        public static void SetStaticGestureConfidenceThreshold(EHandTrackingGesture Gesture, float Confidence)  => 
            MagicLeapHandTrackingFunctionLibrary_methods.SetStaticGestureConfidenceThreshold_method.Invoke(Gesture, Confidence);
        static MagicLeapHandTrackingFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapHandTrackingFunctionLibrary");
        }
        internal unsafe MagicLeapHandTrackingFunctionLibrary_fields* MagicLeapHandTrackingFunctionLibrary_ptr => (MagicLeapHandTrackingFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapHandTrackingFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapHandTrackingFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapHandTrackingFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapHandTrackingFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
