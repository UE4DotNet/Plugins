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
    [StructLayout( LayoutKind.Explicit, Size=1952 )]
    internal unsafe struct CharacterMovementComponent_fields {
        [FieldOffset(432)]  public IntPtr  CharacterOwner;
        [FieldOffset(440)] public bool bApplyGravityWhileJumping;
        [FieldOffset(444)] public float GravityScale;
        [FieldOffset(448)] public float MaxStepHeight;
        [FieldOffset(452)] public float JumpZVelocity;
        [FieldOffset(456)] public float JumpOffJumpZFactor;
        [FieldOffset(460)] public float WalkableFloorAngle;
        [FieldOffset(464)] public float WalkableFloorZ;
        [FieldOffset(468)] public byte MovementMode;
        [FieldOffset(469)] public byte CustomMovementMode;
        [FieldOffset(512)] public float GroundFriction;
        [FieldOffset(516)] public float MaxWalkSpeed;
        [FieldOffset(520)] public float MaxWalkSpeedCrouched;
        [FieldOffset(524)] public float MaxSwimSpeed;
        [FieldOffset(528)] public float MaxFlySpeed;
        [FieldOffset(532)] public float MaxCustomMovementSpeed;
        [FieldOffset(536)] public float MaxAcceleration;
        [FieldOffset(540)] public float MinAnalogWalkSpeed;
        [FieldOffset(544)] public float BrakingFrictionFactor;
        [FieldOffset(548)] public float BrakingFriction;
        [FieldOffset(552)] public bool bUseSeparateBrakingFriction;
        [FieldOffset(556)] public float BrakingDecelerationWalking;
        [FieldOffset(560)] public float BrakingDecelerationFalling;
        [FieldOffset(564)] public float BrakingDecelerationSwimming;
        [FieldOffset(568)] public float BrakingDecelerationFlying;
        [FieldOffset(572)] public float AirControl;
        [FieldOffset(576)] public float AirControlBoostMultiplier;
        [FieldOffset(580)] public float AirControlBoostVelocityThreshold;
        [FieldOffset(584)] public float FallingLateralFriction;
        [FieldOffset(588)] public float CrouchedHalfHeight;
        [FieldOffset(592)] public float Buoyancy;
        [FieldOffset(596)] public float PerchRadiusThreshold;
        [FieldOffset(600)] public float PerchAdditionalHeight;
        [FieldOffset(604)] public Rotator RotationRate;
        [FieldOffset(616)] public bool bUseControllerDesiredRotation;
        [FieldOffset(616)] public bool bOrientRotationToMovement;
        [FieldOffset(616)] public bool bSweepWhileNavWalking;
        [FieldOffset(616)] public bool bMovementInProgress;
        [FieldOffset(616)] public bool bEnableScopedMovementUpdates;
        [FieldOffset(616)] public bool bForceMaxAccel;
        [FieldOffset(616)] public bool bRunPhysicsWithNoController;
        [FieldOffset(617)] public bool bForceNextFloorCheck;
        [FieldOffset(617)] public bool bShrinkProxyCapsule;
        [FieldOffset(617)] public bool bCanWalkOffLedges;
        [FieldOffset(617)] public bool bCanWalkOffLedgesWhenCrouching;
        [FieldOffset(617)] public bool bNetworkSkipProxyPredictionOnNetUpdate;
        [FieldOffset(617)] public bool bNetworkAlwaysReplicateTransformUpdateTimestamp;
        [FieldOffset(618)] public bool bDeferUpdateMoveComponent;
        [FieldOffset(624)]  public IntPtr  DeferredUpdatedMoveComponent;
        [FieldOffset(632)] public float MaxOutOfWaterStepHeight;
        [FieldOffset(636)] public float OutofWaterZ;
        [FieldOffset(640)] public float Mass;
        [FieldOffset(644)] public bool bEnablePhysicsInteraction;
        [FieldOffset(645)] public bool bTouchForceScaledToMass;
        [FieldOffset(646)] public bool bPushForceScaledToMass;
        [FieldOffset(647)] public bool bPushForceUsingZOffset;
        [FieldOffset(648)] public bool bScalePushForceToVelocity;
        [FieldOffset(652)] public float StandingDownwardForceScale;
        [FieldOffset(656)] public float InitialPushForceFactor;
        [FieldOffset(660)] public float PushForceFactor;
        [FieldOffset(664)] public float PushForcePointZOffsetFactor;
        [FieldOffset(668)] public float TouchForceFactor;
        [FieldOffset(672)] public float MinTouchForce;
        [FieldOffset(676)] public float MaxTouchForce;
        [FieldOffset(680)] public float RepulsionForce;
        [FieldOffset(696)] public Vector Acceleration;
        [FieldOffset(708)] public Vector LastUpdateLocation;
        [FieldOffset(720)] public Quat LastUpdateRotation;
        [FieldOffset(736)] public Vector LastUpdateVelocity;
        [FieldOffset(748)] public float ServerLastTransformUpdateTimeStamp;
        [FieldOffset(752)] public float ServerLastClientGoodMoveAckTime;
        [FieldOffset(756)] public float ServerLastClientAdjustmentTime;
        [FieldOffset(760)] public Vector PendingImpulseToApply;
        [FieldOffset(772)] public Vector PendingForceToApply;
        [FieldOffset(784)] public float AnalogInputModifier;
        [FieldOffset(796)] public float MaxSimulationTimeStep;
        [FieldOffset(800)] public int MaxSimulationIterations;
        [FieldOffset(804)] public float MaxDepenetrationWithGeometry;
        [FieldOffset(808)] public float MaxDepenetrationWithGeometryAsProxy;
        [FieldOffset(812)] public float MaxDepenetrationWithPawn;
        [FieldOffset(816)] public float MaxDepenetrationWithPawnAsProxy;
        [FieldOffset(820)] public float NetworkSimulatedSmoothLocationTime;
        [FieldOffset(824)] public float NetworkSimulatedSmoothRotationTime;
        [FieldOffset(828)] public float ListenServerNetworkSimulatedSmoothLocationTime;
        [FieldOffset(832)] public float ListenServerNetworkSimulatedSmoothRotationTime;
        [FieldOffset(836)] public float NetProxyShrinkRadius;
        [FieldOffset(840)] public float NetProxyShrinkHalfHeight;
        [FieldOffset(844)] public float NetworkMaxSmoothUpdateDistance;
        [FieldOffset(848)] public float NetworkNoSmoothUpdateDistance;
        [FieldOffset(852)] byte NetworkSmoothingMode; //TODO: enum ENetworkSmoothingMode NetworkSmoothingMode
        [FieldOffset(856)] public float NetworkMinTimeBetweenClientAckGoodMoves;
        [FieldOffset(860)] public float NetworkMinTimeBetweenClientAdjustments;
        [FieldOffset(864)] public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;
        [FieldOffset(868)] public float NetworkLargeClientCorrectionDistance;
        [FieldOffset(872)] public float LedgeCheckThreshold;
        [FieldOffset(876)] public float JumpOutOfWaterPitch;
        [FieldOffset(880)] public FindFloorResult CurrentFloor;
        [FieldOffset(1036)] public byte DefaultLandMovementMode;
        [FieldOffset(1037)] public byte DefaultWaterMovementMode;
        [FieldOffset(1038)] public byte GroundMovementMode;
        [FieldOffset(1040)] public bool bMaintainHorizontalGroundVelocity;
        [FieldOffset(1040)] public bool bImpartBaseVelocityX;
        [FieldOffset(1040)] public bool bImpartBaseVelocityY;
        [FieldOffset(1040)] public bool bImpartBaseVelocityZ;
        [FieldOffset(1040)] public bool bImpartBaseAngularVelocity;
        [FieldOffset(1040)] public bool bJustTeleported;
        [FieldOffset(1040)] public bool bNetworkUpdateReceived;
        [FieldOffset(1040)] public bool bNetworkMovementModeChanged;
        [FieldOffset(1041)] public bool bIgnoreClientMovementErrorChecksAndCorrection;
        [FieldOffset(1041)] public bool bNotifyApex;
        [FieldOffset(1041)] public bool bCheatFlying;
        [FieldOffset(1041)] public bool bWantsToCrouch;
        [FieldOffset(1041)] public bool bCrouchMaintainsBaseLocation;
        [FieldOffset(1041)] public bool bIgnoreBaseRotation;
        [FieldOffset(1041)] public bool bFastAttachedMove;
        [FieldOffset(1041)] public bool bAlwaysCheckFloor;
        [FieldOffset(1042)] public bool bUseFlatBaseForFloorChecks;
        [FieldOffset(1042)] public bool bPerformingJumpOff;
        [FieldOffset(1042)] public bool bWantsToLeaveNavWalking;
        [FieldOffset(1042)] public bool bUseRVOAvoidance;
        [FieldOffset(1042)] public bool bRequestedMoveUseAcceleration;
        [FieldOffset(1042)] public bool bHasRequestedVelocity;
        [FieldOffset(1042)] public bool bRequestedMoveWithMaxSpeed;
        [FieldOffset(1043)] public bool bWasAvoidanceUpdated;
        [FieldOffset(1043)] public bool bProjectNavMeshWalking;
        [FieldOffset(1043)] public bool bProjectNavMeshOnBothWorldChannels;
        [FieldOffset(1060)] public float AvoidanceConsiderationRadius;
        [FieldOffset(1064)] public Vector RequestedVelocity;
        [FieldOffset(1076)] public int AvoidanceUID;
        [FieldOffset(1080)] public NavAvoidanceMask AvoidanceGroup;
        [FieldOffset(1084)] public NavAvoidanceMask GroupsToAvoid;
        [FieldOffset(1088)] public NavAvoidanceMask GroupsToIgnore;
        [FieldOffset(1092)] public float AvoidanceWeight;
        [FieldOffset(1096)] public Vector PendingLaunchVelocity;
        [FieldOffset(1280)] public float NavMeshProjectionInterval;
        [FieldOffset(1284)] public float NavMeshProjectionTimer;
        [FieldOffset(1288)] public float NavMeshProjectionInterpSpeed;
        [FieldOffset(1292)] public float NavMeshProjectionHeightScaleUp;
        [FieldOffset(1296)] public float NavMeshProjectionHeightScaleDown;
        [FieldOffset(1300)] public float NavWalkingFloorDistTolerance;
        [FieldOffset(1304)] public CharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction;
        [FieldOffset(1408)] public float MinTimeBetweenTimeStampResets;
        [FieldOffset(1416)] public RootMotionSourceGroup CurrentRootMotion;
        [FieldOffset(1824)] public RootMotionMovementParams RootMotionParams;
        [FieldOffset(1888)] public Vector AnimRootMotionVelocity;
        [FieldOffset(1900)] public bool bWasSimulatingRootMotion;
        [FieldOffset(1904)] public bool bAllowPhysicsRotationDuringAnimRootMotion;
    }
    internal unsafe struct CharacterMovementComponent_methods {
        internal struct AddForce_method {
            static internal IntPtr AddForce_ptr;
            static AddForce_method() {
                AddForce_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "AddForce");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Force) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Force;
                Main.GetProcessEvent(obj, AddForce_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddImpulse_method {
            static internal IntPtr AddImpulse_ptr;
            static AddImpulse_method() {
                AddImpulse_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "AddImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, bool bVelocityChange) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((bool*)(b+12)) = bVelocityChange;
                Main.GetProcessEvent(obj, AddImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CalcVelocity_method {
            static internal IntPtr CalcVelocity_ptr;
            static CalcVelocity_method() {
                CalcVelocity_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "CalcVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DeltaTime;
                *((float*)(b+4)) = Friction;
                *((bool*)(b+8)) = bFluid;
                *((float*)(b+12)) = BrakingDeceleration;
                Main.GetProcessEvent(obj, CalcVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearAccumulatedForces_method {
            static internal IntPtr ClearAccumulatedForces_ptr;
            static ClearAccumulatedForces_method() {
                ClearAccumulatedForces_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "ClearAccumulatedForces");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearAccumulatedForces_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableMovement_method {
            static internal IntPtr DisableMovement_ptr;
            static DisableMovement_method() {
                DisableMovement_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "DisableMovement");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DisableMovement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAnalogInputModifier_method {
            static internal IntPtr GetAnalogInputModifier_ptr;
            static GetAnalogInputModifier_method() {
                GetAnalogInputModifier_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetAnalogInputModifier");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnalogInputModifier_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCharacterOwner_method {
            static internal IntPtr GetCharacterOwner_ptr;
            static GetCharacterOwner_method() {
                GetCharacterOwner_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetCharacterOwner");
            }

            internal static unsafe Character Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCharacterOwner_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetCurrentAcceleration_method {
            static internal IntPtr GetCurrentAcceleration_ptr;
            static GetCurrentAcceleration_method() {
                GetCurrentAcceleration_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetCurrentAcceleration");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentAcceleration_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetImpartedMovementBaseVelocity_method {
            static internal IntPtr GetImpartedMovementBaseVelocity_ptr;
            static GetImpartedMovementBaseVelocity_method() {
                GetImpartedMovementBaseVelocity_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetImpartedMovementBaseVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetImpartedMovementBaseVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetMaxAcceleration_method {
            static internal IntPtr GetMaxAcceleration_ptr;
            static GetMaxAcceleration_method() {
                GetMaxAcceleration_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMaxAcceleration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxAcceleration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMaxBrakingDeceleration_method {
            static internal IntPtr GetMaxBrakingDeceleration_ptr;
            static GetMaxBrakingDeceleration_method() {
                GetMaxBrakingDeceleration_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMaxBrakingDeceleration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxBrakingDeceleration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMaxJumpHeight_method {
            static internal IntPtr GetMaxJumpHeight_ptr;
            static GetMaxJumpHeight_method() {
                GetMaxJumpHeight_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMaxJumpHeight");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxJumpHeight_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMaxJumpHeightWithJumpTime_method {
            static internal IntPtr GetMaxJumpHeightWithJumpTime_ptr;
            static GetMaxJumpHeightWithJumpTime_method() {
                GetMaxJumpHeightWithJumpTime_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMaxJumpHeightWithJumpTime");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxJumpHeightWithJumpTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMinAnalogSpeed_method {
            static internal IntPtr GetMinAnalogSpeed_ptr;
            static GetMinAnalogSpeed_method() {
                GetMinAnalogSpeed_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMinAnalogSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMinAnalogSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMovementBase_method {
            static internal IntPtr GetMovementBase_ptr;
            static GetMovementBase_method() {
                GetMovementBase_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetMovementBase");
            }

            internal static unsafe PrimitiveComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMovementBase_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetPerchRadiusThreshold_method {
            static internal IntPtr GetPerchRadiusThreshold_ptr;
            static GetPerchRadiusThreshold_method() {
                GetPerchRadiusThreshold_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetPerchRadiusThreshold");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPerchRadiusThreshold_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetValidPerchRadius_method {
            static internal IntPtr GetValidPerchRadius_ptr;
            static GetValidPerchRadius_method() {
                GetValidPerchRadius_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "GetValidPerchRadius");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetValidPerchRadius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsWalkable_method {
            static internal IntPtr IsWalkable_ptr;
            static IsWalkable_method() {
                IsWalkable_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "IsWalkable");
            }

            internal static unsafe bool Invoke(IntPtr obj, HitResult Hit) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = Hit;
                Main.GetProcessEvent(obj, IsWalkable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+144));
            }
        }
        internal struct IsWalking_method {
            static internal IntPtr IsWalking_ptr;
            static IsWalking_method() {
                IsWalking_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "IsWalking");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsWalking_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_ComputeFloorDist_method {
            static internal IntPtr K2_ComputeFloorDist_ptr;
            static K2_ComputeFloorDist_method() {
                K2_ComputeFloorDist_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "K2_ComputeFloorDist");
            }

            internal static unsafe FindFloorResult Invoke(IntPtr obj, Vector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = CapsuleLocation;
                *((float*)(b+12)) = LineDistance;
                *((float*)(b+16)) = SweepDistance;
                *((float*)(b+20)) = SweepRadius;
                Main.GetProcessEvent(obj, K2_ComputeFloorDist_ptr, new IntPtr(p)); ;
                return *((FindFloorResult*)(b+24));
            }
        }
        internal struct K2_FindFloor_method {
            static internal IntPtr K2_FindFloor_ptr;
            static K2_FindFloor_method() {
                K2_FindFloor_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "K2_FindFloor");
            }

            internal static unsafe FindFloorResult Invoke(IntPtr obj, Vector CapsuleLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = CapsuleLocation;
                Main.GetProcessEvent(obj, K2_FindFloor_ptr, new IntPtr(p)); ;
                return *((FindFloorResult*)(b+12));
            }
        }
        internal struct K2_GetModifiedMaxAcceleration_method {
            static internal IntPtr K2_GetModifiedMaxAcceleration_ptr;
            static K2_GetModifiedMaxAcceleration_method() {
                K2_GetModifiedMaxAcceleration_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "K2_GetModifiedMaxAcceleration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetModifiedMaxAcceleration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct K2_GetWalkableFloorAngle_method {
            static internal IntPtr K2_GetWalkableFloorAngle_ptr;
            static K2_GetWalkableFloorAngle_method() {
                K2_GetWalkableFloorAngle_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "K2_GetWalkableFloorAngle");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetWalkableFloorAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct K2_GetWalkableFloorZ_method {
            static internal IntPtr K2_GetWalkableFloorZ_ptr;
            static K2_GetWalkableFloorZ_method() {
                K2_GetWalkableFloorZ_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "K2_GetWalkableFloorZ");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetWalkableFloorZ_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetAvoidanceEnabled_method {
            static internal IntPtr SetAvoidanceEnabled_ptr;
            static SetAvoidanceEnabled_method() {
                SetAvoidanceEnabled_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetAvoidanceEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(obj, SetAvoidanceEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAvoidanceGroup_method {
            static internal IntPtr SetAvoidanceGroup_ptr;
            static SetAvoidanceGroup_method() {
                SetAvoidanceGroup_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetAvoidanceGroup");
            }

            internal static unsafe void Invoke(IntPtr obj, int GroupFlags) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = GroupFlags;
                Main.GetProcessEvent(obj, SetAvoidanceGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAvoidanceGroupMask_method {
            static internal IntPtr SetAvoidanceGroupMask_ptr;
            static SetAvoidanceGroupMask_method() {
                SetAvoidanceGroupMask_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetAvoidanceGroupMask");
            }

            internal static unsafe void Invoke(IntPtr obj, NavAvoidanceMask GroupMask) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((NavAvoidanceMask*)(b+0)) = GroupMask;
                Main.GetProcessEvent(obj, SetAvoidanceGroupMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupsToAvoid_method {
            static internal IntPtr SetGroupsToAvoid_ptr;
            static SetGroupsToAvoid_method() {
                SetGroupsToAvoid_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetGroupsToAvoid");
            }

            internal static unsafe void Invoke(IntPtr obj, int GroupFlags) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = GroupFlags;
                Main.GetProcessEvent(obj, SetGroupsToAvoid_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupsToAvoidMask_method {
            static internal IntPtr SetGroupsToAvoidMask_ptr;
            static SetGroupsToAvoidMask_method() {
                SetGroupsToAvoidMask_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetGroupsToAvoidMask");
            }

            internal static unsafe void Invoke(IntPtr obj, NavAvoidanceMask GroupMask) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((NavAvoidanceMask*)(b+0)) = GroupMask;
                Main.GetProcessEvent(obj, SetGroupsToAvoidMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupsToIgnore_method {
            static internal IntPtr SetGroupsToIgnore_ptr;
            static SetGroupsToIgnore_method() {
                SetGroupsToIgnore_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetGroupsToIgnore");
            }

            internal static unsafe void Invoke(IntPtr obj, int GroupFlags) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = GroupFlags;
                Main.GetProcessEvent(obj, SetGroupsToIgnore_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupsToIgnoreMask_method {
            static internal IntPtr SetGroupsToIgnoreMask_ptr;
            static SetGroupsToIgnoreMask_method() {
                SetGroupsToIgnoreMask_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetGroupsToIgnoreMask");
            }

            internal static unsafe void Invoke(IntPtr obj, NavAvoidanceMask GroupMask) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((NavAvoidanceMask*)(b+0)) = GroupMask;
                Main.GetProcessEvent(obj, SetGroupsToIgnoreMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMovementMode_method {
            static internal IntPtr SetMovementMode_ptr;
            static SetMovementMode_method() {
                SetMovementMode_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetMovementMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewMovementMode, byte NewCustomMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewMovementMode;
                *(b+1) = NewCustomMode;
                Main.GetProcessEvent(obj, SetMovementMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWalkableFloorAngle_method {
            static internal IntPtr SetWalkableFloorAngle_ptr;
            static SetWalkableFloorAngle_method() {
                SetWalkableFloorAngle_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetWalkableFloorAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float InWalkableFloorAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InWalkableFloorAngle;
                Main.GetProcessEvent(obj, SetWalkableFloorAngle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWalkableFloorZ_method {
            static internal IntPtr SetWalkableFloorZ_ptr;
            static SetWalkableFloorZ_method() {
                SetWalkableFloorZ_ptr = Main.GetMethodUFunction(CharacterMovementComponent.StaticClass, "SetWalkableFloorZ");
            }

            internal static unsafe void Invoke(IntPtr obj, float InWalkableFloorZ) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InWalkableFloorZ;
                Main.GetProcessEvent(obj, SetWalkableFloorZ_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CharacterMovementComponent_events {
    }
}
