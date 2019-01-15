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
using UE4.ClothingSystemRuntimeInterface.Native;

namespace UE4.ClothingSystemRuntimeInterface {
    ///<summary>
    ///If a clothing simulation is able to be interacted with at runtime then a derived
    ///interactor should be created, and at least the basic API implemented for that
    ///simulation.
    ///</summary>
    ///<remarks>
    ///Only write to the simulation and context during the call to Sync, as that is
    ///guaranteed to be a safe place to access this data.
    ///</remarks>
    public unsafe partial class ClothingSimulationInteractor : UObject  {

        ///<summary>Called to update the cloth config without restarting the simulation</summary>
        public void ClothConfigUpdated()  => 
            ClothingSimulationInteractor_methods.ClothConfigUpdated_method.Invoke(ObjPointer);

        ///<summary>Called to update collision status without restarting the simulation</summary>
        public void PhysicsAssetUpdated()  => 
            ClothingSimulationInteractor_methods.PhysicsAssetUpdated_method.Invoke(ObjPointer);
        static ClothingSimulationInteractor() {
            StaticClass = Main.GetClass("ClothingSimulationInteractor");
        }
        internal unsafe ClothingSimulationInteractor_fields* ClothingSimulationInteractor_ptr => (ClothingSimulationInteractor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingSimulationInteractor(IntPtr p) => UObject.Make<ClothingSimulationInteractor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingSimulationInteractor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingSimulationInteractor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
