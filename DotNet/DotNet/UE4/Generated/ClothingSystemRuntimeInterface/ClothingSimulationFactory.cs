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
    ///<summary>Any clothing simulation factory should derive from this interface object to interact with the engine</summary>
    public unsafe partial class ClothingSimulationFactory : UObject  {
        static ClothingSimulationFactory() {
            StaticClass = Main.GetClass("ClothingSimulationFactory");
        }
        internal unsafe ClothingSimulationFactory_fields* ClothingSimulationFactory_ptr => (ClothingSimulationFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingSimulationFactory(IntPtr p) => UObject.Make<ClothingSimulationFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingSimulationFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingSimulationFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
