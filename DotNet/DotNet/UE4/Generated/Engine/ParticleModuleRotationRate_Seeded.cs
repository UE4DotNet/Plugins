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
    ///<summary>Particle Module Rotation Rate Seeded</summary>
    public unsafe partial class ParticleModuleRotationRate_Seeded : ParticleModuleRotationRate  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleRotationRate_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleRotationRate_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleRotationRate_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleRotationRate_Seeded");
        }
        internal unsafe ParticleModuleRotationRate_Seeded_fields* ParticleModuleRotationRate_Seeded_ptr => (ParticleModuleRotationRate_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleRotationRate_Seeded(IntPtr p) => UObject.Make<ParticleModuleRotationRate_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleRotationRate_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleRotationRate_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
