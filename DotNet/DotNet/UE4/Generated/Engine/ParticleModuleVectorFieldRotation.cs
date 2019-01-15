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
    ///<summary>Particle Module Vector Field Rotation</summary>
    public unsafe partial class ParticleModuleVectorFieldRotation : ParticleModuleVectorFieldBase  {
        ///<summary>Minimum initial rotation applied to the local vector field.</summary>
        public unsafe Vector MinInitialRotation {
            get {return ParticleModuleVectorFieldRotation_ptr->MinInitialRotation;}
            set {ParticleModuleVectorFieldRotation_ptr->MinInitialRotation = value;}
        }
        ///<summary>Maximum initial rotation applied to the local vector field.</summary>
        public unsafe Vector MaxInitialRotation {
            get {return ParticleModuleVectorFieldRotation_ptr->MaxInitialRotation;}
            set {ParticleModuleVectorFieldRotation_ptr->MaxInitialRotation = value;}
        }
        static ParticleModuleVectorFieldRotation() {
            StaticClass = Main.GetClass("ParticleModuleVectorFieldRotation");
        }
        internal unsafe ParticleModuleVectorFieldRotation_fields* ParticleModuleVectorFieldRotation_ptr => (ParticleModuleVectorFieldRotation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVectorFieldRotation(IntPtr p) => UObject.Make<ParticleModuleVectorFieldRotation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVectorFieldRotation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVectorFieldRotation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
