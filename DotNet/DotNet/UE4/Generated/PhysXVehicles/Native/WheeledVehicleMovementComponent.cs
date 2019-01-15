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

namespace UE4.PhysXVehicles.Native {
    [StructLayout( LayoutKind.Explicit, Size=776 )]
    internal unsafe struct WheeledVehicleMovementComponent_fields {
        [FieldOffset(424)] public bool bDeprecatedSpringOffsetMode;
        [FieldOffset(432)] public NativeArray WheelSetups;
        [FieldOffset(448)] public float Mass;
        [FieldOffset(452)] public float DragCoefficient;
        [FieldOffset(456)] public float ChassisWidth;
        [FieldOffset(460)] public float ChassisHeight;
        [FieldOffset(464)] public bool bReverseAsBrake;
        [FieldOffset(468)] public float DragArea;
        [FieldOffset(472)] public float EstimatedMaxEngineSpeed;
        [FieldOffset(476)] public float MaxEngineRPM;
        [FieldOffset(480)] public float DebugDragMagnitude;
        [FieldOffset(484)] public Vector InertiaTensorScale;
        [FieldOffset(496)] public float MinNormalizedTireLoad;
        [FieldOffset(500)] public float MinNormalizedTireLoadFiltered;
        [FieldOffset(504)] public float MaxNormalizedTireLoad;
        [FieldOffset(508)] public float MaxNormalizedTireLoadFiltered;
        [FieldOffset(512)] public float ThresholdLongitudinalSpeed;
        [FieldOffset(516)] public int LowForwardSpeedSubStepCount;
        [FieldOffset(520)] public int HighForwardSpeedSubStepCount;
        [FieldOffset(528)] public NativeArray Wheels;
        [FieldOffset(568)] public bool bUseRVOAvoidance;
        [FieldOffset(572)] public float RVOAvoidanceRadius;
        [FieldOffset(576)] public float RVOAvoidanceHeight;
        [FieldOffset(580)] public float AvoidanceConsiderationRadius;
        [FieldOffset(584)] public float RVOSteeringStep;
        [FieldOffset(588)] public float RVOThrottleStep;
        [FieldOffset(592)] public int AvoidanceUID;
        [FieldOffset(596)] public NavAvoidanceMask AvoidanceGroup;
        [FieldOffset(600)] public NavAvoidanceMask GroupsToAvoid;
        [FieldOffset(604)] public NavAvoidanceMask GroupsToIgnore;
        [FieldOffset(608)] public float AvoidanceWeight;
        [FieldOffset(612)] public Vector PendingLaunchVelocity;
        [FieldOffset(624)] public ReplicatedVehicleState ReplicatedState;
        [FieldOffset(648)] public float RawSteeringInput;
        [FieldOffset(652)] public float RawThrottleInput;
        [FieldOffset(656)] public float RawBrakeInput;
        [FieldOffset(660)] public bool bRawHandbrakeInput;
        [FieldOffset(660)] public bool bRawGearUpInput;
        [FieldOffset(660)] public bool bRawGearDownInput;
        [FieldOffset(664)] public float SteeringInput;
        [FieldOffset(668)] public float ThrottleInput;
        [FieldOffset(672)] public float BrakeInput;
        [FieldOffset(676)] public float HandbrakeInput;
        [FieldOffset(680)] public float IdleBrakeInput;
        [FieldOffset(684)] public float StopThreshold;
        [FieldOffset(688)] public float WrongDirectionThreshold;
        [FieldOffset(692)] public VehicleInputRate ThrottleInputRate;
        [FieldOffset(700)] public VehicleInputRate BrakeInputRate;
        [FieldOffset(708)] public VehicleInputRate HandbrakeInputRate;
        [FieldOffset(716)] public VehicleInputRate SteeringInputRate;
        [FieldOffset(724)] public bool bWasAvoidanceUpdated;
        [FieldOffset(768)]  public IntPtr  OverrideController;
    }
    internal unsafe struct WheeledVehicleMovementComponent_methods {
        internal struct GetCurrentGear_method {
            static internal IntPtr GetCurrentGear_ptr;
            static GetCurrentGear_method() {
                GetCurrentGear_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetCurrentGear");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentGear_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetEngineMaxRotationSpeed_method {
            static internal IntPtr GetEngineMaxRotationSpeed_ptr;
            static GetEngineMaxRotationSpeed_method() {
                GetEngineMaxRotationSpeed_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetEngineMaxRotationSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEngineMaxRotationSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetEngineRotationSpeed_method {
            static internal IntPtr GetEngineRotationSpeed_ptr;
            static GetEngineRotationSpeed_method() {
                GetEngineRotationSpeed_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetEngineRotationSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEngineRotationSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetForwardSpeed_method {
            static internal IntPtr GetForwardSpeed_ptr;
            static GetForwardSpeed_method() {
                GetForwardSpeed_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetForwardSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetForwardSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTargetGear_method {
            static internal IntPtr GetTargetGear_ptr;
            static GetTargetGear_method() {
                GetTargetGear_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetTargetGear");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTargetGear_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetUseAutoGears_method {
            static internal IntPtr GetUseAutoGears_ptr;
            static GetUseAutoGears_method() {
                GetUseAutoGears_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "GetUseAutoGears");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUseAutoGears_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetAvoidanceEnabled_method {
            static internal IntPtr SetAvoidanceEnabled_ptr;
            static SetAvoidanceEnabled_method() {
                SetAvoidanceEnabled_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetAvoidanceEnabled");
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
                SetAvoidanceGroup_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetAvoidanceGroup");
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
                SetAvoidanceGroupMask_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetAvoidanceGroupMask");
            }

            internal static unsafe void Invoke(IntPtr obj, NavAvoidanceMask GroupMask) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((NavAvoidanceMask*)(b+0)) = GroupMask;
                Main.GetProcessEvent(obj, SetAvoidanceGroupMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrakeInput_method {
            static internal IntPtr SetBrakeInput_ptr;
            static SetBrakeInput_method() {
                SetBrakeInput_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetBrakeInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Brake) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Brake;
                Main.GetProcessEvent(obj, SetBrakeInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGearDown_method {
            static internal IntPtr SetGearDown_ptr;
            static SetGearDown_method() {
                SetGearDown_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGearDown");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewGearDown) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewGearDown;
                Main.GetProcessEvent(obj, SetGearDown_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGearUp_method {
            static internal IntPtr SetGearUp_ptr;
            static SetGearUp_method() {
                SetGearUp_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGearUp");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewGearUp) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewGearUp;
                Main.GetProcessEvent(obj, SetGearUp_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupsToAvoid_method {
            static internal IntPtr SetGroupsToAvoid_ptr;
            static SetGroupsToAvoid_method() {
                SetGroupsToAvoid_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGroupsToAvoid");
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
                SetGroupsToAvoidMask_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGroupsToAvoidMask");
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
                SetGroupsToIgnore_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGroupsToIgnore");
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
                SetGroupsToIgnoreMask_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetGroupsToIgnoreMask");
            }

            internal static unsafe void Invoke(IntPtr obj, NavAvoidanceMask GroupMask) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((NavAvoidanceMask*)(b+0)) = GroupMask;
                Main.GetProcessEvent(obj, SetGroupsToIgnoreMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHandbrakeInput_method {
            static internal IntPtr SetHandbrakeInput_ptr;
            static SetHandbrakeInput_method() {
                SetHandbrakeInput_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetHandbrakeInput");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewHandbrake) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewHandbrake;
                Main.GetProcessEvent(obj, SetHandbrakeInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSteeringInput_method {
            static internal IntPtr SetSteeringInput_ptr;
            static SetSteeringInput_method() {
                SetSteeringInput_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetSteeringInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Steering) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Steering;
                Main.GetProcessEvent(obj, SetSteeringInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTargetGear_method {
            static internal IntPtr SetTargetGear_ptr;
            static SetTargetGear_method() {
                SetTargetGear_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetTargetGear");
            }

            internal static unsafe void Invoke(IntPtr obj, int GearNum, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = GearNum;
                *((bool*)(b+4)) = bImmediate;
                Main.GetProcessEvent(obj, SetTargetGear_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetThrottleInput_method {
            static internal IntPtr SetThrottleInput_ptr;
            static SetThrottleInput_method() {
                SetThrottleInput_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetThrottleInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Throttle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Throttle;
                Main.GetProcessEvent(obj, SetThrottleInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUseAutoGears_method {
            static internal IntPtr SetUseAutoGears_ptr;
            static SetUseAutoGears_method() {
                SetUseAutoGears_ptr = Main.GetMethodUFunction(WheeledVehicleMovementComponent.StaticClass, "SetUseAutoGears");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bUseAuto) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bUseAuto;
                Main.GetProcessEvent(obj, SetUseAutoGears_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WheeledVehicleMovementComponent_events {
    }
}
