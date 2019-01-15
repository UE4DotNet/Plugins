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
    ///<summary>Particle Module Vector Field Rotation Rate</summary>
    public unsafe partial class ParticleModuleVectorFieldRotationRate : ParticleModuleVectorFieldBase  {
        ///<summary>Constant rotation rate applied to the local vector field.</summary>
        public unsafe Vector RotationRate {
            get {return ParticleModuleVectorFieldRotationRate_ptr->RotationRate;}
            set {ParticleModuleVectorFieldRotationRate_ptr->RotationRate = value;}
        }
        static ParticleModuleVectorFieldRotationRate() {
            StaticClass = Main.GetClass("ParticleModuleVectorFieldRotationRate");
        }
        internal unsafe ParticleModuleVectorFieldRotationRate_fields* ParticleModuleVectorFieldRotationRate_ptr => (ParticleModuleVectorFieldRotationRate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVectorFieldRotationRate(IntPtr p) => UObject.Make<ParticleModuleVectorFieldRotationRate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVectorFieldRotationRate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVectorFieldRotationRate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
