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
    ///<summary>Particle Module Source Movement</summary>
    public unsafe partial class ParticleModuleSourceMovement : ParticleModuleLocationBase  {
        ///<summary>The scale factor to apply to the source movement before adding to the particle location.</summary>
        ///<remarks>The value is looked up using the particles RELATIVE time [0..1].</remarks>
        public unsafe RawDistributionVector SourceMovementScale {
            get {return ParticleModuleSourceMovement_ptr->SourceMovementScale;}
            set {ParticleModuleSourceMovement_ptr->SourceMovementScale = value;}
        }
        static ParticleModuleSourceMovement() {
            StaticClass = Main.GetClass("ParticleModuleSourceMovement");
        }
        internal unsafe ParticleModuleSourceMovement_fields* ParticleModuleSourceMovement_ptr => (ParticleModuleSourceMovement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSourceMovement(IntPtr p) => UObject.Make<ParticleModuleSourceMovement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSourceMovement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSourceMovement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
