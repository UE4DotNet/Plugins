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
    ///<summary>Wheeled Vehicle Movement Component 4W</summary>
    public unsafe partial class WheeledVehicleMovementComponent4W : WheeledVehicleMovementComponent  {
        ///<summary>Engine</summary>
        public unsafe VehicleEngineData EngineSetup {
            get {return WheeledVehicleMovementComponent4W_ptr->EngineSetup;}
            set {WheeledVehicleMovementComponent4W_ptr->EngineSetup = value;}
        }
        ///<summary>Differential</summary>
        public unsafe VehicleDifferential4WData DifferentialSetup {
            get {return WheeledVehicleMovementComponent4W_ptr->DifferentialSetup;}
            set {WheeledVehicleMovementComponent4W_ptr->DifferentialSetup = value;}
        }
        ///<summary>Transmission data</summary>
        public unsafe VehicleTransmissionData TransmissionSetup {
            get {return WheeledVehicleMovementComponent4W_ptr->TransmissionSetup;}
            set {WheeledVehicleMovementComponent4W_ptr->TransmissionSetup = value;}
        }
        ///<summary>Maximum steering versus forward speed (km/h)</summary>
        public unsafe RuntimeFloatCurve SteeringCurve {
            get {return WheeledVehicleMovementComponent4W_ptr->SteeringCurve;}
            set {WheeledVehicleMovementComponent4W_ptr->SteeringCurve = value;}
        }
        ///<summary>Accuracy of Ackermann steer calculation (range: 0..1)</summary>
        public unsafe float AckermannAccuracy {
            get {return WheeledVehicleMovementComponent4W_ptr->AckermannAccuracy;}
            set {WheeledVehicleMovementComponent4W_ptr->AckermannAccuracy = value;}
        }
        static WheeledVehicleMovementComponent4W() {
            StaticClass = Main.GetClass("WheeledVehicleMovementComponent4W");
        }
        internal unsafe WheeledVehicleMovementComponent4W_fields* WheeledVehicleMovementComponent4W_ptr => (WheeledVehicleMovementComponent4W_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WheeledVehicleMovementComponent4W(IntPtr p) => UObject.Make<WheeledVehicleMovementComponent4W>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WheeledVehicleMovementComponent4W DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WheeledVehicleMovementComponent4W New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
