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
    ///<summary>Particle Module Mesh Rotation Rate Multiply Life</summary>
    public unsafe partial class ParticleModuleMeshRotationRateMultiplyLife : ParticleModuleRotationRateBase  {
        ///<summary>The scale factor that should be applied to the rotation rate.</summary>
        ///<remarks>The value is retrieved using the RelativeTime of the particle.</remarks>
        public unsafe RawDistributionVector LifeMultiplier {
            get {return ParticleModuleMeshRotationRateMultiplyLife_ptr->LifeMultiplier;}
            set {ParticleModuleMeshRotationRateMultiplyLife_ptr->LifeMultiplier = value;}
        }
        static ParticleModuleMeshRotationRateMultiplyLife() {
            StaticClass = Main.GetClass("ParticleModuleMeshRotationRateMultiplyLife");
        }
        internal unsafe ParticleModuleMeshRotationRateMultiplyLife_fields* ParticleModuleMeshRotationRateMultiplyLife_ptr => (ParticleModuleMeshRotationRateMultiplyLife_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleMeshRotationRateMultiplyLife(IntPtr p) => UObject.Make<ParticleModuleMeshRotationRateMultiplyLife>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleMeshRotationRateMultiplyLife DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleMeshRotationRateMultiplyLife New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
