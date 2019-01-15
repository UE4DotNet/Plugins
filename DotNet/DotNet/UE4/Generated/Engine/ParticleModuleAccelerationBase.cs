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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Particle Module Acceleration Base</summary>
    public unsafe partial class ParticleModuleAccelerationBase : ParticleModule  {
        public bool bAlwaysInWorldSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysInWorldSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysInWorldSpace", value); }
        }
        static ParticleModuleAccelerationBase() {
            StaticClass = Main.GetClass("ParticleModuleAccelerationBase");
        }
        internal unsafe ParticleModuleAccelerationBase_fields* ParticleModuleAccelerationBase_ptr => (ParticleModuleAccelerationBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAccelerationBase(IntPtr p) => UObject.Make<ParticleModuleAccelerationBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAccelerationBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAccelerationBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
