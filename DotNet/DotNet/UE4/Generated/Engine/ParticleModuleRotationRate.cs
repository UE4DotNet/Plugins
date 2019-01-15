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
    ///<summary>Particle Module Rotation Rate</summary>
    public unsafe partial class ParticleModuleRotationRate : ParticleModuleRotationRateBase  {
        ///<summary>Initial rotation rate, in rotations per second.</summary>
        ///<remarks>The value is retrieved using the EmitterTime.</remarks>
        public unsafe RawDistributionFloat StartRotationRate {
            get {return ParticleModuleRotationRate_ptr->StartRotationRate;}
            set {ParticleModuleRotationRate_ptr->StartRotationRate = value;}
        }
        static ParticleModuleRotationRate() {
            StaticClass = Main.GetClass("ParticleModuleRotationRate");
        }
        internal unsafe ParticleModuleRotationRate_fields* ParticleModuleRotationRate_ptr => (ParticleModuleRotationRate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleRotationRate(IntPtr p) => UObject.Make<ParticleModuleRotationRate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleRotationRate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleRotationRate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
