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

namespace UE4.PhysXVehicles {
    ///<summary>Simple Wheeled Vehicle Movement Component</summary>
    public unsafe partial class SimpleWheeledVehicleMovementComponent : WheeledVehicleMovementComponent  {

        ///<summary>Set the brake torque to be applied to a specific wheel</summary>
        public void SetBrakeTorque(float BrakeTorque, int WheelIndex)  => 
            SimpleWheeledVehicleMovementComponent_methods.SetBrakeTorque_method.Invoke(ObjPointer, BrakeTorque, WheelIndex);

        ///<summary>Set the drive torque to be applied to a specific wheel</summary>
        public void SetDriveTorque(float DriveTorque, int WheelIndex)  => 
            SimpleWheeledVehicleMovementComponent_methods.SetDriveTorque_method.Invoke(ObjPointer, DriveTorque, WheelIndex);

        ///<summary>Set the steer angle (in degrees) to be applied to a specific wheel</summary>
        public void SetSteerAngle(float SteerAngle, int WheelIndex)  => 
            SimpleWheeledVehicleMovementComponent_methods.SetSteerAngle_method.Invoke(ObjPointer, SteerAngle, WheelIndex);
        static SimpleWheeledVehicleMovementComponent() {
            StaticClass = Main.GetClass("SimpleWheeledVehicleMovementComponent");
        }
        internal unsafe SimpleWheeledVehicleMovementComponent_fields* SimpleWheeledVehicleMovementComponent_ptr => (SimpleWheeledVehicleMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SimpleWheeledVehicleMovementComponent(IntPtr p) => UObject.Make<SimpleWheeledVehicleMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SimpleWheeledVehicleMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SimpleWheeledVehicleMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
