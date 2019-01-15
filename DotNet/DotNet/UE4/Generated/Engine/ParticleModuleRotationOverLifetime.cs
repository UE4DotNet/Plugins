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
    ///<summary>Particle Module Rotation Over Lifetime</summary>
    public unsafe partial class ParticleModuleRotationOverLifetime : ParticleModuleRotationBase  {
        ///<summary>The rotation of the particle (1.</summary>
        ///<remarks>
        ///0 = 360 degrees).
        ///The value is retrieved using the RelativeTime of the particle.
        ///</remarks>
        public unsafe RawDistributionFloat RotationOverLife {
            get {return ParticleModuleRotationOverLifetime_ptr->RotationOverLife;}
            set {ParticleModuleRotationOverLifetime_ptr->RotationOverLife = value;}
        }
        public bool Scale {
            get {return Main.GetGetBoolPropertyByName(this, "Scale"); }
            set {Main.SetGetBoolPropertyByName(this, "Scale", value); }
        }
        static ParticleModuleRotationOverLifetime() {
            StaticClass = Main.GetClass("ParticleModuleRotationOverLifetime");
        }
        internal unsafe ParticleModuleRotationOverLifetime_fields* ParticleModuleRotationOverLifetime_ptr => (ParticleModuleRotationOverLifetime_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleRotationOverLifetime(IntPtr p) => UObject.Make<ParticleModuleRotationOverLifetime>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleRotationOverLifetime DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleRotationOverLifetime New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
