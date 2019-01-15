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
    ///<summary>Particle Module Lifetime</summary>
    public unsafe partial class ParticleModuleLifetime : ParticleModuleLifetimeBase  {
        ///<summary>The lifetime of the particle, in seconds. Retrieved using the EmitterTime at the spawn of the particle.</summary>
        public unsafe RawDistributionFloat Lifetime {
            get {return ParticleModuleLifetime_ptr->Lifetime;}
            set {ParticleModuleLifetime_ptr->Lifetime = value;}
        }
        static ParticleModuleLifetime() {
            StaticClass = Main.GetClass("ParticleModuleLifetime");
        }
        internal unsafe ParticleModuleLifetime_fields* ParticleModuleLifetime_ptr => (ParticleModuleLifetime_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLifetime(IntPtr p) => UObject.Make<ParticleModuleLifetime>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLifetime DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLifetime New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
