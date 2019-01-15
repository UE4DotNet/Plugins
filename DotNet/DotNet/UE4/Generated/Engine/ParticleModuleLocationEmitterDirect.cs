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
    ///<summary>Particle Module Location Emitter Direct</summary>
    public unsafe partial class ParticleModuleLocationEmitterDirect : ParticleModuleLocationBase  {
        ///<summary>The name of the emitter to use as a source for the location of the particles.</summary>
        public unsafe Name EmitterName {
            get {return ParticleModuleLocationEmitterDirect_ptr->EmitterName;}
            set {ParticleModuleLocationEmitterDirect_ptr->EmitterName = value;}
        }
        static ParticleModuleLocationEmitterDirect() {
            StaticClass = Main.GetClass("ParticleModuleLocationEmitterDirect");
        }
        internal unsafe ParticleModuleLocationEmitterDirect_fields* ParticleModuleLocationEmitterDirect_ptr => (ParticleModuleLocationEmitterDirect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationEmitterDirect(IntPtr p) => UObject.Make<ParticleModuleLocationEmitterDirect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationEmitterDirect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationEmitterDirect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
