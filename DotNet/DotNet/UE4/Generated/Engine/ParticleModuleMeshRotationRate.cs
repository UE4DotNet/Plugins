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
    ///<summary>Particle Module Mesh Rotation Rate</summary>
    public unsafe partial class ParticleModuleMeshRotationRate : ParticleModuleRotationRateBase  {
        ///<summary>Initial rotation rate, in rotations per second.</summary>
        ///<remarks>The value is retrieved using the EmitterTime.</remarks>
        public unsafe RawDistributionVector StartRotationRate {
            get {return ParticleModuleMeshRotationRate_ptr->StartRotationRate;}
            set {ParticleModuleMeshRotationRate_ptr->StartRotationRate = value;}
        }
        static ParticleModuleMeshRotationRate() {
            StaticClass = Main.GetClass("ParticleModuleMeshRotationRate");
        }
        internal unsafe ParticleModuleMeshRotationRate_fields* ParticleModuleMeshRotationRate_ptr => (ParticleModuleMeshRotationRate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleMeshRotationRate(IntPtr p) => UObject.Make<ParticleModuleMeshRotationRate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleMeshRotationRate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleMeshRotationRate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
