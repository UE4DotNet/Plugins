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
    ///<summary>Vehicle Anim Instance</summary>
    public unsafe partial class VehicleAnimInstance : AnimInstance  {

        ///<summary>Makes a montage jump to the end of a named section.</summary>
        public WheeledVehicle GetVehicle()  => 
            VehicleAnimInstance_methods.GetVehicle_method.Invoke(ObjPointer);
        ///<summary>Wheeled Vehicle Movement Component</summary>
        public unsafe WheeledVehicleMovementComponent WheeledVehicleMovementComponent {
            get {return VehicleAnimInstance_ptr->WheeledVehicleMovementComponent;}
            set {VehicleAnimInstance_ptr->WheeledVehicleMovementComponent = value;}
        }
        static VehicleAnimInstance() {
            StaticClass = Main.GetClass("VehicleAnimInstance");
        }
        internal unsafe VehicleAnimInstance_fields* VehicleAnimInstance_ptr => (VehicleAnimInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VehicleAnimInstance(IntPtr p) => UObject.Make<VehicleAnimInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VehicleAnimInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VehicleAnimInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
