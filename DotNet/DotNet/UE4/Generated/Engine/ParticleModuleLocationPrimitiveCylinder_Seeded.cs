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
    ///<summary>Particle Module Location Primitive Cylinder Seeded</summary>
    public unsafe partial class ParticleModuleLocationPrimitiveCylinder_Seeded : ParticleModuleLocationPrimitiveCylinder  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleLocationPrimitiveCylinder_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleLocationPrimitiveCylinder_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleLocationPrimitiveCylinder_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleLocationPrimitiveCylinder_Seeded");
        }
        internal unsafe ParticleModuleLocationPrimitiveCylinder_Seeded_fields* ParticleModuleLocationPrimitiveCylinder_Seeded_ptr => (ParticleModuleLocationPrimitiveCylinder_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationPrimitiveCylinder_Seeded(IntPtr p) => UObject.Make<ParticleModuleLocationPrimitiveCylinder_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationPrimitiveCylinder_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationPrimitiveCylinder_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
