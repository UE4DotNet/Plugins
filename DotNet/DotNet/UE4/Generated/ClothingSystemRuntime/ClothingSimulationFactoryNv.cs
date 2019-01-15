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
    ///<summary>Clothing Simulation Factory Nv</summary>
    public unsafe partial class ClothingSimulationFactoryNv : ClothingSimulationFactory  {
        static ClothingSimulationFactoryNv() {
            StaticClass = Main.GetClass("ClothingSimulationFactoryNv");
        }
        internal unsafe ClothingSimulationFactoryNv_fields* ClothingSimulationFactoryNv_ptr => (ClothingSimulationFactoryNv_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingSimulationFactoryNv(IntPtr p) => UObject.Make<ClothingSimulationFactoryNv>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingSimulationFactoryNv DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingSimulationFactoryNv New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
