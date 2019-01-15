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
    ///<summary>Particle Module Velocity Over Lifetime</summary>
    public unsafe partial class ParticleModuleVelocityOverLifetime : ParticleModuleVelocityBase  {
        ///<summary>The scaling  value applied to the velocity.</summary>
        ///<remarks>Value is retrieved using the RelativeTime of the particle.</remarks>
        public unsafe RawDistributionVector VelOverLife {
            get {return ParticleModuleVelocityOverLifetime_ptr->VelOverLife;}
            set {ParticleModuleVelocityOverLifetime_ptr->VelOverLife = value;}
        }
        public bool Absolute {
            get {return Main.GetGetBoolPropertyByName(this, "Absolute"); }
            set {Main.SetGetBoolPropertyByName(this, "Absolute", value); }
        }
        static ParticleModuleVelocityOverLifetime() {
            StaticClass = Main.GetClass("ParticleModuleVelocityOverLifetime");
        }
        internal unsafe ParticleModuleVelocityOverLifetime_fields* ParticleModuleVelocityOverLifetime_ptr => (ParticleModuleVelocityOverLifetime_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocityOverLifetime(IntPtr p) => UObject.Make<ParticleModuleVelocityOverLifetime>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocityOverLifetime DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocityOverLifetime New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
