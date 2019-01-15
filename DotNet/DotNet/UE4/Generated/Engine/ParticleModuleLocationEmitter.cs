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
    ///<summary>Particle Module Location Emitter</summary>
    public unsafe partial class ParticleModuleLocationEmitter : ParticleModuleLocationBase  {
        ///<summary>The name of the emitter to use that the source location for particle.</summary>
        public unsafe Name EmitterName {
            get {return ParticleModuleLocationEmitter_ptr->EmitterName;}
            set {ParticleModuleLocationEmitter_ptr->EmitterName = value;}
        }
        ///<summary>The method to use when selecting a spawn target particle from the emitter.</summary>
        ///<remarks>
        ///Can be one of the following:
        ///        ELESM_Random            Randomly select a particle from the source emitter.
        ///        ELESM_Sequential        Step through each particle from the source emitter in order.
        ///</remarks>
        public unsafe byte SelectionMethod {
            get {return ParticleModuleLocationEmitter_ptr->SelectionMethod;}
            set {ParticleModuleLocationEmitter_ptr->SelectionMethod = value;}
        }
        public bool InheritSourceVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "InheritSourceVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "InheritSourceVelocity", value); }
        }
        ///<summary>Amount to scale the source velocity by when inheriting it.</summary>
        public unsafe float InheritSourceVelocityScale {
            get {return ParticleModuleLocationEmitter_ptr->InheritSourceVelocityScale;}
            set {ParticleModuleLocationEmitter_ptr->InheritSourceVelocityScale = value;}
        }
        public bool bInheritSourceRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritSourceRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritSourceRotation", value); }
        }
        ///<summary>Amount to scale the source rotation by when inheriting it.</summary>
        public unsafe float InheritSourceRotationScale {
            get {return ParticleModuleLocationEmitter_ptr->InheritSourceRotationScale;}
            set {ParticleModuleLocationEmitter_ptr->InheritSourceRotationScale = value;}
        }
        static ParticleModuleLocationEmitter() {
            StaticClass = Main.GetClass("ParticleModuleLocationEmitter");
        }
        internal unsafe ParticleModuleLocationEmitter_fields* ParticleModuleLocationEmitter_ptr => (ParticleModuleLocationEmitter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationEmitter(IntPtr p) => UObject.Make<ParticleModuleLocationEmitter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationEmitter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationEmitter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
