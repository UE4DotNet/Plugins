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
using UE4.ClothingSystemRuntime.Native;
using UE4.ClothingSystemRuntimeInterface;

namespace UE4.ClothingSystemRuntime {
    ///<summary>Clothing Simulation Interactor Nv</summary>
    public unsafe partial class ClothingSimulationInteractorNv : ClothingSimulationInteractor  {

        ///<summary>Disable any currently set gravity override</summary>
        public void DisableGravityOverride()  => 
            ClothingSimulationInteractorNv_methods.DisableGravityOverride_method.Invoke(ObjPointer);

        ///<summary>Set a new gravity override and enable the override</summary>
        public void EnableGravityOverride(Vector InVector)  => 
            ClothingSimulationInteractorNv_methods.EnableGravityOverride_method.Invoke(ObjPointer, InVector);

        ///<summary>Set the stiffness of the resistive damping force for anim drive</summary>
        public void SetAnimDriveDamperStiffness(float InStiffness)  => 
            ClothingSimulationInteractorNv_methods.SetAnimDriveDamperStiffness_method.Invoke(ObjPointer, InStiffness);

        ///<summary>Set the stiffness of the spring force for anim drive</summary>
        public void SetAnimDriveSpringStiffness(float InStiffness)  => 
            ClothingSimulationInteractorNv_methods.SetAnimDriveSpringStiffness_method.Invoke(ObjPointer, InStiffness);
        static ClothingSimulationInteractorNv() {
            StaticClass = Main.GetClass("ClothingSimulationInteractorNv");
        }
        internal unsafe ClothingSimulationInteractorNv_fields* ClothingSimulationInteractorNv_ptr => (ClothingSimulationInteractorNv_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingSimulationInteractorNv(IntPtr p) => UObject.Make<ClothingSimulationInteractorNv>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingSimulationInteractorNv DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingSimulationInteractorNv New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
