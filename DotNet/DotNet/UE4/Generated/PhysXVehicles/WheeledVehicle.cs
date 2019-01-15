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
    ///<summary>WheeledVehicle is the base wheeled vehicle pawn actor.</summary>
    ///<remarks>
    ///By default it uses UWheeledVehicleMovementComponent4W for its simulation, but this can be overridden by inheriting from the class and modifying its constructor like so:
    ///Super(ObjectInitializer.SetDefaultSubobjectClass<UMyMovement>(VehicleMovementComponentName))
    ///Where UMyMovement is the new movement type that inherits from UWheeledVehicleMovementComponent
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Physics/Vehicles/VehicleUserGuide/
    ///@see UWheeledVehicleMovementComponent4W
    ///</remarks>
    public unsafe partial class WheeledVehicle : Pawn  {
        ///<summary>The main skeletal mesh associated with this Vehicle</summary>
        public unsafe SkeletalMeshComponent Mesh {
            get {return WheeledVehicle_ptr->Mesh;}
        }
        ///<summary>vehicle simulation component</summary>
        public unsafe WheeledVehicleMovementComponent VehicleMovement {
            get {return WheeledVehicle_ptr->VehicleMovement;}
        }
        static WheeledVehicle() {
            StaticClass = Main.GetClass("WheeledVehicle");
        }
        internal unsafe WheeledVehicle_fields* WheeledVehicle_ptr => (WheeledVehicle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WheeledVehicle(IntPtr p) => UObject.Make<WheeledVehicle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WheeledVehicle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WheeledVehicle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
