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

using UE4.ClothingSystemRuntimeInterface;

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=3264 )]
    internal unsafe struct SkeletalMeshComponent_fields {
        [FieldOffset(2008)] public IntPtr AnimBlueprintGeneratedClass;
        [FieldOffset(2016)] public IntPtr AnimClass;
        [FieldOffset(2024)]  public IntPtr  AnimScriptInstance;
        [FieldOffset(2032)] public NativeArray SubInstances;
        [FieldOffset(2048)]  public IntPtr  PostProcessAnimInstance;
        [FieldOffset(2056)] public bool bDisablePostProcessBlueprint;
        [FieldOffset(2064)] public SingleAnimationPlayData AnimationData;
        [FieldOffset(2104)] public Vector RootBoneTranslation;
        [FieldOffset(2116)] public Vector LineCheckBoundsScale;
        [FieldOffset(2160)] public NativeArray CachedBoneSpaceTransforms;
        [FieldOffset(2176)] public NativeArray CachedComponentSpaceTransforms;
        [FieldOffset(2224)] public float GlobalAnimRateScale;
        [FieldOffset(2228)] byte UseAsyncScene; //TODO: enum EDynamicActorScene UseAsyncScene
        [FieldOffset(2229)] public byte KinematicBonesUpdateType;
        [FieldOffset(2230)] public byte PhysicsTransformUpdateMode;
        [FieldOffset(2232)] public byte AnimationMode;
        [FieldOffset(2234)] public bool bHasValidBodies;
        [FieldOffset(2234)] public bool bBlendPhysics;
        [FieldOffset(2234)] public bool bEnablePhysicsOnDedicatedServer;
        [FieldOffset(2234)] public bool bUpdateJointsFromAnimation;
        [FieldOffset(2234)] public bool bDisableClothSimulation;
        [FieldOffset(2234)] public bool bAllowAnimCurveEvaluation;
        [FieldOffset(2235)] public bool bCollideWithEnvironment;
        [FieldOffset(2235)] public bool bCollideWithAttachedChildren;
        [FieldOffset(2235)] public bool bLocalSpaceSimulation;
        [FieldOffset(2235)] public bool bResetAfterTeleport;
        [FieldOffset(2236)] public bool bDeferMovementFromSceneQueries;
        [FieldOffset(2236)] public bool bNoSkeletonUpdate;
        [FieldOffset(2236)] public bool bPauseAnims;
        [FieldOffset(2236)] public bool bUseRefPoseOnInitAnim;
        [FieldOffset(2236)] public bool bEnablePerPolyCollision;
        [FieldOffset(2236)] public bool bForceRefpose;
        [FieldOffset(2236)] public bool bOnlyAllowAutonomousTickPose;
        [FieldOffset(2237)] public bool bIsAutonomousTickPose;
        [FieldOffset(2237)] public bool bOldForceRefPose;
        [FieldOffset(2237)] public bool bShowPrePhysBones;
        [FieldOffset(2237)] public bool bRequiredBonesUpToDate;
        [FieldOffset(2237)] public bool bAnimTreeInitialised;
        [FieldOffset(2237)] public bool bIncludeComponentLocationIntoBounds;
        [FieldOffset(2237)] public bool bEnableLineCheckWithBounds;
        [FieldOffset(2238)] public bool bUpdateAnimationInEditor;
        [FieldOffset(2238)] public bool bNeedsQueuedAnimEventsDispatched;
        [FieldOffset(2240)] public NativeArray DisallowedAnimCurves;
        [FieldOffset(2256)] byte CachedAnimCurveUidVersion; //TODO: numeric uint16 CachedAnimCurveUidVersion
        [FieldOffset(2260)] public float ClothBlendWeight;
        [FieldOffset(2264)] public float EdgeStiffness;
        [FieldOffset(2268)] public float BendingStiffness;
        [FieldOffset(2272)] public float AreaStiffness;
        [FieldOffset(2276)] public float VolumeStiffness;
        [FieldOffset(2280)] public float StrainLimitingStiffness;
        [FieldOffset(2284)] public float ShapeTargetStiffness;
        [FieldOffset(2288)] public bool bUseBendingElements;
        [FieldOffset(2289)] public bool bUseTetrahedralConstraints;
        [FieldOffset(2290)] public bool bUseThinShellVolumeConstraints;
        [FieldOffset(2291)] public bool bUseSelfCollisions;
        [FieldOffset(2292)] public bool bUseContinuousCollisionDetection;
        [FieldOffset(2296)]  public IntPtr  BodySetup;
        [FieldOffset(2312)] byte OnConstraintBroken; //TODO: multicast delegate FConstraintBrokenSignature OnConstraintBroken
        [FieldOffset(2328)] public IntPtr ClothingSimulationFactory;
        [FieldOffset(2576)] public float TeleportDistanceThreshold;
        [FieldOffset(2580)] public float TeleportRotationThreshold;
        [FieldOffset(2592)] byte LastPoseTickFrame; //TODO: numeric uint32 LastPoseTickFrame
        [FieldOffset(2688)]  public IntPtr  ClothingInteractor;
        [FieldOffset(2880)] byte OnAnimInitialized; //TODO: multicast delegate FOnAnimInitialized OnAnimInitialized
    }
    internal unsafe struct SkeletalMeshComponent_methods {
        internal struct AccumulateAllBodiesBelowPhysicsBlendWeight_method {
            static internal IntPtr AccumulateAllBodiesBelowPhysicsBlendWeight_ptr;
            static AccumulateAllBodiesBelowPhysicsBlendWeight_method() {
                AccumulateAllBodiesBelowPhysicsBlendWeight_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "AccumulateAllBodiesBelowPhysicsBlendWeight");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InBoneName;
                *((float*)(b+12)) = AddPhysicsBlendWeight;
                *((bool*)(b+16)) = bSkipCustomPhysicsType;
                Main.GetProcessEvent(obj, AccumulateAllBodiesBelowPhysicsBlendWeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddForceToAllBodiesBelow_method {
            static internal IntPtr AddForceToAllBodiesBelow_ptr;
            static AddForceToAllBodiesBelow_method() {
                AddForceToAllBodiesBelow_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "AddForceToAllBodiesBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Force, Name BoneName, bool bAccelChange, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Force;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bAccelChange;
                *((bool*)(b+25)) = bIncludeSelf;
                Main.GetProcessEvent(obj, AddForceToAllBodiesBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddImpulseToAllBodiesBelow_method {
            static internal IntPtr AddImpulseToAllBodiesBelow_ptr;
            static AddImpulseToAllBodiesBelow_method() {
                AddImpulseToAllBodiesBelow_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "AddImpulseToAllBodiesBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Name BoneName, bool bVelChange, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bVelChange;
                *((bool*)(b+25)) = bIncludeSelf;
                Main.GetProcessEvent(obj, AddImpulseToAllBodiesBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AllowAnimCurveEvaluation_method {
            static internal IntPtr AllowAnimCurveEvaluation_ptr;
            static AllowAnimCurveEvaluation_method() {
                AllowAnimCurveEvaluation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "AllowAnimCurveEvaluation");
            }

            internal static unsafe void Invoke(IntPtr obj, Name NameOfCurve, bool bAllow) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = NameOfCurve;
                *((bool*)(b+12)) = bAllow;
                Main.GetProcessEvent(obj, AllowAnimCurveEvaluation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BindClothToMasterPoseComponent_method {
            static internal IntPtr BindClothToMasterPoseComponent_ptr;
            static BindClothToMasterPoseComponent_method() {
                BindClothToMasterPoseComponent_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "BindClothToMasterPoseComponent");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BindClothToMasterPoseComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BreakConstraint_method {
            static internal IntPtr BreakConstraint_ptr;
            static BreakConstraint_method() {
                BreakConstraint_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "BreakConstraint");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Vector HitLocation, Name InBoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Vector*)(b+12)) = HitLocation;
                *((Name*)(b+24)) = InBoneName;
                Main.GetProcessEvent(obj, BreakConstraint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMorphTargets_method {
            static internal IntPtr ClearMorphTargets_ptr;
            static ClearMorphTargets_method() {
                ClearMorphTargets_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ClearMorphTargets");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMorphTargets_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindConstraintBoneName_method {
            static internal IntPtr FindConstraintBoneName_ptr;
            static FindConstraintBoneName_method() {
                FindConstraintBoneName_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "FindConstraintBoneName");
            }

            internal static unsafe Name Invoke(IntPtr obj, int ConstraintIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ConstraintIndex;
                Main.GetProcessEvent(obj, FindConstraintBoneName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+4));
            }
        }
        internal struct ForceClothNextUpdateTeleport_method {
            static internal IntPtr ForceClothNextUpdateTeleport_ptr;
            static ForceClothNextUpdateTeleport_method() {
                ForceClothNextUpdateTeleport_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ForceClothNextUpdateTeleport");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceClothNextUpdateTeleport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceClothNextUpdateTeleportAndReset_method {
            static internal IntPtr ForceClothNextUpdateTeleportAndReset_ptr;
            static ForceClothNextUpdateTeleportAndReset_method() {
                ForceClothNextUpdateTeleportAndReset_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ForceClothNextUpdateTeleportAndReset");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceClothNextUpdateTeleportAndReset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAllowedAnimCurveEvaluate_method {
            static internal IntPtr GetAllowedAnimCurveEvaluate_ptr;
            static GetAllowedAnimCurveEvaluate_method() {
                GetAllowedAnimCurveEvaluate_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetAllowedAnimCurveEvaluate");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllowedAnimCurveEvaluate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetAnimationMode_method {
            static internal IntPtr GetAnimationMode_ptr;
            static GetAnimationMode_method() {
                GetAnimationMode_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetAnimationMode");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnimationMode_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetAnimInstance_method {
            static internal IntPtr GetAnimInstance_ptr;
            static GetAnimInstance_method() {
                GetAnimInstance_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetAnimInstance");
            }

            internal static unsafe AnimInstance Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnimInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetBoneMass_method {
            static internal IntPtr GetBoneMass_ptr;
            static GetBoneMass_method() {
                GetBoneMass_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetBoneMass");
            }

            internal static unsafe float Invoke(IntPtr obj, Name BoneName, bool bScaleMass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((bool*)(b+12)) = bScaleMass;
                Main.GetProcessEvent(obj, GetBoneMass_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct GetClothingSimulationInteractor_method {
            static internal IntPtr GetClothingSimulationInteractor_ptr;
            static GetClothingSimulationInteractor_method() {
                GetClothingSimulationInteractor_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetClothingSimulationInteractor");
            }

            internal static unsafe ClothingSimulationInteractor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetClothingSimulationInteractor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetClothMaxDistanceScale_method {
            static internal IntPtr GetClothMaxDistanceScale_ptr;
            static GetClothMaxDistanceScale_method() {
                GetClothMaxDistanceScale_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetClothMaxDistanceScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetClothMaxDistanceScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCurrentJointAngles_method {
            static internal IntPtr GetCurrentJointAngles_ptr;
            static GetCurrentJointAngles_method() {
                GetCurrentJointAngles_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetCurrentJointAngles");
            }

            internal static unsafe (float, float, float) Invoke(IntPtr obj, Name InBoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InBoneName;
                Main.GetProcessEvent(obj, GetCurrentJointAngles_ptr, new IntPtr(p)); ;
                return (*((float*)(b+12)),*((float*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct GetDisableAnimCurves_method {
            static internal IntPtr GetDisableAnimCurves_ptr;
            static GetDisableAnimCurves_method() {
                GetDisableAnimCurves_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetDisableAnimCurves");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDisableAnimCurves_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetDisablePostProcessBlueprint_method {
            static internal IntPtr GetDisablePostProcessBlueprint_ptr;
            static GetDisablePostProcessBlueprint_method() {
                GetDisablePostProcessBlueprint_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetDisablePostProcessBlueprint");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDisablePostProcessBlueprint_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetMorphTarget_method {
            static internal IntPtr GetMorphTarget_ptr;
            static GetMorphTarget_method() {
                GetMorphTarget_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetMorphTarget");
            }

            internal static unsafe float Invoke(IntPtr obj, Name MorphTargetName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MorphTargetName;
                Main.GetProcessEvent(obj, GetMorphTarget_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetPlayRate_method {
            static internal IntPtr GetPlayRate_ptr;
            static GetPlayRate_method() {
                GetPlayRate_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetPlayRate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPosition_method {
            static internal IntPtr GetPosition_ptr;
            static GetPosition_method() {
                GetPosition_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetPosition");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPosition_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPostProcessInstance_method {
            static internal IntPtr GetPostProcessInstance_ptr;
            static GetPostProcessInstance_method() {
                GetPostProcessInstance_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetPostProcessInstance");
            }

            internal static unsafe AnimInstance Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPostProcessInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetSkeletalCenterOfMass_method {
            static internal IntPtr GetSkeletalCenterOfMass_ptr;
            static GetSkeletalCenterOfMass_method() {
                GetSkeletalCenterOfMass_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetSkeletalCenterOfMass");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSkeletalCenterOfMass_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetTeleportDistanceThreshold_method {
            static internal IntPtr GetTeleportDistanceThreshold_ptr;
            static GetTeleportDistanceThreshold_method() {
                GetTeleportDistanceThreshold_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetTeleportDistanceThreshold");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTeleportDistanceThreshold_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTeleportRotationThreshold_method {
            static internal IntPtr GetTeleportRotationThreshold_ptr;
            static GetTeleportRotationThreshold_method() {
                GetTeleportRotationThreshold_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "GetTeleportRotationThreshold");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTeleportRotationThreshold_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct HasValidAnimationInstance_method {
            static internal IntPtr HasValidAnimationInstance_ptr;
            static HasValidAnimationInstance_method() {
                HasValidAnimationInstance_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "HasValidAnimationInstance");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasValidAnimationInstance_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsBodyGravityEnabled_method {
            static internal IntPtr IsBodyGravityEnabled_ptr;
            static IsBodyGravityEnabled_method() {
                IsBodyGravityEnabled_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "IsBodyGravityEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, IsBodyGravityEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsClothingSimulationSuspended_method {
            static internal IntPtr IsClothingSimulationSuspended_ptr;
            static IsClothingSimulationSuspended_method() {
                IsClothingSimulationSuspended_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "IsClothingSimulationSuspended");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsClothingSimulationSuspended_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_GetClosestPointOnPhysicsAsset_method {
            static internal IntPtr K2_GetClosestPointOnPhysicsAsset_ptr;
            static K2_GetClosestPointOnPhysicsAsset_method() {
                K2_GetClosestPointOnPhysicsAsset_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "K2_GetClosestPointOnPhysicsAsset");
            }

            internal static unsafe (Vector, Vector, Name, float, bool) Invoke(IntPtr obj, Vector WorldPosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldPosition;
                Main.GetProcessEvent(obj, K2_GetClosestPointOnPhysicsAsset_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((Vector*)(b+24)),*((Name*)(b+36)),*((float*)(b+48)),*((bool*)(b+52)));
            }
        }
        internal struct K2_SetAnimInstanceClass_method {
            static internal IntPtr K2_SetAnimInstanceClass_ptr;
            static K2_SetAnimInstanceClass_method() {
                K2_SetAnimInstanceClass_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "K2_SetAnimInstanceClass");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<UObject> NewClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewClass;
                Main.GetProcessEvent(obj, K2_SetAnimInstanceClass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct OverrideAnimationData_method {
            static internal IntPtr OverrideAnimationData_ptr;
            static OverrideAnimationData_method() {
                OverrideAnimationData_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "OverrideAnimationData");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimationAsset InAnimToPlay, bool bIsLooping, bool bIsPlaying, float Position, float PlayRate) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimToPlay;
                *((bool*)(b+8)) = bIsLooping;
                *((bool*)(b+9)) = bIsPlaying;
                *((float*)(b+12)) = Position;
                *((float*)(b+16)) = PlayRate;
                Main.GetProcessEvent(obj, OverrideAnimationData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bLooping;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayAnimation_method {
            static internal IntPtr PlayAnimation_ptr;
            static PlayAnimation_method() {
                PlayAnimation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "PlayAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimationAsset NewAnimToPlay, bool bLooping) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewAnimToPlay;
                *((bool*)(b+8)) = bLooping;
                Main.GetProcessEvent(obj, PlayAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetAllBodiesSimulatePhysics_method {
            static internal IntPtr ResetAllBodiesSimulatePhysics_ptr;
            static ResetAllBodiesSimulatePhysics_method() {
                ResetAllBodiesSimulatePhysics_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ResetAllBodiesSimulatePhysics");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetAllBodiesSimulatePhysics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetAllowedAnimCurveEvaluation_method {
            static internal IntPtr ResetAllowedAnimCurveEvaluation_ptr;
            static ResetAllowedAnimCurveEvaluation_method() {
                ResetAllowedAnimCurveEvaluation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ResetAllowedAnimCurveEvaluation");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetAllowedAnimCurveEvaluation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetAnimInstanceDynamics_method {
            static internal IntPtr ResetAnimInstanceDynamics_ptr;
            static ResetAnimInstanceDynamics_method() {
                ResetAnimInstanceDynamics_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ResetAnimInstanceDynamics");
            }

            internal static unsafe void Invoke(IntPtr obj, ETeleportType InTeleportType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InTeleportType;
                Main.GetProcessEvent(obj, ResetAnimInstanceDynamics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetClothTeleportMode_method {
            static internal IntPtr ResetClothTeleportMode_ptr;
            static ResetClothTeleportMode_method() {
                ResetClothTeleportMode_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ResetClothTeleportMode");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetClothTeleportMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResumeClothingSimulation_method {
            static internal IntPtr ResumeClothingSimulation_ptr;
            static ResumeClothingSimulation_method() {
                ResumeClothingSimulation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ResumeClothingSimulation");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResumeClothingSimulation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllBodiesBelowPhysicsBlendWeight_method {
            static internal IntPtr SetAllBodiesBelowPhysicsBlendWeight_ptr;
            static SetAllBodiesBelowPhysicsBlendWeight_method() {
                SetAllBodiesBelowPhysicsBlendWeight_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllBodiesBelowPhysicsBlendWeight");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InBoneName;
                *((float*)(b+12)) = PhysicsBlendWeight;
                *((bool*)(b+16)) = bSkipCustomPhysicsType;
                *((bool*)(b+17)) = bIncludeSelf;
                Main.GetProcessEvent(obj, SetAllBodiesBelowPhysicsBlendWeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllBodiesBelowSimulatePhysics_method {
            static internal IntPtr SetAllBodiesBelowSimulatePhysics_ptr;
            static SetAllBodiesBelowSimulatePhysics_method() {
                SetAllBodiesBelowSimulatePhysics_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllBodiesBelowSimulatePhysics");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InBoneName, bool bNewSimulate, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InBoneName;
                *((bool*)(b+12)) = bNewSimulate;
                *((bool*)(b+13)) = bIncludeSelf;
                Main.GetProcessEvent(obj, SetAllBodiesBelowSimulatePhysics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllBodiesPhysicsBlendWeight_method {
            static internal IntPtr SetAllBodiesPhysicsBlendWeight_ptr;
            static SetAllBodiesPhysicsBlendWeight_method() {
                SetAllBodiesPhysicsBlendWeight_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllBodiesPhysicsBlendWeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float PhysicsBlendWeight, bool bSkipCustomPhysicsType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = PhysicsBlendWeight;
                *((bool*)(b+4)) = bSkipCustomPhysicsType;
                Main.GetProcessEvent(obj, SetAllBodiesPhysicsBlendWeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllBodiesSimulatePhysics_method {
            static internal IntPtr SetAllBodiesSimulatePhysics_ptr;
            static SetAllBodiesSimulatePhysics_method() {
                SetAllBodiesSimulatePhysics_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllBodiesSimulatePhysics");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewSimulate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewSimulate;
                Main.GetProcessEvent(obj, SetAllBodiesSimulatePhysics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllMotorsAngularDriveParams_method {
            static internal IntPtr SetAllMotorsAngularDriveParams_ptr;
            static SetAllMotorsAngularDriveParams_method() {
                SetAllMotorsAngularDriveParams_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllMotorsAngularDriveParams");
            }

            internal static unsafe void Invoke(IntPtr obj, float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InSpring;
                *((float*)(b+4)) = InDamping;
                *((float*)(b+8)) = InForceLimit;
                *((bool*)(b+12)) = bSkipCustomPhysicsType;
                Main.GetProcessEvent(obj, SetAllMotorsAngularDriveParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllMotorsAngularPositionDrive_method {
            static internal IntPtr SetAllMotorsAngularPositionDrive_ptr;
            static SetAllMotorsAngularPositionDrive_method() {
                SetAllMotorsAngularPositionDrive_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllMotorsAngularPositionDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSwingDrive;
                *((bool*)(b+1)) = bEnableTwistDrive;
                *((bool*)(b+2)) = bSkipCustomPhysicsType;
                Main.GetProcessEvent(obj, SetAllMotorsAngularPositionDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllMotorsAngularVelocityDrive_method {
            static internal IntPtr SetAllMotorsAngularVelocityDrive_ptr;
            static SetAllMotorsAngularVelocityDrive_method() {
                SetAllMotorsAngularVelocityDrive_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllMotorsAngularVelocityDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSwingDrive;
                *((bool*)(b+1)) = bEnableTwistDrive;
                *((bool*)(b+2)) = bSkipCustomPhysicsType;
                Main.GetProcessEvent(obj, SetAllMotorsAngularVelocityDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowAnimCurveEvaluation_method {
            static internal IntPtr SetAllowAnimCurveEvaluation_ptr;
            static SetAllowAnimCurveEvaluation_method() {
                SetAllowAnimCurveEvaluation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllowAnimCurveEvaluation");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllow) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllow;
                Main.GetProcessEvent(obj, SetAllowAnimCurveEvaluation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowedAnimCurvesEvaluation_method {
            static internal IntPtr SetAllowedAnimCurvesEvaluation_ptr;
            static SetAllowedAnimCurvesEvaluation_method() {
                SetAllowedAnimCurvesEvaluation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAllowedAnimCurvesEvaluation");
            }

            internal static unsafe void Invoke(IntPtr obj, byte List /*TODO: array TArray */, bool bAllow) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray List
                *((bool*)(b+16)) = bAllow;
                Main.GetProcessEvent(obj, SetAllowedAnimCurvesEvaluation_ptr, new IntPtr(p)); ;
                 //TODO: array TArray List
            }
        }
        internal struct SetAngularLimits_method {
            static internal IntPtr SetAngularLimits_ptr;
            static SetAngularLimits_method() {
                SetAngularLimits_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAngularLimits");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InBoneName;
                *((float*)(b+12)) = Swing1LimitAngle;
                *((float*)(b+16)) = TwistLimitAngle;
                *((float*)(b+20)) = Swing2LimitAngle;
                Main.GetProcessEvent(obj, SetAngularLimits_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimation_method {
            static internal IntPtr SetAnimation_ptr;
            static SetAnimation_method() {
                SetAnimation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimationAsset NewAnimToPlay) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewAnimToPlay;
                Main.GetProcessEvent(obj, SetAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimationMode_method {
            static internal IntPtr SetAnimationMode_ptr;
            static SetAnimationMode_method() {
                SetAnimationMode_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetAnimationMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InAnimationMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InAnimationMode;
                Main.GetProcessEvent(obj, SetAnimationMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBodyNotifyRigidBodyCollision_method {
            static internal IntPtr SetBodyNotifyRigidBodyCollision_ptr;
            static SetBodyNotifyRigidBodyCollision_method() {
                SetBodyNotifyRigidBodyCollision_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetBodyNotifyRigidBodyCollision");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewNotifyRigidBodyCollision, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewNotifyRigidBodyCollision;
                *((Name*)(b+4)) = BoneName;
                Main.GetProcessEvent(obj, SetBodyNotifyRigidBodyCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClothMaxDistanceScale_method {
            static internal IntPtr SetClothMaxDistanceScale_ptr;
            static SetClothMaxDistanceScale_method() {
                SetClothMaxDistanceScale_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetClothMaxDistanceScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float Scale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Scale;
                Main.GetProcessEvent(obj, SetClothMaxDistanceScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintProfile_method {
            static internal IntPtr SetConstraintProfile_ptr;
            static SetConstraintProfile_method() {
                SetConstraintProfile_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetConstraintProfile");
            }

            internal static unsafe void Invoke(IntPtr obj, Name JointName, Name ProfileName, bool bDefaultIfNotFound) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = JointName;
                *((Name*)(b+12)) = ProfileName;
                *((bool*)(b+24)) = bDefaultIfNotFound;
                Main.GetProcessEvent(obj, SetConstraintProfile_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintProfileForAll_method {
            static internal IntPtr SetConstraintProfileForAll_ptr;
            static SetConstraintProfileForAll_method() {
                SetConstraintProfileForAll_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetConstraintProfileForAll");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ProfileName, bool bDefaultIfNotFound) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ProfileName;
                *((bool*)(b+12)) = bDefaultIfNotFound;
                Main.GetProcessEvent(obj, SetConstraintProfileForAll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisableAnimCurves_method {
            static internal IntPtr SetDisableAnimCurves_ptr;
            static SetDisableAnimCurves_method() {
                SetDisableAnimCurves_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetDisableAnimCurves");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInDisableAnimCurves) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInDisableAnimCurves;
                Main.GetProcessEvent(obj, SetDisableAnimCurves_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisablePostProcessBlueprint_method {
            static internal IntPtr SetDisablePostProcessBlueprint_ptr;
            static SetDisablePostProcessBlueprint_method() {
                SetDisablePostProcessBlueprint_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetDisablePostProcessBlueprint");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInDisablePostProcess) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInDisablePostProcess;
                Main.GetProcessEvent(obj, SetDisablePostProcessBlueprint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableBodyGravity_method {
            static internal IntPtr SetEnableBodyGravity_ptr;
            static SetEnableBodyGravity_method() {
                SetEnableBodyGravity_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetEnableBodyGravity");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableGravity, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableGravity;
                *((Name*)(b+4)) = BoneName;
                Main.GetProcessEvent(obj, SetEnableBodyGravity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableGravityOnAllBodiesBelow_method {
            static internal IntPtr SetEnableGravityOnAllBodiesBelow_ptr;
            static SetEnableGravityOnAllBodiesBelow_method() {
                SetEnableGravityOnAllBodiesBelow_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetEnableGravityOnAllBodiesBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableGravity, Name BoneName, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableGravity;
                *((Name*)(b+4)) = BoneName;
                *((bool*)(b+16)) = bIncludeSelf;
                Main.GetProcessEvent(obj, SetEnableGravityOnAllBodiesBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnablePhysicsBlending_method {
            static internal IntPtr SetEnablePhysicsBlending_ptr;
            static SetEnablePhysicsBlending_method() {
                SetEnablePhysicsBlending_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetEnablePhysicsBlending");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewBlendPhysics) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewBlendPhysics;
                Main.GetProcessEvent(obj, SetEnablePhysicsBlending_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMorphTarget_method {
            static internal IntPtr SetMorphTarget_ptr;
            static SetMorphTarget_method() {
                SetMorphTarget_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetMorphTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Name MorphTargetName, float Value, bool bRemoveZeroWeight) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MorphTargetName;
                *((float*)(b+12)) = Value;
                *((bool*)(b+16)) = bRemoveZeroWeight;
                Main.GetProcessEvent(obj, SetMorphTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNotifyRigidBodyCollisionBelow_method {
            static internal IntPtr SetNotifyRigidBodyCollisionBelow_ptr;
            static SetNotifyRigidBodyCollisionBelow_method() {
                SetNotifyRigidBodyCollisionBelow_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetNotifyRigidBodyCollisionBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewNotifyRigidBodyCollision, Name BoneName, bool bIncludeSelf) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewNotifyRigidBodyCollision;
                *((Name*)(b+4)) = BoneName;
                *((bool*)(b+16)) = bIncludeSelf;
                Main.GetProcessEvent(obj, SetNotifyRigidBodyCollisionBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsBlendWeight_method {
            static internal IntPtr SetPhysicsBlendWeight_ptr;
            static SetPhysicsBlendWeight_method() {
                SetPhysicsBlendWeight_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetPhysicsBlendWeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float PhysicsBlendWeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = PhysicsBlendWeight;
                Main.GetProcessEvent(obj, SetPhysicsBlendWeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayRate_method {
            static internal IntPtr SetPlayRate_ptr;
            static SetPlayRate_method() {
                SetPlayRate_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float Rate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Rate;
                Main.GetProcessEvent(obj, SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPosition_method {
            static internal IntPtr SetPosition_ptr;
            static SetPosition_method() {
                SetPosition_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPos, bool bFireNotifies) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPos;
                *((bool*)(b+4)) = bFireNotifies;
                Main.GetProcessEvent(obj, SetPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTeleportDistanceThreshold_method {
            static internal IntPtr SetTeleportDistanceThreshold_ptr;
            static SetTeleportDistanceThreshold_method() {
                SetTeleportDistanceThreshold_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetTeleportDistanceThreshold");
            }

            internal static unsafe void Invoke(IntPtr obj, float Threshold) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Threshold;
                Main.GetProcessEvent(obj, SetTeleportDistanceThreshold_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTeleportRotationThreshold_method {
            static internal IntPtr SetTeleportRotationThreshold_ptr;
            static SetTeleportRotationThreshold_method() {
                SetTeleportRotationThreshold_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetTeleportRotationThreshold");
            }

            internal static unsafe void Invoke(IntPtr obj, float Threshold) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Threshold;
                Main.GetProcessEvent(obj, SetTeleportRotationThreshold_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUpdateAnimationInEditor_method {
            static internal IntPtr SetUpdateAnimationInEditor_ptr;
            static SetUpdateAnimationInEditor_method() {
                SetUpdateAnimationInEditor_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SetUpdateAnimationInEditor");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewUpdateState) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewUpdateState;
                Main.GetProcessEvent(obj, SetUpdateAnimationInEditor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SnapshotPose_method {
            static internal IntPtr SnapshotPose_ptr;
            static SnapshotPose_method() {
                SnapshotPose_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SnapshotPose");
            }

            internal static unsafe void Invoke(IntPtr obj, PoseSnapshot Snapshot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PoseSnapshot*)(b+0)) = Snapshot;
                Main.GetProcessEvent(obj, SnapshotPose_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SuspendClothingSimulation_method {
            static internal IntPtr SuspendClothingSimulation_ptr;
            static SuspendClothingSimulation_method() {
                SuspendClothingSimulation_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "SuspendClothingSimulation");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SuspendClothingSimulation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TermBodiesBelow_method {
            static internal IntPtr TermBodiesBelow_ptr;
            static TermBodiesBelow_method() {
                TermBodiesBelow_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "TermBodiesBelow");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParentBoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParentBoneName;
                Main.GetProcessEvent(obj, TermBodiesBelow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleDisablePostProcessBlueprint_method {
            static internal IntPtr ToggleDisablePostProcessBlueprint_ptr;
            static ToggleDisablePostProcessBlueprint_method() {
                ToggleDisablePostProcessBlueprint_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "ToggleDisablePostProcessBlueprint");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleDisablePostProcessBlueprint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnbindClothFromMasterPoseComponent_method {
            static internal IntPtr UnbindClothFromMasterPoseComponent_ptr;
            static UnbindClothFromMasterPoseComponent_method() {
                UnbindClothFromMasterPoseComponent_ptr = Main.GetMethodUFunction(SkeletalMeshComponent.StaticClass, "UnbindClothFromMasterPoseComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bRestoreSimulationSpace) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bRestoreSimulationSpace;
                Main.GetProcessEvent(obj, UnbindClothFromMasterPoseComponent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SkeletalMeshComponent_events {
    }
}
