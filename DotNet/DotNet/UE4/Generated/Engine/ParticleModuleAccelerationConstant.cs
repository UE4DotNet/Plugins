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
    ///<summary>Particle Module Acceleration Constant</summary>
    public unsafe partial class ParticleModuleAccelerationConstant : ParticleModuleAccelerationBase  {
        ///<summary>Constant acceleration for particles in this system.</summary>
        public unsafe Vector Acceleration {
            get {return ParticleModuleAccelerationConstant_ptr->Acceleration;}
            set {ParticleModuleAccelerationConstant_ptr->Acceleration = value;}
        }
        static ParticleModuleAccelerationConstant() {
            StaticClass = Main.GetClass("ParticleModuleAccelerationConstant");
        }
        internal unsafe ParticleModuleAccelerationConstant_fields* ParticleModuleAccelerationConstant_ptr => (ParticleModuleAccelerationConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAccelerationConstant(IntPtr p) => UObject.Make<ParticleModuleAccelerationConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAccelerationConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAccelerationConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
