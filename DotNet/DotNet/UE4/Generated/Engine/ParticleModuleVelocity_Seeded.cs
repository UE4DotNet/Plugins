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
    ///<summary>Particle Module Velocity Seeded</summary>
    public unsafe partial class ParticleModuleVelocity_Seeded : ParticleModuleVelocity  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleVelocity_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleVelocity_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleVelocity_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleVelocity_Seeded");
        }
        internal unsafe ParticleModuleVelocity_Seeded_fields* ParticleModuleVelocity_Seeded_ptr => (ParticleModuleVelocity_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocity_Seeded(IntPtr p) => UObject.Make<ParticleModuleVelocity_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocity_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocity_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
