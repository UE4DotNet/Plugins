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
    [StructLayout( LayoutKind.Explicit, Size=944 )]
    internal unsafe struct AnimInstance_fields {
        [FieldOffset(56)]  public IntPtr  CurrentSkeleton;
        [FieldOffset(64)] public byte RootMotionMode;
        [FieldOffset(72)] public bool bUseMultiThreadedAnimationUpdate;
        [FieldOffset(72)] public bool bUsingCopyPoseFromMesh;
        [FieldOffset(72)] public bool bQueueMontageEvents;
        [FieldOffset(80)] byte OnMontageBlendingOut; //TODO: multicast delegate FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut
        [FieldOffset(96)] byte OnMontageStarted; //TODO: multicast delegate FOnMontageStartedMCDelegate OnMontageStarted
        [FieldOffset(112)] byte OnMontageEnded; //TODO: multicast delegate FOnMontageEndedMCDelegate OnMontageEnded
        [FieldOffset(128)] byte OnAllMontageInstancesEnded; //TODO: multicast delegate FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded
        [FieldOffset(272)] public SoftClassPath PostCompileValidationClassName;
        [FieldOffset(304)] public AnimNotifyQueue NotifyQueue;
        [FieldOffset(416)] public NativeArray ActiveAnimNotifyState;
    }
    internal unsafe struct AnimInstance_methods {
        internal struct CalculateDirection_method {
            static internal IntPtr CalculateDirection_ptr;
            static CalculateDirection_method() {
                CalculateDirection_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "CalculateDirection");
            }

            internal static unsafe float Invoke(IntPtr obj, Vector Velocity, Rotator BaseRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Velocity;
                *((Rotator*)(b+12)) = BaseRotation;
                Main.GetProcessEvent(obj, CalculateDirection_ptr, new IntPtr(p)); ;
                return *((float*)(b+24));
            }
        }
        internal struct ClearMorphTargets_method {
            static internal IntPtr ClearMorphTargets_ptr;
            static ClearMorphTargets_method() {
                ClearMorphTargets_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "ClearMorphTargets");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMorphTargets_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActiveCurveNames_method {
            static internal IntPtr GetActiveCurveNames_ptr;
            static GetActiveCurveNames_method() {
                GetActiveCurveNames_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetActiveCurveNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj, EAnimCurveType CurveType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)CurveType;
                Main.GetProcessEvent(obj, GetActiveCurveNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
        internal struct GetAllCurveNames_method {
            static internal IntPtr GetAllCurveNames_ptr;
            static GetAllCurveNames_method() {
                GetAllCurveNames_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetAllCurveNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllCurveNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNames
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetCurrentActiveMontage_method {
            static internal IntPtr GetCurrentActiveMontage_ptr;
            static GetCurrentActiveMontage_method() {
                GetCurrentActiveMontage_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetCurrentActiveMontage");
            }

            internal static unsafe AnimMontage Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentActiveMontage_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetCurrentStateName_method {
            static internal IntPtr GetCurrentStateName_ptr;
            static GetCurrentStateName_method() {
                GetCurrentStateName_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetCurrentStateName");
            }

            internal static unsafe Name Invoke(IntPtr obj, int MachineIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                Main.GetProcessEvent(obj, GetCurrentStateName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+4));
            }
        }
        internal struct GetCurveValue_method {
            static internal IntPtr GetCurveValue_ptr;
            static GetCurveValue_method() {
                GetCurveValue_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetCurveValue");
            }

            internal static unsafe float Invoke(IntPtr obj, Name CurveName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = CurveName;
                Main.GetProcessEvent(obj, GetCurveValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetInstanceAssetPlayerLength_method {
            static internal IntPtr GetInstanceAssetPlayerLength_ptr;
            static GetInstanceAssetPlayerLength_method() {
                GetInstanceAssetPlayerLength_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceAssetPlayerLength");
            }

            internal static unsafe float Invoke(IntPtr obj, int AssetPlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AssetPlayerIndex;
                Main.GetProcessEvent(obj, GetInstanceAssetPlayerLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceAssetPlayerTime_method {
            static internal IntPtr GetInstanceAssetPlayerTime_ptr;
            static GetInstanceAssetPlayerTime_method() {
                GetInstanceAssetPlayerTime_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceAssetPlayerTime");
            }

            internal static unsafe float Invoke(IntPtr obj, int AssetPlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AssetPlayerIndex;
                Main.GetProcessEvent(obj, GetInstanceAssetPlayerTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceAssetPlayerTimeFraction_method {
            static internal IntPtr GetInstanceAssetPlayerTimeFraction_ptr;
            static GetInstanceAssetPlayerTimeFraction_method() {
                GetInstanceAssetPlayerTimeFraction_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceAssetPlayerTimeFraction");
            }

            internal static unsafe float Invoke(IntPtr obj, int AssetPlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AssetPlayerIndex;
                Main.GetProcessEvent(obj, GetInstanceAssetPlayerTimeFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceAssetPlayerTimeFromEnd_method {
            static internal IntPtr GetInstanceAssetPlayerTimeFromEnd_ptr;
            static GetInstanceAssetPlayerTimeFromEnd_method() {
                GetInstanceAssetPlayerTimeFromEnd_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceAssetPlayerTimeFromEnd");
            }

            internal static unsafe float Invoke(IntPtr obj, int AssetPlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AssetPlayerIndex;
                Main.GetProcessEvent(obj, GetInstanceAssetPlayerTimeFromEnd_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceAssetPlayerTimeFromEndFraction_method {
            static internal IntPtr GetInstanceAssetPlayerTimeFromEndFraction_ptr;
            static GetInstanceAssetPlayerTimeFromEndFraction_method() {
                GetInstanceAssetPlayerTimeFromEndFraction_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceAssetPlayerTimeFromEndFraction");
            }

            internal static unsafe float Invoke(IntPtr obj, int AssetPlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AssetPlayerIndex;
                Main.GetProcessEvent(obj, GetInstanceAssetPlayerTimeFromEndFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceCurrentStateElapsedTime_method {
            static internal IntPtr GetInstanceCurrentStateElapsedTime_ptr;
            static GetInstanceCurrentStateElapsedTime_method() {
                GetInstanceCurrentStateElapsedTime_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceCurrentStateElapsedTime");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                Main.GetProcessEvent(obj, GetInstanceCurrentStateElapsedTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceMachineWeight_method {
            static internal IntPtr GetInstanceMachineWeight_ptr;
            static GetInstanceMachineWeight_method() {
                GetInstanceMachineWeight_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceMachineWeight");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                Main.GetProcessEvent(obj, GetInstanceMachineWeight_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInstanceStateWeight_method {
            static internal IntPtr GetInstanceStateWeight_ptr;
            static GetInstanceStateWeight_method() {
                GetInstanceStateWeight_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceStateWeight");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetInstanceStateWeight_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetInstanceTransitionCrossfadeDuration_method {
            static internal IntPtr GetInstanceTransitionCrossfadeDuration_ptr;
            static GetInstanceTransitionCrossfadeDuration_method() {
                GetInstanceTransitionCrossfadeDuration_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceTransitionCrossfadeDuration");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int TransitionIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = TransitionIndex;
                Main.GetProcessEvent(obj, GetInstanceTransitionCrossfadeDuration_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetInstanceTransitionTimeElapsed_method {
            static internal IntPtr GetInstanceTransitionTimeElapsed_ptr;
            static GetInstanceTransitionTimeElapsed_method() {
                GetInstanceTransitionTimeElapsed_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceTransitionTimeElapsed");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int TransitionIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = TransitionIndex;
                Main.GetProcessEvent(obj, GetInstanceTransitionTimeElapsed_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetInstanceTransitionTimeElapsedFraction_method {
            static internal IntPtr GetInstanceTransitionTimeElapsedFraction_ptr;
            static GetInstanceTransitionTimeElapsedFraction_method() {
                GetInstanceTransitionTimeElapsedFraction_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetInstanceTransitionTimeElapsedFraction");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int TransitionIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = TransitionIndex;
                Main.GetProcessEvent(obj, GetInstanceTransitionTimeElapsedFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetOwningActor_method {
            static internal IntPtr GetOwningActor_ptr;
            static GetOwningActor_method() {
                GetOwningActor_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetOwningActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetOwningComponent_method {
            static internal IntPtr GetOwningComponent_ptr;
            static GetOwningComponent_method() {
                GetOwningComponent_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetOwningComponent");
            }

            internal static unsafe SkeletalMeshComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetRelevantAnimLength_method {
            static internal IntPtr GetRelevantAnimLength_ptr;
            static GetRelevantAnimLength_method() {
                GetRelevantAnimLength_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetRelevantAnimLength");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetRelevantAnimLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRelevantAnimTime_method {
            static internal IntPtr GetRelevantAnimTime_ptr;
            static GetRelevantAnimTime_method() {
                GetRelevantAnimTime_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetRelevantAnimTime");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetRelevantAnimTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRelevantAnimTimeFraction_method {
            static internal IntPtr GetRelevantAnimTimeFraction_ptr;
            static GetRelevantAnimTimeFraction_method() {
                GetRelevantAnimTimeFraction_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetRelevantAnimTimeFraction");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetRelevantAnimTimeFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRelevantAnimTimeRemaining_method {
            static internal IntPtr GetRelevantAnimTimeRemaining_ptr;
            static GetRelevantAnimTimeRemaining_method() {
                GetRelevantAnimTimeRemaining_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetRelevantAnimTimeRemaining");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetRelevantAnimTimeRemaining_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRelevantAnimTimeRemainingFraction_method {
            static internal IntPtr GetRelevantAnimTimeRemainingFraction_ptr;
            static GetRelevantAnimTimeRemainingFraction_method() {
                GetRelevantAnimTimeRemainingFraction_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetRelevantAnimTimeRemainingFraction");
            }

            internal static unsafe float Invoke(IntPtr obj, int MachineIndex, int StateIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MachineIndex;
                *((int*)(b+4)) = StateIndex;
                Main.GetProcessEvent(obj, GetRelevantAnimTimeRemainingFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetSyncGroupPosition_method {
            static internal IntPtr GetSyncGroupPosition_ptr;
            static GetSyncGroupPosition_method() {
                GetSyncGroupPosition_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetSyncGroupPosition");
            }

            internal static unsafe MarkerSyncAnimPosition Invoke(IntPtr obj, Name InSyncGroupName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSyncGroupName;
                Main.GetProcessEvent(obj, GetSyncGroupPosition_ptr, new IntPtr(p)); ;
                return *((MarkerSyncAnimPosition*)(b+12));
            }
        }
        internal struct GetTimeToClosestMarker_method {
            static internal IntPtr GetTimeToClosestMarker_ptr;
            static GetTimeToClosestMarker_method() {
                GetTimeToClosestMarker_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "GetTimeToClosestMarker");
            }

            internal static unsafe (float, bool) Invoke(IntPtr obj, Name SyncGroup, Name MarkerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SyncGroup;
                *((Name*)(b+12)) = MarkerName;
                Main.GetProcessEvent(obj, GetTimeToClosestMarker_ptr, new IntPtr(p)); ;
                return (*((float*)(b+24)),*((bool*)(b+28)));
            }
        }
        internal struct HasMarkerBeenHitThisFrame_method {
            static internal IntPtr HasMarkerBeenHitThisFrame_ptr;
            static HasMarkerBeenHitThisFrame_method() {
                HasMarkerBeenHitThisFrame_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "HasMarkerBeenHitThisFrame");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name SyncGroup, Name MarkerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SyncGroup;
                *((Name*)(b+12)) = MarkerName;
                Main.GetProcessEvent(obj, HasMarkerBeenHitThisFrame_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct IsAnyMontagePlaying_method {
            static internal IntPtr IsAnyMontagePlaying_ptr;
            static IsAnyMontagePlaying_method() {
                IsAnyMontagePlaying_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "IsAnyMontagePlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsAnyMontagePlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayingSlotAnimation_method {
            static internal IntPtr IsPlayingSlotAnimation_ptr;
            static IsPlayingSlotAnimation_method() {
                IsPlayingSlotAnimation_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "IsPlayingSlotAnimation");
            }

            internal static unsafe bool Invoke(IntPtr obj, AnimSequenceBase Asset, Name SlotNodeName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Asset;
                *((Name*)(b+8)) = SlotNodeName;
                Main.GetProcessEvent(obj, IsPlayingSlotAnimation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct IsSyncGroupBetweenMarkers_method {
            static internal IntPtr IsSyncGroupBetweenMarkers_ptr;
            static IsSyncGroupBetweenMarkers_method() {
                IsSyncGroupBetweenMarkers_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "IsSyncGroupBetweenMarkers");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name InSyncGroupName, Name PreviousMarker, Name NextMarker, bool bRespectMarkerOrder) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSyncGroupName;
                *((Name*)(b+12)) = PreviousMarker;
                *((Name*)(b+24)) = NextMarker;
                *((bool*)(b+36)) = bRespectMarkerOrder;
                Main.GetProcessEvent(obj, IsSyncGroupBetweenMarkers_ptr, new IntPtr(p)); ;
                return *((bool*)(b+37));
            }
        }
        internal struct LockAIResources_method {
            static internal IntPtr LockAIResources_ptr;
            static LockAIResources_method() {
                LockAIResources_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "LockAIResources");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bLockMovement, bool LockAILogic) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bLockMovement;
                *((bool*)(b+1)) = LockAILogic;
                Main.GetProcessEvent(obj, LockAIResources_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_GetBlendTime_method {
            static internal IntPtr Montage_GetBlendTime_ptr;
            static Montage_GetBlendTime_method() {
                Montage_GetBlendTime_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_GetBlendTime");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_GetBlendTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Montage_GetCurrentSection_method {
            static internal IntPtr Montage_GetCurrentSection_ptr;
            static Montage_GetCurrentSection_method() {
                Montage_GetCurrentSection_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_GetCurrentSection");
            }

            internal static unsafe Name Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_GetCurrentSection_ptr, new IntPtr(p)); ;
                return *((Name*)(b+8));
            }
        }
        internal struct Montage_GetIsStopped_method {
            static internal IntPtr Montage_GetIsStopped_ptr;
            static Montage_GetIsStopped_method() {
                Montage_GetIsStopped_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_GetIsStopped");
            }

            internal static unsafe bool Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_GetIsStopped_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Montage_GetPlayRate_method {
            static internal IntPtr Montage_GetPlayRate_ptr;
            static Montage_GetPlayRate_method() {
                Montage_GetPlayRate_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_GetPlayRate");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_GetPlayRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Montage_GetPosition_method {
            static internal IntPtr Montage_GetPosition_ptr;
            static Montage_GetPosition_method() {
                Montage_GetPosition_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_GetPosition");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_GetPosition_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Montage_IsActive_method {
            static internal IntPtr Montage_IsActive_ptr;
            static Montage_IsActive_method() {
                Montage_IsActive_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_IsActive");
            }

            internal static unsafe bool Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_IsActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Montage_IsPlaying_method {
            static internal IntPtr Montage_IsPlaying_ptr;
            static Montage_IsPlaying_method() {
                Montage_IsPlaying_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Montage_JumpToSection_method {
            static internal IntPtr Montage_JumpToSection_ptr;
            static Montage_JumpToSection_method() {
                Montage_JumpToSection_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_JumpToSection");
            }

            internal static unsafe void Invoke(IntPtr obj, Name SectionName, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SectionName;
                *((IntPtr*)(b+16)) = Montage;
                Main.GetProcessEvent(obj, Montage_JumpToSection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_JumpToSectionsEnd_method {
            static internal IntPtr Montage_JumpToSectionsEnd_ptr;
            static Montage_JumpToSectionsEnd_method() {
                Montage_JumpToSectionsEnd_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_JumpToSectionsEnd");
            }

            internal static unsafe void Invoke(IntPtr obj, Name SectionName, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SectionName;
                *((IntPtr*)(b+16)) = Montage;
                Main.GetProcessEvent(obj, Montage_JumpToSectionsEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_Pause_method {
            static internal IntPtr Montage_Pause_ptr;
            static Montage_Pause_method() {
                Montage_Pause_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_Pause");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_Pause_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_Play_method {
            static internal IntPtr Montage_Play_ptr;
            static Montage_Play_method() {
                Montage_Play_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_Play");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimMontage MontageToPlay, float InPlayRate, EMontagePlayReturnType ReturnValueType, float InTimeToStartMontageAt, bool bStopAllMontages) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MontageToPlay;
                *((float*)(b+8)) = InPlayRate;
                *(b+12) = (byte)ReturnValueType;
                *((float*)(b+16)) = InTimeToStartMontageAt;
                *((bool*)(b+20)) = bStopAllMontages;
                Main.GetProcessEvent(obj, Montage_Play_ptr, new IntPtr(p)); ;
                return *((float*)(b+24));
            }
        }
        internal struct Montage_Resume_method {
            static internal IntPtr Montage_Resume_ptr;
            static Montage_Resume_method() {
                Montage_Resume_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_Resume");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                Main.GetProcessEvent(obj, Montage_Resume_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_SetNextSection_method {
            static internal IntPtr Montage_SetNextSection_ptr;
            static Montage_SetNextSection_method() {
                Montage_SetNextSection_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_SetNextSection");
            }

            internal static unsafe void Invoke(IntPtr obj, Name SectionNameToChange, Name NextSection, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SectionNameToChange;
                *((Name*)(b+12)) = NextSection;
                *((IntPtr*)(b+24)) = Montage;
                Main.GetProcessEvent(obj, Montage_SetNextSection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_SetPlayRate_method {
            static internal IntPtr Montage_SetPlayRate_ptr;
            static Montage_SetPlayRate_method() {
                Montage_SetPlayRate_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimMontage Montage, float NewPlayRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                *((float*)(b+8)) = NewPlayRate;
                Main.GetProcessEvent(obj, Montage_SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_SetPosition_method {
            static internal IntPtr Montage_SetPosition_ptr;
            static Montage_SetPosition_method() {
                Montage_SetPosition_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_SetPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimMontage Montage, float NewPosition) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Montage;
                *((float*)(b+8)) = NewPosition;
                Main.GetProcessEvent(obj, Montage_SetPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Montage_Stop_method {
            static internal IntPtr Montage_Stop_ptr;
            static Montage_Stop_method() {
                Montage_Stop_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "Montage_Stop");
            }

            internal static unsafe void Invoke(IntPtr obj, float InBlendOutTime, AnimMontage Montage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InBlendOutTime;
                *((IntPtr*)(b+8)) = Montage;
                Main.GetProcessEvent(obj, Montage_Stop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlaySlotAnimation_method {
            static internal IntPtr PlaySlotAnimation_ptr;
            static PlaySlotAnimation_method() {
                PlaySlotAnimation_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "PlaySlotAnimation");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimSequenceBase Asset, Name SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Asset;
                *((Name*)(b+8)) = SlotNodeName;
                *((float*)(b+20)) = BlendInTime;
                *((float*)(b+24)) = BlendOutTime;
                *((float*)(b+28)) = InPlayRate;
                *((int*)(b+32)) = LoopCount;
                Main.GetProcessEvent(obj, PlaySlotAnimation_ptr, new IntPtr(p)); ;
                return *((float*)(b+36));
            }
        }
        internal struct PlaySlotAnimationAsDynamicMontage_method {
            static internal IntPtr PlaySlotAnimationAsDynamicMontage_ptr;
            static PlaySlotAnimationAsDynamicMontage_method() {
                PlaySlotAnimationAsDynamicMontage_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "PlaySlotAnimationAsDynamicMontage");
            }

            internal static unsafe AnimMontage Invoke(IntPtr obj, AnimSequenceBase Asset, Name SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Asset;
                *((Name*)(b+8)) = SlotNodeName;
                *((float*)(b+20)) = BlendInTime;
                *((float*)(b+24)) = BlendOutTime;
                *((float*)(b+28)) = InPlayRate;
                *((int*)(b+32)) = LoopCount;
                *((float*)(b+36)) = BlendOutTriggerTime;
                *((float*)(b+40)) = InTimeToStartMontageAt;
                Main.GetProcessEvent(obj, PlaySlotAnimationAsDynamicMontage_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct ResetDynamics_method {
            static internal IntPtr ResetDynamics_ptr;
            static ResetDynamics_method() {
                ResetDynamics_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "ResetDynamics");
            }

            internal static unsafe void Invoke(IntPtr obj, ETeleportType InTeleportType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InTeleportType;
                Main.GetProcessEvent(obj, ResetDynamics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SavePoseSnapshot_method {
            static internal IntPtr SavePoseSnapshot_ptr;
            static SavePoseSnapshot_method() {
                SavePoseSnapshot_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "SavePoseSnapshot");
            }

            internal static unsafe void Invoke(IntPtr obj, Name SnapshotName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SnapshotName;
                Main.GetProcessEvent(obj, SavePoseSnapshot_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMorphTarget_method {
            static internal IntPtr SetMorphTarget_ptr;
            static SetMorphTarget_method() {
                SetMorphTarget_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "SetMorphTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Name MorphTargetName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MorphTargetName;
                *((float*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetMorphTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRootMotionMode_method {
            static internal IntPtr SetRootMotionMode_ptr;
            static SetRootMotionMode_method() {
                SetRootMotionMode_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "SetRootMotionMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Value;
                Main.GetProcessEvent(obj, SetRootMotionMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SnapshotPose_method {
            static internal IntPtr SnapshotPose_ptr;
            static SnapshotPose_method() {
                SnapshotPose_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "SnapshotPose");
            }

            internal static unsafe void Invoke(IntPtr obj, PoseSnapshot Snapshot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PoseSnapshot*)(b+0)) = Snapshot;
                Main.GetProcessEvent(obj, SnapshotPose_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopSlotAnimation_method {
            static internal IntPtr StopSlotAnimation_ptr;
            static StopSlotAnimation_method() {
                StopSlotAnimation_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "StopSlotAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, float InBlendOutTime, Name SlotNodeName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InBlendOutTime;
                *((Name*)(b+4)) = SlotNodeName;
                Main.GetProcessEvent(obj, StopSlotAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TryGetPawnOwner_method {
            static internal IntPtr TryGetPawnOwner_ptr;
            static TryGetPawnOwner_method() {
                TryGetPawnOwner_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "TryGetPawnOwner");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, TryGetPawnOwner_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct UnlockAIResources_method {
            static internal IntPtr UnlockAIResources_ptr;
            static UnlockAIResources_method() {
                UnlockAIResources_ptr = Main.GetMethodUFunction(AnimInstance.StaticClass, "UnlockAIResources");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bUnlockMovement, bool UnlockAILogic) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bUnlockMovement;
                *((bool*)(b+1)) = UnlockAILogic;
                Main.GetProcessEvent(obj, UnlockAIResources_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AnimInstance_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct BlueprintBeginPlay_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintBeginPlay_link;
            private static unsafe void BlueprintBeginPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintBeginPlay();
            }
            internal static void Setup() {
                BlueprintBeginPlay_link = new DelegateHolder<NativeFuncDelegate>(BlueprintBeginPlay_process_event);
                var uf = Main.GetUFunction("BlueprintBeginPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintBeginPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct BlueprintInitializeAnimation_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintInitializeAnimation_link;
            private static unsafe void BlueprintInitializeAnimation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintInitializeAnimation();
            }
            internal static void Setup() {
                BlueprintInitializeAnimation_link = new DelegateHolder<NativeFuncDelegate>(BlueprintInitializeAnimation_process_event);
                var uf = Main.GetUFunction("BlueprintInitializeAnimation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintInitializeAnimation_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct BlueprintPostEvaluateAnimation_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintPostEvaluateAnimation_link;
            private static unsafe void BlueprintPostEvaluateAnimation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintPostEvaluateAnimation();
            }
            internal static void Setup() {
                BlueprintPostEvaluateAnimation_link = new DelegateHolder<NativeFuncDelegate>(BlueprintPostEvaluateAnimation_process_event);
                var uf = Main.GetUFunction("BlueprintPostEvaluateAnimation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintPostEvaluateAnimation_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct BlueprintUpdateAnimation_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintUpdateAnimation_link;
            private static unsafe void BlueprintUpdateAnimation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintUpdateAnimation(*(float*)(b+0));
            }
            internal static void Setup() {
                BlueprintUpdateAnimation_link = new DelegateHolder<NativeFuncDelegate>(BlueprintUpdateAnimation_process_event);
                var uf = Main.GetUFunction("BlueprintUpdateAnimation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintUpdateAnimation_link.Delegate));
            }
        }
    }
}
