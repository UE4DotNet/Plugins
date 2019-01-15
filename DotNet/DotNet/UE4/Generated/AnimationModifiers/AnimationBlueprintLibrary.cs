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
using UE4.AnimationModifiers.Native;
using UE4.Engine;

namespace UE4.AnimationModifiers {
    ///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
    public unsafe partial class AnimationBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Adds an Animation Notify Event to Notify track in the given Animation with the given Notify creation data</summary>
        public static AnimNotify AddAnimationNotifyEvent(AnimSequence AnimationSequence, Name NotifyTrackName, float StartTime, float Duration, SubclassOf<UObject> NotifyClass)  => 
            AnimationBlueprintLibrary_methods.AddAnimationNotifyEvent_method.Invoke(AnimationSequence, NotifyTrackName, StartTime, Duration, NotifyClass);

        ///<summary>Adds an the specific Animation Notify to the Animation Sequence (requires Notify's outer to be the Animation Sequence)</summary>
        public static void AddAnimationNotifyEventObject(AnimSequence AnimationSequence, float StartTime, AnimNotify Notify, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.AddAnimationNotifyEventObject_method.Invoke(AnimationSequence, StartTime, Notify, NotifyTrackName);

        ///<summary>Adds an Animation Notify Track to the Animation Sequence</summary>
        public static void AddAnimationNotifyTrack(AnimSequence AnimationSequence, Name NotifyTrackName, LinearColor TrackColor)  => 
            AnimationBlueprintLibrary_methods.AddAnimationNotifyTrack_method.Invoke(AnimationSequence, NotifyTrackName, TrackColor);

        ///<summary>Adds an Animation Sync Marker to Notify track in the given Animation with the corresponding Marker Name and Time</summary>
        public static void AddAnimationSyncMarker(AnimSequence AnimationSequence, Name MarkerName, float Time, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.AddAnimationSyncMarker_method.Invoke(AnimationSequence, MarkerName, Time, NotifyTrackName);

        ///<summary>Adds an Animation Curve by Type and Name to the given Animation Sequence</summary>
        public static void AddCurve(AnimSequence AnimationSequence, Name CurveName, ERawCurveTrackTypes CurveType, bool bMetaDataCurve)  => 
            AnimationBlueprintLibrary_methods.AddCurve_method.Invoke(AnimationSequence, CurveName, CurveType, bMetaDataCurve);

        ///<summary>Adds a Float Key to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddFloatCurveKey(AnimSequence AnimationSequence, Name CurveName, float Time, float Value)  => 
            AnimationBlueprintLibrary_methods.AddFloatCurveKey_method.Invoke(AnimationSequence, CurveName, Time, Value);

        ///<summary>Adds a multiple of Float Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddFloatCurveKeys(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Values /*TODO: array TArray */)  => 
            AnimationBlueprintLibrary_methods.AddFloatCurveKeys_method.Invoke(AnimationSequence, CurveName, Times, Values);

        ///<summary>Creates and Adds an instance of the specified MetaData Class to the given Animation Sequence</summary>
        public static void AddMetaData(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass, AnimMetaData MetaDataInstance)  => 
            AnimationBlueprintLibrary_methods.AddMetaData_method.Invoke(AnimationSequence, MetaDataClass, MetaDataInstance);

        ///<summary>Adds an instance of the specified MetaData Class to the given Animation Sequence (requires MetaDataObject's outer to be the Animation Sequence)</summary>
        public static void AddMetaDataObject(AnimSequence AnimationSequence, AnimMetaData MetaDataObject)  => 
            AnimationBlueprintLibrary_methods.AddMetaDataObject_method.Invoke(AnimationSequence, MetaDataObject);

        ///<summary>Adds a Transformation Key to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddTransformationCurveKey(AnimSequence AnimationSequence, Name CurveName, float Time, Transform Transform)  => 
            AnimationBlueprintLibrary_methods.AddTransformationCurveKey_method.Invoke(AnimationSequence, CurveName, Time, Transform);

        ///<summary>Adds a multiple of Transformation Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddTransformationCurveKeys(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Transforms /*TODO: array TArray */)  => 
            AnimationBlueprintLibrary_methods.AddTransformationCurveKeys_method.Invoke(AnimationSequence, CurveName, Times, Transforms);

        ///<summary>Adds a Vector Key to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddVectorCurveKey(AnimSequence AnimationSequence, Name CurveName, float Time, Vector Vector)  => 
            AnimationBlueprintLibrary_methods.AddVectorCurveKey_method.Invoke(AnimationSequence, CurveName, Time, Vector);

        ///<summary>Adds a multiple of Vector Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
        public static void AddVectorCurveKeys(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Vectors /*TODO: array TArray */)  => 
            AnimationBlueprintLibrary_methods.AddVectorCurveKeys_method.Invoke(AnimationSequence, CurveName, Times, Vectors);

        ///<summary>Adds a Virtual Bone between the Source and Target Bones to the given Animation Sequence</summary>
        public static Name AddVirtualBone(AnimSequence AnimationSequence, Name SourceBoneName, Name TargetBoneName)  => 
            AnimationBlueprintLibrary_methods.AddVirtualBone_method.Invoke(AnimationSequence, SourceBoneName, TargetBoneName);

        ///<summary>Checks whether or not the given Animation Sequences contains Meta Data Instance of the specified Meta Data Class</summary>
        public static bool ContainsMetaDataOfClass(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass)  => 
            AnimationBlueprintLibrary_methods.ContainsMetaDataOfClass_method.Invoke(AnimationSequence, MetaDataClass);

        ///<summary>Checks whether or not the given Bone Name exist on the Skeleton referenced by the given Animation Sequence</summary>
        public static bool DoesBoneNameExist(AnimSequence AnimationSequence, Name BoneName)  => 
            AnimationBlueprintLibrary_methods.DoesBoneNameExist_method.Invoke(AnimationSequence, BoneName);

        ///<summary>Checks whether or not the given Curve Name exist on the Skeleton referenced by the given Animation Sequence</summary>
        public static bool DoesCurveExist(AnimSequence AnimationSequence, Name CurveName, ERawCurveTrackTypes CurveType)  => 
            AnimationBlueprintLibrary_methods.DoesCurveExist_method.Invoke(AnimationSequence, CurveName, CurveType);

        ///<summary>Apply all the changes made to Bone Tracks to Finalize. This triggers recompression. Note that this is expensive, but will require to get correct compressed data</summary>
        public static void FinalizeBoneAnimation(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.FinalizeBoneAnimation_method.Invoke(AnimationSequence);

        ///<summary>Finds the Bone Path from the given Bone to the Root Bone</summary>
        public static IReadOnlyCollection<Name> FindBonePathToRoot(AnimSequence AnimationSequence, Name BoneName)  => 
            AnimationBlueprintLibrary_methods.FindBonePathToRoot_method.Invoke(AnimationSequence, BoneName);

        ///<summary>Retrieves the Additive Animation type for the given Animation Sequence</summary>
        public static byte GetAdditiveAnimationType(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAdditiveAnimationType_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the Additive Base Pose type for the given Animation Sequence</summary>
        public static byte GetAdditiveBasePoseType(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAdditiveBasePoseType_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the Animation Interpolation type for the given Animation Sequence</summary>
        public static EAnimInterpolationType GetAnimationInterpolationType(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationInterpolationType_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all Unique Animation Notify Events found within the given Animation Sequence</summary>
        public static IReadOnlyCollection<Name> GetAnimationNotifyEventNames(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationNotifyEventNames_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all Animation Notify Events found within the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimNotifyEvent> GetAnimationNotifyEvents(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationNotifyEvents_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all Animation Notify Events for the given Notify Track Name from the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimNotifyEvent> GetAnimationNotifyEventsForTrack(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.GetAnimationNotifyEventsForTrack_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>Retrieves all Unique Animation Notify Track Names found within the given Animation Sequence</summary>
        public static IReadOnlyCollection<Name> GetAnimationNotifyTrackNames(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationNotifyTrackNames_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all the Animation Sync Markers for the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimSyncMarker> GetAnimationSyncMarkers(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationSyncMarkers_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all Animation Sync Markers for the given Notify Track Name from the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimSyncMarker> GetAnimationSyncMarkersForTrack(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.GetAnimationSyncMarkersForTrack_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>Retrieves the Names of the individual ATracks for the given Animation Sequence</summary>
        public static IReadOnlyCollection<Name> GetAnimationTrackNames(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetAnimationTrackNames_method.Invoke(AnimationSequence);

        ///<summary>Returns the actual trigger time for a NotifyEvent</summary>
        public static float GetAnimNotifyEventTriggerTime(AnimNotifyEvent NotifyEvent)  => 
            AnimationBlueprintLibrary_methods.GetAnimNotifyEventTriggerTime_method.Invoke(NotifyEvent);

        ///<summary>Retrieves Bone Pose data for the given Bone Name at the specified Frame from the given Animation Sequence</summary>
        public static Transform GetBonePoseForFrame(AnimSequence AnimationSequence, Name BoneName, int Frame, bool bExtractRootMotion)  => 
            AnimationBlueprintLibrary_methods.GetBonePoseForFrame_method.Invoke(AnimationSequence, BoneName, Frame, bExtractRootMotion);

        ///<summary>Retrieves Bone Pose data for the given Bone Name at the specified Time from the given Animation Sequence</summary>
        public static Transform GetBonePoseForTime(AnimSequence AnimationSequence, Name BoneName, float Time, bool bExtractRootMotion)  => 
            AnimationBlueprintLibrary_methods.GetBonePoseForTime_method.Invoke(AnimationSequence, BoneName, Time, bExtractRootMotion);

        ///<summary>Retrieves Bone Pose data for the given Bone Names at the specified Frame from the given Animation Sequence</summary>
        public static IReadOnlyCollection<Transform> GetBonePosesForFrame(AnimSequence AnimationSequence, byte BoneNames /*TODO: array TArray */, int Frame, bool bExtractRootMotion, SkeletalMesh PreviewMesh)  => 
            AnimationBlueprintLibrary_methods.GetBonePosesForFrame_method.Invoke(AnimationSequence, BoneNames, Frame, bExtractRootMotion, PreviewMesh);

        ///<summary>Retrieves Bone Pose data for the given Bone Names at the specified Time from the given Animation Sequence</summary>
        public static IReadOnlyCollection<Transform> GetBonePosesForTime(AnimSequence AnimationSequence, byte BoneNames /*TODO: array TArray */, float Time, bool bExtractRootMotion, SkeletalMesh PreviewMesh)  => 
            AnimationBlueprintLibrary_methods.GetBonePosesForTime_method.Invoke(AnimationSequence, BoneNames, Time, bExtractRootMotion, PreviewMesh);

        ///<summary>Retrieves the Compression Scheme for the given Animation Sequence</summary>
        public static AnimCompress GetCompressionScheme(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetCompressionScheme_method.Invoke(AnimationSequence);

        ///<summary>Retrieves, a multiple of, Float Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
        public static (IReadOnlyCollection<float>, IReadOnlyCollection<float>) GetFloatKeys(AnimSequence AnimationSequence, Name CurveName)  => 
            AnimationBlueprintLibrary_methods.GetFloatKeys_method.Invoke(AnimationSequence, CurveName);

        ///<summary>Retrieves the Frame Index at the specified Time Value for the given Animation Sequence</summary>
        public static int GetFrameAtTime(AnimSequence AnimationSequence, float Time)  => 
            AnimationBlueprintLibrary_methods.GetFrameAtTime_method.Invoke(AnimationSequence, Time);

        ///<summary>Retrieves all Meta Data Instances from the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimMetaData> GetMetaData(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetMetaData_method.Invoke(AnimationSequence);

        ///<summary>Retrieves all Meta Data Instances from the given Animation Sequence</summary>
        public static IReadOnlyCollection<AnimMetaData> GetMetaDataOfClass(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass)  => 
            AnimationBlueprintLibrary_methods.GetMetaDataOfClass_method.Invoke(AnimationSequence, MetaDataClass);

        ///<summary>Retrieves the number of animation frames for the given Animation Sequence</summary>
        public static int GetNumFrames(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetNumFrames_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the (Play) Rate Scale of the given Animation Sequence</summary>
        public static float GetRateScale(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetRateScale_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the Raw Animation Data for the given Animation Track Name and Animation Sequence</summary>
        public static (IReadOnlyCollection<Vector>, IReadOnlyCollection<Quat>, IReadOnlyCollection<Vector>) GetRawTrackData(AnimSequence AnimationSequence, Name TrackName)  => 
            AnimationBlueprintLibrary_methods.GetRawTrackData_method.Invoke(AnimationSequence, TrackName);

        ///<summary>Retrieves the Raw Translation Animation Data for the given Animation Track Name and Animation Sequence</summary>
        public static IReadOnlyCollection<Vector> GetRawTrackPositionData(AnimSequence AnimationSequence, Name TrackName)  => 
            AnimationBlueprintLibrary_methods.GetRawTrackPositionData_method.Invoke(AnimationSequence, TrackName);

        ///<summary>Retrieves the Raw Rotation Animation Data for the given Animation Track Name and Animation Sequence</summary>
        public static IReadOnlyCollection<Quat> GetRawTrackRotationData(AnimSequence AnimationSequence, Name TrackName)  => 
            AnimationBlueprintLibrary_methods.GetRawTrackRotationData_method.Invoke(AnimationSequence, TrackName);

        ///<summary>Retrieves the Raw Scale Animation Data for the given Animation Track Name and Animation Sequence</summary>
        public static IReadOnlyCollection<Vector> GetRawTrackScaleData(AnimSequence AnimationSequence, Name TrackName)  => 
            AnimationBlueprintLibrary_methods.GetRawTrackScaleData_method.Invoke(AnimationSequence, TrackName);

        ///<summary>Retrieves the Root Motion Lock Type for the given Animation Sequence</summary>
        public static byte GetRootMotionLockType(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetRootMotionLockType_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the Length of the given Animation Sequence</summary>
        public static float GetSequenceLength(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetSequenceLength_method.Invoke(AnimationSequence);

        ///<summary>Retrieves the Time Value at the specified Frame Indexfor the given Animation Sequence</summary>
        public static float GetTimeAtFrame(AnimSequence AnimationSequence, int Frame)  => 
            AnimationBlueprintLibrary_methods.GetTimeAtFrame_method.Invoke(AnimationSequence, Frame);

        ///<summary>Retrieves, a multiple of, Transformation Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
        public static (IReadOnlyCollection<float>, IReadOnlyCollection<Transform>) GetTransformationKeys(AnimSequence AnimationSequence, Name CurveName)  => 
            AnimationBlueprintLibrary_methods.GetTransformationKeys_method.Invoke(AnimationSequence, CurveName);

        ///<summary>Retrieves all the Unique Names for the Animation Sync Markers contained by the given Animation Sequence</summary>
        public static IReadOnlyCollection<Name> GetUniqueMarkerNames(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.GetUniqueMarkerNames_method.Invoke(AnimationSequence);

        ///<summary>Retrieves, a multiple of, Vector Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
        public static (IReadOnlyCollection<float>, IReadOnlyCollection<Vector>) GetVectorKeys(AnimSequence AnimationSequence, Name CurveName)  => 
            AnimationBlueprintLibrary_methods.GetVectorKeys_method.Invoke(AnimationSequence, CurveName);

        ///<summary>Checks whether or not Root Motion is Enabled for the given Animation Sequence</summary>
        public static bool IsRootMotionEnabled(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.IsRootMotionEnabled_method.Invoke(AnimationSequence);

        ///<summary>Checks whether or not Root Motion locking is Forced for the given Animation Sequence</summary>
        public static bool IsRootMotionLockForced(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.IsRootMotionLockForced_method.Invoke(AnimationSequence);

        ///<summary>Checks whether or not the given Marker Name is a valid Animation Sync Marker Name</summary>
        public static bool IsValidAnimationSyncMarkerName(AnimSequence AnimationSequence, Name MarkerName)  => 
            AnimationBlueprintLibrary_methods.IsValidAnimationSyncMarkerName_method.Invoke(AnimationSequence, MarkerName);

        ///<summary>Checks whether or not the given Track Name is a valid Animation Notify Track in the Animation Sequence</summary>
        public static bool IsValidAnimNotifyTrackName(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.IsValidAnimNotifyTrackName_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>Checks whether or not the given Animation Track Name is contained within the Animation Sequence</summary>
        public static bool IsValidRawAnimationTrackName(AnimSequence AnimationSequence, Name TrackName)  => 
            AnimationBlueprintLibrary_methods.IsValidRawAnimationTrackName_method.Invoke(AnimationSequence, TrackName);

        ///<summary>Checks whether or not the given Time Value lies within the given Animation Sequence's Length</summary>
        public static bool IsValidTime(AnimSequence AnimationSequence, float Time)  => 
            AnimationBlueprintLibrary_methods.IsValidTime_method.Invoke(AnimationSequence, Time);

        ///<summary>Removes All Animation Notify Tracks from Animation Sequence</summary>
        public static void RemoveAllAnimationNotifyTracks(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllAnimationNotifyTracks_method.Invoke(AnimationSequence);

        ///<summary>Removes All Animation Sync Markers found within the Animation Sequence, and returns the number of removed instances</summary>
        public static void RemoveAllAnimationSyncMarkers(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllAnimationSyncMarkers_method.Invoke(AnimationSequence);

        ///<summary>Removes all Animation Bone Track Data from the given Animation Sequence</summary>
        public static void RemoveAllBoneAnimation(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllBoneAnimation_method.Invoke(AnimationSequence);

        ///<summary>Removes all Animation Curve Data from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)</summary>
        public static void RemoveAllCurveData(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllCurveData_method.Invoke(AnimationSequence);

        ///<summary>Removes all Meta Data from the given Animation Sequence</summary>
        public static void RemoveAllMetaData(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllMetaData_method.Invoke(AnimationSequence);

        ///<summary>Removes all Virtual Bones from the given Animation Sequence</summary>
        public static void RemoveAllVirtualBones(AnimSequence AnimationSequence)  => 
            AnimationBlueprintLibrary_methods.RemoveAllVirtualBones_method.Invoke(AnimationSequence);

        ///<summary>Removes Animation Notify Events found by Name within the Animation Sequence, and returns the number of removed name instances</summary>
        public static int RemoveAnimationNotifyEventsByName(AnimSequence AnimationSequence, Name NotifyName)  => 
            AnimationBlueprintLibrary_methods.RemoveAnimationNotifyEventsByName_method.Invoke(AnimationSequence, NotifyName);

        ///<summary>Removes Animation Notify Events found by Track within the Animation Sequence, and returns the number of removed name instances</summary>
        public static int RemoveAnimationNotifyEventsByTrack(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.RemoveAnimationNotifyEventsByTrack_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>Removes an Animation Notify Track from Animation Sequence by Name</summary>
        public static void RemoveAnimationNotifyTrack(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.RemoveAnimationNotifyTrack_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>Removes All Animation Sync Marker found within the Animation Sequence whose name matches MarkerName, and returns the number of removed instances</summary>
        public static int RemoveAnimationSyncMarkersByName(AnimSequence AnimationSequence, Name MarkerName)  => 
            AnimationBlueprintLibrary_methods.RemoveAnimationSyncMarkersByName_method.Invoke(AnimationSequence, MarkerName);

        ///<summary>Removes All Animation Sync Marker found within the Animation Sequence that belong to the specific Notify Track, and returns the number of removed instances</summary>
        public static int RemoveAnimationSyncMarkersByTrack(AnimSequence AnimationSequence, Name NotifyTrackName)  => 
            AnimationBlueprintLibrary_methods.RemoveAnimationSyncMarkersByTrack_method.Invoke(AnimationSequence, NotifyTrackName);

        ///<summary>
        ///Removes an Animation Curve by Name from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)
        ///    @
        ///</summary>
        ///<remarks>
        ///param AnimationSequence : AnimSequence
        ///    @param BoneName : Name of bone track user wants to remove
        ///    @param bIncludeChildren : true if user wants to include all children of BoneName
        ///@param bFinalize : If you set this to true, it will trigger compression. If you set bFinalize to be false, you'll have to manually trigger Finalize.
        ///</remarks>
        public static void RemoveBoneAnimation(AnimSequence AnimationSequence, Name BoneName, bool bIncludeChildren, bool bFinalize)  => 
            AnimationBlueprintLibrary_methods.RemoveBoneAnimation_method.Invoke(AnimationSequence, BoneName, bIncludeChildren, bFinalize);

        ///<summary>Removes an Animation Curve by Name from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)</summary>
        public static void RemoveCurve(AnimSequence AnimationSequence, Name CurveName, bool bRemoveNameFromSkeleton)  => 
            AnimationBlueprintLibrary_methods.RemoveCurve_method.Invoke(AnimationSequence, CurveName, bRemoveNameFromSkeleton);

        ///<summary>Removes the specified Meta Data Instance from the given Animation Sequence</summary>
        public static void RemoveMetaData(AnimSequence AnimationSequence, AnimMetaData MetaDataObject)  => 
            AnimationBlueprintLibrary_methods.RemoveMetaData_method.Invoke(AnimationSequence, MetaDataObject);

        ///<summary>Removes all Meta Data Instance of the specified Class from the given Animation Sequence</summary>
        public static void RemoveMetaDataOfClass(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass)  => 
            AnimationBlueprintLibrary_methods.RemoveMetaDataOfClass_method.Invoke(AnimationSequence, MetaDataClass);

        ///<summary>Removes a Virtual Bone with the specified Bone Name from the given Animation Sequence</summary>
        public static void RemoveVirtualBone(AnimSequence AnimationSequence, Name VirtualBoneName)  => 
            AnimationBlueprintLibrary_methods.RemoveVirtualBone_method.Invoke(AnimationSequence, VirtualBoneName);

        ///<summary>Removes Virtual Bones with the specified Bone Names from the given Animation Sequence</summary>
        public static void RemoveVirtualBones(AnimSequence AnimationSequence, byte VirtualBoneNames /*TODO: array TArray */)  => 
            AnimationBlueprintLibrary_methods.RemoveVirtualBones_method.Invoke(AnimationSequence, VirtualBoneNames);

        ///<summary>Replaces animation notifies in the specified Animation Sequence</summary>
        public static void ReplaceAnimNotifies(AnimSequenceBase AnimationSequence, SubclassOf<AnimNotify> OldNotifyClass, SubclassOf<AnimNotify> NewNotifyClass, byte OnNotifyReplaced /*TODO: delegate FOnNotifyReplaced */)  => 
            AnimationBlueprintLibrary_methods.ReplaceAnimNotifies_method.Invoke(AnimationSequence, OldNotifyClass, NewNotifyClass, OnNotifyReplaced);

        ///<summary>Replaces animation notifies in the specified Animation Sequence</summary>
        public static void ReplaceAnimNotifyStates(AnimSequenceBase AnimationSequence, SubclassOf<AnimNotifyState> OldNotifyClass, SubclassOf<AnimNotifyState> NewNotifyClass, byte OnNotifyStateReplaced /*TODO: delegate FOnNotifyStateReplaced */)  => 
            AnimationBlueprintLibrary_methods.ReplaceAnimNotifyStates_method.Invoke(AnimationSequence, OldNotifyClass, NewNotifyClass, OnNotifyStateReplaced);

        ///<summary>Sets the Additive Animation type for the given Animation Sequence</summary>
        public static void SetAdditiveAnimationType(AnimSequence AnimationSequence, byte AdditiveAnimationType)  => 
            AnimationBlueprintLibrary_methods.SetAdditiveAnimationType_method.Invoke(AnimationSequence, AdditiveAnimationType);

        ///<summary>Sets the Additive Base Pose type for the given Animation Sequence</summary>
        public static void SetAdditiveBasePoseType(AnimSequence AnimationSequence, byte AdditiveBasePoseType)  => 
            AnimationBlueprintLibrary_methods.SetAdditiveBasePoseType_method.Invoke(AnimationSequence, AdditiveBasePoseType);

        ///<summary>Sets the Animation Interpolation type for the given Animation Sequence</summary>
        public static void SetAnimationInterpolationType(AnimSequence AnimationSequence, EAnimInterpolationType InterpolationType)  => 
            AnimationBlueprintLibrary_methods.SetAnimationInterpolationType_method.Invoke(AnimationSequence, InterpolationType);

        ///<summary>Sets the Compression Scheme for the given Animation Sequence</summary>
        public static void SetCompressionScheme(AnimSequence AnimationSequence, AnimCompress CompressionScheme)  => 
            AnimationBlueprintLibrary_methods.SetCompressionScheme_method.Invoke(AnimationSequence, CompressionScheme);

        ///<summary>Sets whether or not Root Motion locking is Forced for the given Animation Sequence</summary>
        public static void SetIsRootMotionLockForced(AnimSequence AnimationSequence, bool bForced)  => 
            AnimationBlueprintLibrary_methods.SetIsRootMotionLockForced_method.Invoke(AnimationSequence, bForced);

        ///<summary>Sets the (Play) Rate Scale for the given Animation Sequence</summary>
        public static void SetRateScale(AnimSequence AnimationSequence, float RateScale)  => 
            AnimationBlueprintLibrary_methods.SetRateScale_method.Invoke(AnimationSequence, RateScale);

        ///<summary>Sets whether or not Root Motion is Enabled for the given Animation Sequence</summary>
        public static void SetRootMotionEnabled(AnimSequence AnimationSequence, bool bEnabled)  => 
            AnimationBlueprintLibrary_methods.SetRootMotionEnabled_method.Invoke(AnimationSequence, bEnabled);

        ///<summary>Sets the Root Motion Lock Type for the given Animation Sequence</summary>
        public static void SetRootMotionLockType(AnimSequence AnimationSequence, byte RootMotionLockType)  => 
            AnimationBlueprintLibrary_methods.SetRootMotionLockType_method.Invoke(AnimationSequence, RootMotionLockType);
        static AnimationBlueprintLibrary() {
            StaticClass = Main.GetClass("AnimationBlueprintLibrary");
        }
        internal unsafe AnimationBlueprintLibrary_fields* AnimationBlueprintLibrary_ptr => (AnimationBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationBlueprintLibrary(IntPtr p) => UObject.Make<AnimationBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
