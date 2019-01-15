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
using UE4.PhysXVehicles.Native;
using UE4.Engine;

namespace UE4.PhysXVehicles {
    ///<summary>Component to handle the vehicle simulation for an actor.</summary>
    public unsafe partial class WheeledVehicleMovementComponent : PawnMovementComponent  {

        ///<summary>Get current gear</summary>
        public int GetCurrentGear()  => 
            WheeledVehicleMovementComponent_methods.GetCurrentGear_method.Invoke(ObjPointer);

        ///<summary>Get current engine's max rotation speed</summary>
        public float GetEngineMaxRotationSpeed()  => 
            WheeledVehicleMovementComponent_methods.GetEngineMaxRotationSpeed_method.Invoke(ObjPointer);

        ///<summary>Get current engine's rotation speed</summary>
        public float GetEngineRotationSpeed()  => 
            WheeledVehicleMovementComponent_methods.GetEngineRotationSpeed_method.Invoke(ObjPointer);

        ///<summary>How fast the vehicle is moving forward</summary>
        public float GetForwardSpeed()  => 
            WheeledVehicleMovementComponent_methods.GetForwardSpeed_method.Invoke(ObjPointer);

        ///<summary>Get target gear</summary>
        public int GetTargetGear()  => 
            WheeledVehicleMovementComponent_methods.GetTargetGear_method.Invoke(ObjPointer);

        ///<summary>Are gears being changed automatically?</summary>
        public bool GetUseAutoGears()  => 
            WheeledVehicleMovementComponent_methods.GetUseAutoGears_method.Invoke(ObjPointer);

        ///<summary>Change avoidance state and register with RVO manager if necessary</summary>
        public void SetAvoidanceEnabled(bool bEnable)  => 
            WheeledVehicleMovementComponent_methods.SetAvoidanceEnabled_method.Invoke(ObjPointer, bEnable);

        ///<summary>Set Avoidance Group</summary>
        public void SetAvoidanceGroup(int GroupFlags)  => 
            WheeledVehicleMovementComponent_methods.SetAvoidanceGroup_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Avoidance Group Mask</summary>
        public void SetAvoidanceGroupMask(NavAvoidanceMask GroupMask)  => 
            WheeledVehicleMovementComponent_methods.SetAvoidanceGroupMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Set the user input for the vehicle Brake</summary>
        public void SetBrakeInput(float Brake)  => 
            WheeledVehicleMovementComponent_methods.SetBrakeInput_method.Invoke(ObjPointer, Brake);

        ///<summary>Set the user input for gear down</summary>
        public void SetGearDown(bool bNewGearDown)  => 
            WheeledVehicleMovementComponent_methods.SetGearDown_method.Invoke(ObjPointer, bNewGearDown);

        ///<summary>Set the user input for gear up</summary>
        public void SetGearUp(bool bNewGearUp)  => 
            WheeledVehicleMovementComponent_methods.SetGearUp_method.Invoke(ObjPointer, bNewGearUp);

        ///<summary>Set Groups to Avoid</summary>
        public void SetGroupsToAvoid(int GroupFlags)  => 
            WheeledVehicleMovementComponent_methods.SetGroupsToAvoid_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Groups to Avoid Mask</summary>
        public void SetGroupsToAvoidMask(NavAvoidanceMask GroupMask)  => 
            WheeledVehicleMovementComponent_methods.SetGroupsToAvoidMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Set Groups to Ignore</summary>
        public void SetGroupsToIgnore(int GroupFlags)  => 
            WheeledVehicleMovementComponent_methods.SetGroupsToIgnore_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Groups to Ignore Mask</summary>
        public void SetGroupsToIgnoreMask(NavAvoidanceMask GroupMask)  => 
            WheeledVehicleMovementComponent_methods.SetGroupsToIgnoreMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Set the user input for handbrake</summary>
        public void SetHandbrakeInput(bool bNewHandbrake)  => 
            WheeledVehicleMovementComponent_methods.SetHandbrakeInput_method.Invoke(ObjPointer, bNewHandbrake);

        ///<summary>Set the user input for the vehicle steering</summary>
        public void SetSteeringInput(float Steering)  => 
            WheeledVehicleMovementComponent_methods.SetSteeringInput_method.Invoke(ObjPointer, Steering);

        ///<summary>Set the user input for gear (-1 reverse, 0 neutral, 1+ forward)</summary>
        public void SetTargetGear(int GearNum, bool bImmediate)  => 
            WheeledVehicleMovementComponent_methods.SetTargetGear_method.Invoke(ObjPointer, GearNum, bImmediate);

        ///<summary>Set the user input for the vehicle throttle</summary>
        public void SetThrottleInput(float Throttle)  => 
            WheeledVehicleMovementComponent_methods.SetThrottleInput_method.Invoke(ObjPointer, Throttle);

        ///<summary>Set the flag that will be used to select auto-gears</summary>
        public void SetUseAutoGears(bool bUseAuto)  => 
            WheeledVehicleMovementComponent_methods.SetUseAutoGears_method.Invoke(ObjPointer, bUseAuto);
        public bool bDeprecatedSpringOffsetMode {
            get {return Main.GetGetBoolPropertyByName(this, "bDeprecatedSpringOffsetMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeprecatedSpringOffsetMode", value); }
        }
         //TODO: array not UObject TArray WheelSetups
        ///<summary>Mass to set the vehicle chassis to.</summary>
        ///<remarks>
        ///It's much easier to tweak vehicle settings when
        ///the mass doesn't change due to tweaks with the physics asset. [kg]
        ///</remarks>
        public unsafe float Mass {
            get {return WheeledVehicleMovementComponent_ptr->Mass;}
            set {WheeledVehicleMovementComponent_ptr->Mass = value;}
        }
        ///<summary>DragCoefficient of the vehicle chassis.</summary>
        public unsafe float DragCoefficient {
            get {return WheeledVehicleMovementComponent_ptr->DragCoefficient;}
            set {WheeledVehicleMovementComponent_ptr->DragCoefficient = value;}
        }
        ///<summary>Chassis width used for drag force computation (cm)</summary>
        public unsafe float ChassisWidth {
            get {return WheeledVehicleMovementComponent_ptr->ChassisWidth;}
            set {WheeledVehicleMovementComponent_ptr->ChassisWidth = value;}
        }
        ///<summary>Chassis height used for drag force computation (cm)</summary>
        public unsafe float ChassisHeight {
            get {return WheeledVehicleMovementComponent_ptr->ChassisHeight;}
            set {WheeledVehicleMovementComponent_ptr->ChassisHeight = value;}
        }
        public bool bReverseAsBrake {
            get {return Main.GetGetBoolPropertyByName(this, "bReverseAsBrake"); }
            set {Main.SetGetBoolPropertyByName(this, "bReverseAsBrake", value); }
        }
        ///<summary>Drag area in cm^2</summary>
        public unsafe float DragArea {
            get {return WheeledVehicleMovementComponent_ptr->DragArea;}
            set {WheeledVehicleMovementComponent_ptr->DragArea = value;}
        }
        ///<summary>Estimated mad speed for engine</summary>
        public unsafe float EstimatedMaxEngineSpeed {
            get {return WheeledVehicleMovementComponent_ptr->EstimatedMaxEngineSpeed;}
            set {WheeledVehicleMovementComponent_ptr->EstimatedMaxEngineSpeed = value;}
        }
        ///<summary>Max RPM for engine</summary>
        public unsafe float MaxEngineRPM {
            get {return WheeledVehicleMovementComponent_ptr->MaxEngineRPM;}
            set {WheeledVehicleMovementComponent_ptr->MaxEngineRPM = value;}
        }
        ///<summary>Debug drag magnitude last applied</summary>
        public unsafe float DebugDragMagnitude {
            get {return WheeledVehicleMovementComponent_ptr->DebugDragMagnitude;}
            set {WheeledVehicleMovementComponent_ptr->DebugDragMagnitude = value;}
        }
        ///<summary>Scales the vehicle's inertia in each direction (forward, right, up)</summary>
        public unsafe Vector InertiaTensorScale {
            get {return WheeledVehicleMovementComponent_ptr->InertiaTensorScale;}
            set {WheeledVehicleMovementComponent_ptr->InertiaTensorScale = value;}
        }
        ///<summary>Clamp normalized tire load to this value</summary>
        public unsafe float MinNormalizedTireLoad {
            get {return WheeledVehicleMovementComponent_ptr->MinNormalizedTireLoad;}
            set {WheeledVehicleMovementComponent_ptr->MinNormalizedTireLoad = value;}
        }
        ///<summary>Clamp normalized tire load to this value</summary>
        public unsafe float MinNormalizedTireLoadFiltered {
            get {return WheeledVehicleMovementComponent_ptr->MinNormalizedTireLoadFiltered;}
            set {WheeledVehicleMovementComponent_ptr->MinNormalizedTireLoadFiltered = value;}
        }
        ///<summary>Clamp normalized tire load to this value</summary>
        public unsafe float MaxNormalizedTireLoad {
            get {return WheeledVehicleMovementComponent_ptr->MaxNormalizedTireLoad;}
            set {WheeledVehicleMovementComponent_ptr->MaxNormalizedTireLoad = value;}
        }
        ///<summary>Clamp normalized tire load to this value</summary>
        public unsafe float MaxNormalizedTireLoadFiltered {
            get {return WheeledVehicleMovementComponent_ptr->MaxNormalizedTireLoadFiltered;}
            set {WheeledVehicleMovementComponent_ptr->MaxNormalizedTireLoadFiltered = value;}
        }
        ///<summary>
        ///PhysX sub-steps
        ///    More sub-steps provides better stability but with greater computational cost.
        ///</summary>
        ///<remarks>
        ///Typically, vehicles require more sub-steps at very low forward speeds.
        ///    The threshold longitudinal speed has a default value of 5 metres per second.
        ///</remarks>
        public unsafe float ThresholdLongitudinalSpeed {
            get {return WheeledVehicleMovementComponent_ptr->ThresholdLongitudinalSpeed;}
            set {WheeledVehicleMovementComponent_ptr->ThresholdLongitudinalSpeed = value;}
        }
        ///<summary>The sub-step count below the threshold longitudinal speed has a default of 3.</summary>
        public unsafe int LowForwardSpeedSubStepCount {
            get {return WheeledVehicleMovementComponent_ptr->LowForwardSpeedSubStepCount;}
            set {WheeledVehicleMovementComponent_ptr->LowForwardSpeedSubStepCount = value;}
        }
        ///<summary>The sub-step count above the threshold longitudinal speed has a default of 1.</summary>
        public unsafe int HighForwardSpeedSubStepCount {
            get {return WheeledVehicleMovementComponent_ptr->HighForwardSpeedSubStepCount;}
            set {WheeledVehicleMovementComponent_ptr->HighForwardSpeedSubStepCount = value;}
        }
        ///<summary>Our instanced wheels</summary>
        public ObjectArrayField<VehicleWheel> Wheels{ get {
            if(Wheels_store == null) Wheels_store = new ObjectArrayField<VehicleWheel> (&WheeledVehicleMovementComponent_ptr->Wheels);
            return Wheels_store;
        } }
        private ObjectArrayField<VehicleWheel> Wheels_store;

        public bool bUseRVOAvoidance {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRVOAvoidance"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseRVOAvoidance", value); }
        }
        ///<summary>Vehicle Radius to use for RVO avoidance (usually half of vehicle width)</summary>
        public unsafe float RVOAvoidanceRadius {
            get {return WheeledVehicleMovementComponent_ptr->RVOAvoidanceRadius;}
            set {WheeledVehicleMovementComponent_ptr->RVOAvoidanceRadius = value;}
        }
        ///<summary>Vehicle Height to use for RVO avoidance (usually vehicle height)</summary>
        public unsafe float RVOAvoidanceHeight {
            get {return WheeledVehicleMovementComponent_ptr->RVOAvoidanceHeight;}
            set {WheeledVehicleMovementComponent_ptr->RVOAvoidanceHeight = value;}
        }
        ///<summary>Area Radius to consider for RVO avoidance</summary>
        public unsafe float AvoidanceConsiderationRadius {
            get {return WheeledVehicleMovementComponent_ptr->AvoidanceConsiderationRadius;}
            set {WheeledVehicleMovementComponent_ptr->AvoidanceConsiderationRadius = value;}
        }
        ///<summary>Value by which to alter steering per frame based on calculated avoidance</summary>
        public unsafe float RVOSteeringStep {
            get {return WheeledVehicleMovementComponent_ptr->RVOSteeringStep;}
            set {WheeledVehicleMovementComponent_ptr->RVOSteeringStep = value;}
        }
        ///<summary>Value by which to alter throttle per frame based on calculated avoidance</summary>
        public unsafe float RVOThrottleStep {
            get {return WheeledVehicleMovementComponent_ptr->RVOThrottleStep;}
            set {WheeledVehicleMovementComponent_ptr->RVOThrottleStep = value;}
        }
        ///<summary>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
        public unsafe int AvoidanceUID {
            get {return WheeledVehicleMovementComponent_ptr->AvoidanceUID;}
        }
        ///<summary>Moving actor's group mask</summary>
        public unsafe NavAvoidanceMask AvoidanceGroup {
            get {return WheeledVehicleMovementComponent_ptr->AvoidanceGroup;}
        }
        ///<summary>Will avoid other agents if they are in one of specified groups</summary>
        public unsafe NavAvoidanceMask GroupsToAvoid {
            get {return WheeledVehicleMovementComponent_ptr->GroupsToAvoid;}
        }
        ///<summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
        public unsafe NavAvoidanceMask GroupsToIgnore {
            get {return WheeledVehicleMovementComponent_ptr->GroupsToIgnore;}
        }
        ///<summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
        public unsafe float AvoidanceWeight {
            get {return WheeledVehicleMovementComponent_ptr->AvoidanceWeight;}
        }
        ///<summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
        public unsafe Vector PendingLaunchVelocity {
            get {return WheeledVehicleMovementComponent_ptr->PendingLaunchVelocity;}
            set {WheeledVehicleMovementComponent_ptr->PendingLaunchVelocity = value;}
        }
        ///<summary>replicated state of vehicle</summary>
        public unsafe ReplicatedVehicleState ReplicatedState {
            get {return WheeledVehicleMovementComponent_ptr->ReplicatedState;}
            set {WheeledVehicleMovementComponent_ptr->ReplicatedState = value;}
        }
        ///<summary>What the player has the steering set to. Range -1...1</summary>
        public unsafe float RawSteeringInput {
            get {return WheeledVehicleMovementComponent_ptr->RawSteeringInput;}
            set {WheeledVehicleMovementComponent_ptr->RawSteeringInput = value;}
        }
        ///<summary>What the player has the accelerator set to. Range -1...1</summary>
        public unsafe float RawThrottleInput {
            get {return WheeledVehicleMovementComponent_ptr->RawThrottleInput;}
            set {WheeledVehicleMovementComponent_ptr->RawThrottleInput = value;}
        }
        ///<summary>What the player has the brake set to. Range -1...1</summary>
        public unsafe float RawBrakeInput {
            get {return WheeledVehicleMovementComponent_ptr->RawBrakeInput;}
            set {WheeledVehicleMovementComponent_ptr->RawBrakeInput = value;}
        }
        public bool bRawHandbrakeInput {
            get {return Main.GetGetBoolPropertyByName(this, "bRawHandbrakeInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bRawHandbrakeInput", value); }
        }
        public bool bRawGearUpInput {
            get {return Main.GetGetBoolPropertyByName(this, "bRawGearUpInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bRawGearUpInput", value); }
        }
        public bool bRawGearDownInput {
            get {return Main.GetGetBoolPropertyByName(this, "bRawGearDownInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bRawGearDownInput", value); }
        }
        ///<summary>Steering output to physics system. Range -1...1</summary>
        public unsafe float SteeringInput {
            get {return WheeledVehicleMovementComponent_ptr->SteeringInput;}
            set {WheeledVehicleMovementComponent_ptr->SteeringInput = value;}
        }
        ///<summary>Accelerator output to physics system. Range 0...1</summary>
        public unsafe float ThrottleInput {
            get {return WheeledVehicleMovementComponent_ptr->ThrottleInput;}
            set {WheeledVehicleMovementComponent_ptr->ThrottleInput = value;}
        }
        ///<summary>Brake output to physics system. Range 0...1</summary>
        public unsafe float BrakeInput {
            get {return WheeledVehicleMovementComponent_ptr->BrakeInput;}
            set {WheeledVehicleMovementComponent_ptr->BrakeInput = value;}
        }
        ///<summary>Handbrake output to physics system. Range 0...1</summary>
        public unsafe float HandbrakeInput {
            get {return WheeledVehicleMovementComponent_ptr->HandbrakeInput;}
            set {WheeledVehicleMovementComponent_ptr->HandbrakeInput = value;}
        }
        ///<summary>How much to press the brake when the player has release throttle</summary>
        public unsafe float IdleBrakeInput {
            get {return WheeledVehicleMovementComponent_ptr->IdleBrakeInput;}
            set {WheeledVehicleMovementComponent_ptr->IdleBrakeInput = value;}
        }
        ///<summary>Auto-brake when absolute vehicle forward speed is less than this (cm/s)</summary>
        public unsafe float StopThreshold {
            get {return WheeledVehicleMovementComponent_ptr->StopThreshold;}
            set {WheeledVehicleMovementComponent_ptr->StopThreshold = value;}
        }
        ///<summary>Auto-brake when vehicle forward speed is opposite of player input by at least this much (cm/s)</summary>
        public unsafe float WrongDirectionThreshold {
            get {return WheeledVehicleMovementComponent_ptr->WrongDirectionThreshold;}
            set {WheeledVehicleMovementComponent_ptr->WrongDirectionThreshold = value;}
        }
        ///<summary>Rate at which input throttle can rise and fall</summary>
        public unsafe VehicleInputRate ThrottleInputRate {
            get {return WheeledVehicleMovementComponent_ptr->ThrottleInputRate;}
            set {WheeledVehicleMovementComponent_ptr->ThrottleInputRate = value;}
        }
        ///<summary>Rate at which input brake can rise and fall</summary>
        public unsafe VehicleInputRate BrakeInputRate {
            get {return WheeledVehicleMovementComponent_ptr->BrakeInputRate;}
            set {WheeledVehicleMovementComponent_ptr->BrakeInputRate = value;}
        }
        ///<summary>Rate at which input handbrake can rise and fall</summary>
        public unsafe VehicleInputRate HandbrakeInputRate {
            get {return WheeledVehicleMovementComponent_ptr->HandbrakeInputRate;}
            set {WheeledVehicleMovementComponent_ptr->HandbrakeInputRate = value;}
        }
        ///<summary>Rate at which input steering can rise and fall</summary>
        public unsafe VehicleInputRate SteeringInputRate {
            get {return WheeledVehicleMovementComponent_ptr->SteeringInputRate;}
            set {WheeledVehicleMovementComponent_ptr->SteeringInputRate = value;}
        }
        public bool bWasAvoidanceUpdated {
            get {return Main.GetGetBoolPropertyByName(this, "bWasAvoidanceUpdated"); }
            set {Main.SetGetBoolPropertyByName(this, "bWasAvoidanceUpdated", value); }
        }
        ///<summary>Override Controller</summary>
        public unsafe Controller OverrideController {
            get {return WheeledVehicleMovementComponent_ptr->OverrideController;}
            set {WheeledVehicleMovementComponent_ptr->OverrideController = value;}
        }
        static WheeledVehicleMovementComponent() {
            StaticClass = Main.GetClass("WheeledVehicleMovementComponent");
        }
        internal unsafe WheeledVehicleMovementComponent_fields* WheeledVehicleMovementComponent_ptr => (WheeledVehicleMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WheeledVehicleMovementComponent(IntPtr p) => UObject.Make<WheeledVehicleMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WheeledVehicleMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WheeledVehicleMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
