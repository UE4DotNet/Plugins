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
    ///<summary>Particle Module Parameter Dynamic Seeded</summary>
    public unsafe partial class ParticleModuleParameterDynamic_Seeded : ParticleModuleParameterDynamic  {
        ///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
        public unsafe ParticleRandomSeedInfo RandomSeedInfo {
            get {return ParticleModuleParameterDynamic_Seeded_ptr->RandomSeedInfo;}
            set {ParticleModuleParameterDynamic_Seeded_ptr->RandomSeedInfo = value;}
        }
        static ParticleModuleParameterDynamic_Seeded() {
            StaticClass = Main.GetClass("ParticleModuleParameterDynamic_Seeded");
        }
        internal unsafe ParticleModuleParameterDynamic_Seeded_fields* ParticleModuleParameterDynamic_Seeded_ptr => (ParticleModuleParameterDynamic_Seeded_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleParameterDynamic_Seeded(IntPtr p) => UObject.Make<ParticleModuleParameterDynamic_Seeded>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleParameterDynamic_Seeded DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleParameterDynamic_Seeded New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
