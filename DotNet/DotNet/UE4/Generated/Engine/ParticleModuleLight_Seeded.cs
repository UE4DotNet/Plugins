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
    ///<summary>Particle Module Light Seeded</summary>
    public unsafe partial class ParticleModuleLight_Seeded : ParticleModuleLight  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleLight_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleLight_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleLight_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleLight_Seeded");
        }
        internal unsafe ParticleModuleLight_Seeded_fields* ParticleModuleLight_Seeded_ptr => (ParticleModuleLight_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLight_Seeded(IntPtr p) => UObject.Make<ParticleModuleLight_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLight_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLight_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
