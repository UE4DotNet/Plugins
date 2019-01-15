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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Anim Instance</summary>
    public unsafe partial class AnimInstance : UObject  {

        ///<summary>Executed when begin play is called on the owning component</summary>
        public event BlueprintBeginPlay_delegate BlueprintBeginPlay;
        public delegate void BlueprintBeginPlay_delegate();
        internal void on_BlueprintBeginPlay() =>
            BlueprintBeginPlay?.Invoke();


        ///<summary>Executed when the Animation is initialized</summary>
        public event BlueprintInitializeAnimation_delegate BlueprintInitializeAnimation;
        public delegate void BlueprintInitializeAnimation_delegate();
        internal void on_BlueprintInitializeAnimation() =>
            BlueprintInitializeAnimation?.Invoke();


        ///<summary>Executed after the Animation is evaluated</summary>
        public event BlueprintPostEvaluateAnimation_delegate BlueprintPostEvaluateAnimation;
        public delegate void BlueprintPostEvaluateAnimation_delegate();
        internal void on_BlueprintPostEvaluateAnimation() =>
            BlueprintPostEvaluateAnimation?.Invoke();


        ///<summary>Executed when the Animation is updated</summary>
        public event BlueprintUpdateAnimation_delegate BlueprintUpdateAnimation;
        public delegate void BlueprintUpdateAnimation_delegate(float DeltaTimeX);
        internal void on_BlueprintUpdateAnimation(float DeltaTimeX) =>
            BlueprintUpdateAnimation?.Invoke(DeltaTimeX);


        ///<summary>Returns degree of the angle betwee velocity and Rotation forward vector</summary>
        ///<remarks>The range of return will be from [-180, 180], and this can be used to feed blendspace directional value</remarks>
        public float CalculateDirection(Vector Velocity, Rotator BaseRotation)  => 
            AnimInstance_methods.CalculateDirection_method.Invoke(ObjPointer, Velocity, BaseRotation);

        ///<summary>Clears the current morph targets.</summary>
        public void ClearMorphTargets()  => 
            AnimInstance_methods.ClearMorphTargets_method.Invoke(ObjPointer);

        ///<summary>This returns last up-to-date list of active curve names</summary>
        public IReadOnlyCollection<Name> GetActiveCurveNames(EAnimCurveType CurveType)  => 
            AnimInstance_methods.GetActiveCurveNames_method.Invoke(ObjPointer, CurveType);

        ///<summary>This returns all curve names</summary>
        public IReadOnlyCollection<Name> GetAllCurveNames()  => 
            AnimInstance_methods.GetAllCurveNames_method.Invoke(ObjPointer);

        ///<summary>Get a current Active Montage in this AnimInstance.</summary>
        ///<remarks>Note that there might be multiple Active at the same time. This will only return the first active one it finds. *</remarks>
        public AnimMontage GetCurrentActiveMontage()  => 
            AnimInstance_methods.GetCurrentActiveMontage_method.Invoke(ObjPointer);

        ///<summary>Returns the name of a currently active state in a state machine.</summary>
        public Name GetCurrentStateName(int MachineIndex)  => 
            AnimInstance_methods.GetCurrentStateName_method.Invoke(ObjPointer, MachineIndex);

        ///<summary>Returns the value of a named curve.</summary>
        public float GetCurveValue(Name CurveName)  => 
            AnimInstance_methods.GetCurveValue_method.Invoke(ObjPointer, CurveName);

        ///<summary>Gets the length in seconds of the asset referenced in an asset player node</summary>
        public float GetInstanceAssetPlayerLength(int AssetPlayerIndex)  => 
            AnimInstance_methods.GetInstanceAssetPlayerLength_method.Invoke(ObjPointer, AssetPlayerIndex);

        ///<summary>Get the current accumulated time in seconds for an asset player node</summary>
        public float GetInstanceAssetPlayerTime(int AssetPlayerIndex)  => 
            AnimInstance_methods.GetInstanceAssetPlayerTime_method.Invoke(ObjPointer, AssetPlayerIndex);

        ///<summary>Get the current accumulated time as a fraction for an asset player node</summary>
        public float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)  => 
            AnimInstance_methods.GetInstanceAssetPlayerTimeFraction_method.Invoke(ObjPointer, AssetPlayerIndex);

        ///<summary>Get the time in seconds from the end of an animation in an asset player node</summary>
        public float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)  => 
            AnimInstance_methods.GetInstanceAssetPlayerTimeFromEnd_method.Invoke(ObjPointer, AssetPlayerIndex);

        ///<summary>Get the time as a fraction of the asset length of an animation in an asset player node</summary>
        public float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)  => 
            AnimInstance_methods.GetInstanceAssetPlayerTimeFromEndFraction_method.Invoke(ObjPointer, AssetPlayerIndex);

        ///<summary>Get the current elapsed time of a state within the specified state machine</summary>
        public float GetInstanceCurrentStateElapsedTime(int MachineIndex)  => 
            AnimInstance_methods.GetInstanceCurrentStateElapsedTime_method.Invoke(ObjPointer, MachineIndex);

        ///<summary>Get the blend weight of a specified state machine</summary>
        public float GetInstanceMachineWeight(int MachineIndex)  => 
            AnimInstance_methods.GetInstanceMachineWeight_method.Invoke(ObjPointer, MachineIndex);

        ///<summary>Get the blend weight of a specified state</summary>
        public float GetInstanceStateWeight(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetInstanceStateWeight_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get the crossfade duration of a specified transition</summary>
        public float GetInstanceTransitionCrossfadeDuration(int MachineIndex, int TransitionIndex)  => 
            AnimInstance_methods.GetInstanceTransitionCrossfadeDuration_method.Invoke(ObjPointer, MachineIndex, TransitionIndex);

        ///<summary>Get the elapsed time in seconds of a specified transition</summary>
        public float GetInstanceTransitionTimeElapsed(int MachineIndex, int TransitionIndex)  => 
            AnimInstance_methods.GetInstanceTransitionTimeElapsed_method.Invoke(ObjPointer, MachineIndex, TransitionIndex);

        ///<summary>Get the elapsed time as a fraction of the crossfade duration of a specified transition</summary>
        public float GetInstanceTransitionTimeElapsedFraction(int MachineIndex, int TransitionIndex)  => 
            AnimInstance_methods.GetInstanceTransitionTimeElapsedFraction_method.Invoke(ObjPointer, MachineIndex, TransitionIndex);

        ///<summary>Returns the owning actor of this AnimInstance</summary>
        public Actor GetOwningActor()  => 
            AnimInstance_methods.GetOwningActor_method.Invoke(ObjPointer);

        ///<summary>Returns the skeletal mesh component that has created this AnimInstance</summary>
        public SkeletalMeshComponent GetOwningComponent()  => 
            AnimInstance_methods.GetOwningComponent_method.Invoke(ObjPointer);

        ///<summary>Get the length in seconds of the most relevant animation in the source state</summary>
        public float GetRelevantAnimLength(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetRelevantAnimLength_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get the current accumulated time in seconds for the most relevant animation in the source state</summary>
        public float GetRelevantAnimTime(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetRelevantAnimTime_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get the current accumulated time as a fraction of the length of the most relevant animation in the source state</summary>
        public float GetRelevantAnimTimeFraction(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetRelevantAnimTimeFraction_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get the time remaining in seconds for the most relevant animation in the source state</summary>
        public float GetRelevantAnimTimeRemaining(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetRelevantAnimTimeRemaining_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get the time remaining as a fraction of the duration for the most relevant animation in the source state</summary>
        public float GetRelevantAnimTimeRemainingFraction(int MachineIndex, int StateIndex)  => 
            AnimInstance_methods.GetRelevantAnimTimeRemainingFraction_method.Invoke(ObjPointer, MachineIndex, StateIndex);

        ///<summary>Get Sync Group Position</summary>
        public MarkerSyncAnimPosition GetSyncGroupPosition(Name InSyncGroupName)  => 
            AnimInstance_methods.GetSyncGroupPosition_method.Invoke(ObjPointer, InSyncGroupName);

        ///<summary>--- AI communication end ---</summary>
        public (float, bool) GetTimeToClosestMarker(Name SyncGroup, Name MarkerName)  => 
            AnimInstance_methods.GetTimeToClosestMarker_method.Invoke(ObjPointer, SyncGroup, MarkerName);

        ///<summary>Has Marker Been Hit This Frame</summary>
        public bool HasMarkerBeenHitThisFrame(Name SyncGroup, Name MarkerName)  => 
            AnimInstance_methods.HasMarkerBeenHitThisFrame_method.Invoke(ObjPointer, SyncGroup, MarkerName);

        ///<summary>Returns true if any montage is playing currently. Doesn't mean it's active though, it could be blending out.</summary>
        public bool IsAnyMontagePlaying()  => 
            AnimInstance_methods.IsAnyMontagePlaying_method.Invoke(ObjPointer);

        ///<summary>Return true if it's playing the slot animation</summary>
        public bool IsPlayingSlotAnimation(AnimSequenceBase Asset, Name SlotNodeName)  => 
            AnimInstance_methods.IsPlayingSlotAnimation_method.Invoke(ObjPointer, Asset, SlotNodeName);

        ///<summary>Is Sync Group Between Markers</summary>
        public bool IsSyncGroupBetweenMarkers(Name InSyncGroupName, Name PreviousMarker, Name NextMarker, bool bRespectMarkerOrder)  => 
            AnimInstance_methods.IsSyncGroupBetweenMarkers_method.Invoke(ObjPointer, InSyncGroupName, PreviousMarker, NextMarker, bRespectMarkerOrder);

        ///<summary>
        ///locks indicated AI resources of animated pawn
        ///    DEPRECATED.
        ///</summary>
        ///<remarks>Use LockAIResourcesWithAnimation instead</remarks>
        public void LockAIResources(bool bLockMovement, bool LockAILogic)  => 
            AnimInstance_methods.LockAIResources_method.Invoke(ObjPointer, bLockMovement, LockAILogic);

        ///<summary>Get the current blend time of the Montage.</summary>
        ///<remarks>If Montage reference is NULL, it will return the current blend time on the first active Montage found.</remarks>
        public float Montage_GetBlendTime(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_GetBlendTime_method.Invoke(ObjPointer, Montage);

        ///<summary>Returns the name of the current animation montage section.</summary>
        public Name Montage_GetCurrentSection(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_GetCurrentSection_method.Invoke(ObjPointer, Montage);

        ///<summary>return true if Montage is not currently active. (not valid or blending out)</summary>
        public bool Montage_GetIsStopped(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_GetIsStopped_method.Invoke(ObjPointer, Montage);

        ///<summary>Get PlayRate for Montage.</summary>
        ///<remarks>
        ///If Montage reference is NULL, PlayRate for any Active Montage will be returned.
        ///      If Montage is not playing, 0 is returned.
        ///</remarks>
        public float Montage_GetPlayRate(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_GetPlayRate_method.Invoke(ObjPointer, Montage);

        ///<summary>Get Current Montage Position</summary>
        public float Montage_GetPosition(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_GetPosition_method.Invoke(ObjPointer, Montage);

        ///<summary>Returns true if the animation montage is active. If the Montage reference is NULL, it will return true if any Montage is active.</summary>
        public bool Montage_IsActive(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_IsActive_method.Invoke(ObjPointer, Montage);

        ///<summary>Returns true if the animation montage is currently active and playing.</summary>
        ///<remarks>If reference is NULL, it will return true is ANY montage is currently active and playing.</remarks>
        public bool Montage_IsPlaying(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_IsPlaying_method.Invoke(ObjPointer, Montage);

        ///<summary>Makes a montage jump to a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
        public void Montage_JumpToSection(Name SectionName, AnimMontage Montage)  => 
            AnimInstance_methods.Montage_JumpToSection_method.Invoke(ObjPointer, SectionName, Montage);

        ///<summary>Makes a montage jump to the end of a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
        public void Montage_JumpToSectionsEnd(Name SectionName, AnimMontage Montage)  => 
            AnimInstance_methods.Montage_JumpToSectionsEnd_method.Invoke(ObjPointer, SectionName, Montage);

        ///<summary>Pauses the animation montage. If reference is NULL, it will pause ALL active montages.</summary>
        public void Montage_Pause(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_Pause_method.Invoke(ObjPointer, Montage);

        ///<summary>Plays an animation montage. Returns the length of the animation montage in seconds. Returns 0.f if failed to play.</summary>
        public float Montage_Play(AnimMontage MontageToPlay, float InPlayRate, EMontagePlayReturnType ReturnValueType, float InTimeToStartMontageAt, bool bStopAllMontages)  => 
            AnimInstance_methods.Montage_Play_method.Invoke(ObjPointer, MontageToPlay, InPlayRate, ReturnValueType, InTimeToStartMontageAt, bStopAllMontages);

        ///<summary>Resumes a paused animation montage. If reference is NULL, it will resume ALL active montages.</summary>
        public void Montage_Resume(AnimMontage Montage)  => 
            AnimInstance_methods.Montage_Resume_method.Invoke(ObjPointer, Montage);

        ///<summary>
        ///Relink new next section AFTER SectionNameToChange in run-time
        ///    You can link section order the way you like in editor, but in run-time if you'd like to change it dynamically,
        ///    use this function to relink the next section
        ///    For example, you can have Start->Loop->Loop->Loop.
        ///</summary>
        ///<remarks>
        ///... but when you want it to end, you can relink
        ///    next section of Loop to be End to finish the montage, in which case, it stops looping by Loop->End.
        ///
        ///@param SectionNameToChange : This should be the name of the Montage Section after which you want to insert a new next section
        ///@param NextSection   : new next section
        ///</remarks>
        public void Montage_SetNextSection(Name SectionNameToChange, Name NextSection, AnimMontage Montage)  => 
            AnimInstance_methods.Montage_SetNextSection_method.Invoke(ObjPointer, SectionNameToChange, NextSection, Montage);

        ///<summary>Change AnimMontage play rate. NewPlayRate = 1.0 is the default playback rate.</summary>
        public void Montage_SetPlayRate(AnimMontage Montage, float NewPlayRate)  => 
            AnimInstance_methods.Montage_SetPlayRate_method.Invoke(ObjPointer, Montage, NewPlayRate);

        ///<summary>Set position.</summary>
        public void Montage_SetPosition(AnimMontage Montage, float NewPosition)  => 
            AnimInstance_methods.Montage_SetPosition_method.Invoke(ObjPointer, Montage, NewPosition);

        ///<summary>Stops the animation montage. If reference is NULL, it will stop ALL active montages.</summary>
        public void Montage_Stop(float InBlendOutTime, AnimMontage Montage)  => 
            AnimInstance_methods.Montage_Stop_method.Invoke(ObjPointer, InBlendOutTime, Montage);

        ///<summary>Play Slot Animation</summary>
        public float PlaySlotAnimation(AnimSequenceBase Asset, Name SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount)  => 
            AnimInstance_methods.PlaySlotAnimation_method.Invoke(ObjPointer, Asset, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount);

        ///<summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
        public AnimMontage PlaySlotAnimationAsDynamicMontage(AnimSequenceBase Asset, Name SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)  => 
            AnimInstance_methods.PlaySlotAnimationAsDynamicMontage_method.Invoke(ObjPointer, Asset, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount, BlendOutTriggerTime, InTimeToStartMontageAt);

        ///<summary>Reset any dynamics running simulation-style updates (e.g. on teleport, time skip etc.)</summary>
        public void ResetDynamics(ETeleportType InTeleportType)  => 
            AnimInstance_methods.ResetDynamics_method.Invoke(ObjPointer, InTeleportType);

        ///<summary>Takes a snapshot of the current skeletal mesh component pose & saves it internally.</summary>
        ///<remarks>
        ///This snapshot can then be retrieved by name in the animation blueprint for blending.
        ///The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1 and then used it at LOD0 any bones not in LOD1 will use the reference pose
        ///</remarks>
        public void SavePoseSnapshot(Name SnapshotName)  => 
            AnimInstance_methods.SavePoseSnapshot_method.Invoke(ObjPointer, SnapshotName);

        ///<summary>Sets a morph target to a certain weight.</summary>
        public void SetMorphTarget(Name MorphTargetName, float Value)  => 
            AnimInstance_methods.SetMorphTarget_method.Invoke(ObjPointer, MorphTargetName, Value);

        ///<summary>Set RootMotionMode</summary>
        public void SetRootMotionMode(byte Value)  => 
            AnimInstance_methods.SetRootMotionMode_method.Invoke(ObjPointer, Value);

        ///<summary>Takes a snapshot of the current skeletal mesh component pose and saves it to the specified snapshot.</summary>
        ///<remarks>
        ///The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1
        ///and then used it at LOD0 any bones not in LOD1 will use the reference pose
        ///</remarks>
        public void SnapshotPose(PoseSnapshot Snapshot)  => 
            AnimInstance_methods.SnapshotPose_method.Invoke(ObjPointer, Snapshot);

        ///<summary>Stops currently playing slot animation slot or all</summary>
        public void StopSlotAnimation(float InBlendOutTime, Name SlotNodeName)  => 
            AnimInstance_methods.StopSlotAnimation_method.Invoke(ObjPointer, InBlendOutTime, SlotNodeName);

        ///<summary>kismet event functions</summary>
        public Pawn TryGetPawnOwner()  => 
            AnimInstance_methods.TryGetPawnOwner_method.Invoke(ObjPointer);

        ///<summary>unlocks indicated AI resources of animated pawn.</summary>
        ///<remarks>
        ///Will unlock only animation-locked resources.
        ///    DEPRECATED. Use UnlockAIResourcesWithAnimation instead
        ///</remarks>
        public void UnlockAIResources(bool bUnlockMovement, bool UnlockAILogic)  => 
            AnimInstance_methods.UnlockAIResources_method.Invoke(ObjPointer, bUnlockMovement, UnlockAILogic);
        ///<summary>This is used to extract animation. If Mesh exists, this will be overwritten by Mesh->Skeleton</summary>
        public unsafe Skeleton CurrentSkeleton {
            get {return AnimInstance_ptr->CurrentSkeleton;}
            set {AnimInstance_ptr->CurrentSkeleton = value;}
        }
        ///<summary>Sets where this blueprint pulls Root Motion from</summary>
        public unsafe byte RootMotionMode {
            get {return AnimInstance_ptr->RootMotionMode;}
            set {AnimInstance_ptr->RootMotionMode = value;}
        }
        public bool bUseMultiThreadedAnimationUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMultiThreadedAnimationUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMultiThreadedAnimationUpdate", value); }
        }
        public bool bUsingCopyPoseFromMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bUsingCopyPoseFromMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsingCopyPoseFromMesh", value); }
        }
        public bool bQueueMontageEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bQueueMontageEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bQueueMontageEvents", value); }
        }
         //TODO: multicast delegate FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut
         //TODO: multicast delegate FOnMontageStartedMCDelegate OnMontageStarted
         //TODO: multicast delegate FOnMontageEndedMCDelegate OnMontageEnded
         //TODO: multicast delegate FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded
        ///<summary>Name of Class to do Post Compile Validation.</summary>
        ///<remarks>See Class UAnimBlueprintPostCompileValidation.</remarks>
        public unsafe SoftClassPath PostCompileValidationClassName {
            get {return AnimInstance_ptr->PostCompileValidationClassName;}
            set {AnimInstance_ptr->PostCompileValidationClassName = value;}
        }
        ///<summary>Animation Notifies that has been triggered in the latest tick *</summary>
        public unsafe AnimNotifyQueue NotifyQueue {
            get {return AnimInstance_ptr->NotifyQueue;}
            set {AnimInstance_ptr->NotifyQueue = value;}
        }
         //TODO: array not UObject TArray ActiveAnimNotifyState
        static AnimInstance() {
            StaticClass = Main.GetClass("AnimInstance");
            AnimInstance_events.BlueprintBeginPlay_event.Setup();
            AnimInstance_events.BlueprintInitializeAnimation_event.Setup();
            AnimInstance_events.BlueprintPostEvaluateAnimation_event.Setup();
            AnimInstance_events.BlueprintUpdateAnimation_event.Setup();
        }
        internal unsafe AnimInstance_fields* AnimInstance_ptr => (AnimInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimInstance(IntPtr p) => UObject.Make<AnimInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
