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
    ///<summary>Particle Module Lifetime Seeded</summary>
    public unsafe partial class ParticleModuleLifetime_Seeded : ParticleModuleLifetime  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleLifetime_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleLifetime_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleLifetime_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleLifetime_Seeded");
        }
        internal unsafe ParticleModuleLifetime_Seeded_fields* ParticleModuleLifetime_Seeded_ptr => (ParticleModuleLifetime_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLifetime_Seeded(IntPtr p) => UObject.Make<ParticleModuleLifetime_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLifetime_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLifetime_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
