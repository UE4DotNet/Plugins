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
    ///<summary>Vehicle Wheel</summary>
    public unsafe partial class VehicleWheel : UObject  {

        ///<summary>Get Rotation Angle</summary>
        public float GetRotationAngle()  => 
            VehicleWheel_methods.GetRotationAngle_method.Invoke(ObjPointer);

        ///<summary>Get Steer Angle</summary>
        public float GetSteerAngle()  => 
            VehicleWheel_methods.GetSteerAngle_method.Invoke(ObjPointer);

        ///<summary>Get Suspension Offset</summary>
        public float GetSuspensionOffset()  => 
            VehicleWheel_methods.GetSuspensionOffset_method.Invoke(ObjPointer);

        ///<summary>Is in Air</summary>
        public bool IsInAir()  => 
            VehicleWheel_methods.IsInAir_method.Invoke(ObjPointer);
        ///<summary>Static mesh with collision setup for wheel, will be used to create wheel shape</summary>
        ///<remarks>(if empty, sphere will be added as wheel shape, check bDontCreateShape flag)</remarks>
        public unsafe StaticMesh CollisionMesh {
            get {return VehicleWheel_ptr->CollisionMesh;}
            set {VehicleWheel_ptr->CollisionMesh = value;}
        }
        public bool bDontCreateShape {
            get {return Main.GetGetBoolPropertyByName(this, "bDontCreateShape"); }
            set {Main.SetGetBoolPropertyByName(this, "bDontCreateShape", value); }
        }
        public bool bAutoAdjustCollisionSize {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoAdjustCollisionSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoAdjustCollisionSize", value); }
        }
        ///<summary>If BoneName is specified, offset the wheel from the bone's location.</summary>
        ///<remarks>Otherwise this offsets the wheel from the vehicle's origin.</remarks>
        public unsafe Vector Offset {
            get {return VehicleWheel_ptr->Offset;}
            set {VehicleWheel_ptr->Offset = value;}
        }
        ///<summary>Radius of the wheel</summary>
        public unsafe float ShapeRadius {
            get {return VehicleWheel_ptr->ShapeRadius;}
            set {VehicleWheel_ptr->ShapeRadius = value;}
        }
        ///<summary>Width of the wheel</summary>
        public unsafe float ShapeWidth {
            get {return VehicleWheel_ptr->ShapeWidth;}
            set {VehicleWheel_ptr->ShapeWidth = value;}
        }
        ///<summary>Mass of this wheel</summary>
        public unsafe float Mass {
            get {return VehicleWheel_ptr->Mass;}
            set {VehicleWheel_ptr->Mass = value;}
        }
        ///<summary>Damping rate for this wheel (Kgm^2/s)</summary>
        public unsafe float DampingRate {
            get {return VehicleWheel_ptr->DampingRate;}
            set {VehicleWheel_ptr->DampingRate = value;}
        }
        ///<summary>steer angle in degrees for this wheel</summary>
        public unsafe float SteerAngle {
            get {return VehicleWheel_ptr->SteerAngle;}
            set {VehicleWheel_ptr->SteerAngle = value;}
        }
        public bool bAffectedByHandbrake {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectedByHandbrake"); }
            set {Main.SetGetBoolPropertyByName(this, "bAffectedByHandbrake", value); }
        }
        ///<summary>Deprecated</summary>
        public unsafe TireType TireType {
            get {return VehicleWheel_ptr->TireType;}
            set {VehicleWheel_ptr->TireType = value;}
        }
        ///<summary>Tire type for the wheel. Determines friction</summary>
        public unsafe TireConfig TireConfig {
            get {return VehicleWheel_ptr->TireConfig;}
            set {VehicleWheel_ptr->TireConfig = value;}
        }
        ///<summary>Max normalized tire load at which the tire can deliver no more lateral stiffness no matter how much extra load is applied to the tire.</summary>
        public unsafe float LatStiffMaxLoad {
            get {return VehicleWheel_ptr->LatStiffMaxLoad;}
            set {VehicleWheel_ptr->LatStiffMaxLoad = value;}
        }
        ///<summary>How much lateral stiffness to have given lateral slip</summary>
        public unsafe float LatStiffValue {
            get {return VehicleWheel_ptr->LatStiffValue;}
            set {VehicleWheel_ptr->LatStiffValue = value;}
        }
        ///<summary>How much longitudinal stiffness to have given longitudinal slip</summary>
        public unsafe float LongStiffValue {
            get {return VehicleWheel_ptr->LongStiffValue;}
            set {VehicleWheel_ptr->LongStiffValue = value;}
        }
        ///<summary>Vertical offset from where suspension forces are applied (along Z-axis)</summary>
        public unsafe float SuspensionForceOffset {
            get {return VehicleWheel_ptr->SuspensionForceOffset;}
            set {VehicleWheel_ptr->SuspensionForceOffset = value;}
        }
        ///<summary>How far the wheel can go above the resting position</summary>
        public unsafe float SuspensionMaxRaise {
            get {return VehicleWheel_ptr->SuspensionMaxRaise;}
            set {VehicleWheel_ptr->SuspensionMaxRaise = value;}
        }
        ///<summary>How far the wheel can drop below the resting position</summary>
        public unsafe float SuspensionMaxDrop {
            get {return VehicleWheel_ptr->SuspensionMaxDrop;}
            set {VehicleWheel_ptr->SuspensionMaxDrop = value;}
        }
        ///<summary>Oscillation frequency of suspension. Standard cars have values between 5 and 10</summary>
        public unsafe float SuspensionNaturalFrequency {
            get {return VehicleWheel_ptr->SuspensionNaturalFrequency;}
            set {VehicleWheel_ptr->SuspensionNaturalFrequency = value;}
        }
        ///<summary>The rate at which energy is dissipated from the spring.</summary>
        ///<remarks>
        ///Standard cars have values between 0.8 and 1.2.
        ///values < 1 are more sluggish, values > 1 or more twitchy
        ///</remarks>
        public unsafe float SuspensionDampingRatio {
            get {return VehicleWheel_ptr->SuspensionDampingRatio;}
            set {VehicleWheel_ptr->SuspensionDampingRatio = value;}
        }
        ///<summary>Whether wheel suspension considers simple, complex, or both</summary>
        public unsafe byte SweepType {
            get {return VehicleWheel_ptr->SweepType;}
            set {VehicleWheel_ptr->SweepType = value;}
        }
        ///<summary>max brake torque for this wheel (Nm)</summary>
        public unsafe float MaxBrakeTorque {
            get {return VehicleWheel_ptr->MaxBrakeTorque;}
            set {VehicleWheel_ptr->MaxBrakeTorque = value;}
        }
        ///<summary>Max handbrake brake torque for this wheel (Nm).</summary>
        ///<remarks>
        ///A handbrake should have a stronger brake torque
        ///than the brake. This will be ignored for wheels that are not affected by the handbrake.
        ///</remarks>
        public unsafe float MaxHandBrakeTorque {
            get {return VehicleWheel_ptr->MaxHandBrakeTorque;}
            set {VehicleWheel_ptr->MaxHandBrakeTorque = value;}
        }
        ///<summary>The vehicle that owns us</summary>
        public unsafe WheeledVehicleMovementComponent VehicleSim {
            get {return VehicleWheel_ptr->VehicleSim;}
            set {VehicleWheel_ptr->VehicleSim = value;}
        }
        ///<summary>Our index in the vehicle's (and setup's) wheels array</summary>
        public unsafe int WheelIndex {
            get {return VehicleWheel_ptr->WheelIndex;}
            set {VehicleWheel_ptr->WheelIndex = value;}
        }
        ///<summary>Longitudinal slip experienced by the wheel</summary>
        public unsafe float DebugLongSlip {
            get {return VehicleWheel_ptr->DebugLongSlip;}
            set {VehicleWheel_ptr->DebugLongSlip = value;}
        }
        ///<summary>Lateral slip experienced by the wheel</summary>
        public unsafe float DebugLatSlip {
            get {return VehicleWheel_ptr->DebugLatSlip;}
            set {VehicleWheel_ptr->DebugLatSlip = value;}
        }
        ///<summary>How much force the tire experiences at rest divided by how much force it is experiencing now</summary>
        public unsafe float DebugNormalizedTireLoad {
            get {return VehicleWheel_ptr->DebugNormalizedTireLoad;}
            set {VehicleWheel_ptr->DebugNormalizedTireLoad = value;}
        }
        ///<summary>Wheel torque</summary>
        public unsafe float DebugWheelTorque {
            get {return VehicleWheel_ptr->DebugWheelTorque;}
            set {VehicleWheel_ptr->DebugWheelTorque = value;}
        }
        ///<summary>Longitudinal force the wheel is applying to the chassis</summary>
        public unsafe float DebugLongForce {
            get {return VehicleWheel_ptr->DebugLongForce;}
            set {VehicleWheel_ptr->DebugLongForce = value;}
        }
        ///<summary>Lateral force the wheel is applying to the chassis</summary>
        public unsafe float DebugLatForce {
            get {return VehicleWheel_ptr->DebugLatForce;}
            set {VehicleWheel_ptr->DebugLatForce = value;}
        }
        ///<summary>Worldspace location of this wheel</summary>
        public unsafe Vector Location {
            get {return VehicleWheel_ptr->Location;}
            set {VehicleWheel_ptr->Location = value;}
        }
        ///<summary>Worldspace location of this wheel last frame</summary>
        public unsafe Vector OldLocation {
            get {return VehicleWheel_ptr->OldLocation;}
            set {VehicleWheel_ptr->OldLocation = value;}
        }
        ///<summary>Current velocity of the wheel center (change in location over time)</summary>
        public unsafe Vector Velocity {
            get {return VehicleWheel_ptr->Velocity;}
            set {VehicleWheel_ptr->Velocity = value;}
        }
        static VehicleWheel() {
            StaticClass = Main.GetClass("VehicleWheel");
        }
        internal unsafe VehicleWheel_fields* VehicleWheel_ptr => (VehicleWheel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VehicleWheel(IntPtr p) => UObject.Make<VehicleWheel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VehicleWheel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VehicleWheel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
