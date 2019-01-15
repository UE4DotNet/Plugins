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
    ///<summary>Particle Module Acceleration Over Lifetime</summary>
    public unsafe partial class ParticleModuleAccelerationOverLifetime : ParticleModuleAccelerationBase  {
        ///<summary>The acceleration of the particle over its lifetime.</summary>
        ///<remarks>
        ///Value is obtained using the RelativeTime of the partice.
        ///The current and base velocity values of the particle
        ///are then updated using the formula
        ///        velocity += acceleration* DeltaTime
        ///where DeltaTime is the time passed since the last frame.
        ///</remarks>
        public unsafe RawDistributionVector AccelOverLife {
            get {return ParticleModuleAccelerationOverLifetime_ptr->AccelOverLife;}
            set {ParticleModuleAccelerationOverLifetime_ptr->AccelOverLife = value;}
        }
        static ParticleModuleAccelerationOverLifetime() {
            StaticClass = Main.GetClass("ParticleModuleAccelerationOverLifetime");
        }
        internal unsafe ParticleModuleAccelerationOverLifetime_fields* ParticleModuleAccelerationOverLifetime_ptr => (ParticleModuleAccelerationOverLifetime_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAccelerationOverLifetime(IntPtr p) => UObject.Make<ParticleModuleAccelerationOverLifetime>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAccelerationOverLifetime DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAccelerationOverLifetime New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
