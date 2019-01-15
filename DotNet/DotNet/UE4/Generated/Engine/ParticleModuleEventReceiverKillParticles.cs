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
    ///<summary>Particle Module Event Receiver Kill Particles</summary>
    public unsafe partial class ParticleModuleEventReceiverKillParticles : ParticleModuleEventReceiverBase  {
        public bool bStopSpawning {
            get {return Main.GetGetBoolPropertyByName(this, "bStopSpawning"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopSpawning", value); }
        }
        static ParticleModuleEventReceiverKillParticles() {
            StaticClass = Main.GetClass("ParticleModuleEventReceiverKillParticles");
        }
        internal unsafe ParticleModuleEventReceiverKillParticles_fields* ParticleModuleEventReceiverKillParticles_ptr => (ParticleModuleEventReceiverKillParticles_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleEventReceiverKillParticles(IntPtr p) => UObject.Make<ParticleModuleEventReceiverKillParticles>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleEventReceiverKillParticles DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleEventReceiverKillParticles New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
