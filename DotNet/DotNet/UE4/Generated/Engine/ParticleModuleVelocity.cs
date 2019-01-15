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
    ///<summary>Particle Module Velocity</summary>
    public unsafe partial class ParticleModuleVelocity : ParticleModuleVelocityBase  {
        ///<summary>The velocity to apply to a particle when it is spawned.</summary>
        ///<remarks>Value is retrieved using the EmitterTime of the emitter.</remarks>
        public unsafe RawDistributionVector StartVelocity {
            get {return ParticleModuleVelocity_ptr->StartVelocity;}
            set {ParticleModuleVelocity_ptr->StartVelocity = value;}
        }
        ///<summary>The velocity to apply to a particle along its radial direction.</summary>
        ///<remarks>
        ///Direction is determined by subtracting the location of the emitter from the particle location at spawn.
        ///Value is retrieved using the EmitterTime of the emitter.
        ///</remarks>
        public unsafe RawDistributionFloat StartVelocityRadial {
            get {return ParticleModuleVelocity_ptr->StartVelocityRadial;}
            set {ParticleModuleVelocity_ptr->StartVelocityRadial = value;}
        }
        static ParticleModuleVelocity() {
            StaticClass = Main.GetClass("ParticleModuleVelocity");
        }
        internal unsafe ParticleModuleVelocity_fields* ParticleModuleVelocity_ptr => (ParticleModuleVelocity_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocity(IntPtr p) => UObject.Make<ParticleModuleVelocity>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocity DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocity New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
