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
    ///<summary>Particle Module Velocity Inherit Parent</summary>
    public unsafe partial class ParticleModuleVelocityInheritParent : ParticleModuleVelocityBase  {
        ///<summary>The scale to apply tot he parent velocity prior to adding it to the particle velocity during spawn.</summary>
        ///<remarks>Value is retrieved using the EmitterTime of the emitter.</remarks>
        public unsafe RawDistributionVector Scale {
            get {return ParticleModuleVelocityInheritParent_ptr->Scale;}
            set {ParticleModuleVelocityInheritParent_ptr->Scale = value;}
        }
        static ParticleModuleVelocityInheritParent() {
            StaticClass = Main.GetClass("ParticleModuleVelocityInheritParent");
        }
        internal unsafe ParticleModuleVelocityInheritParent_fields* ParticleModuleVelocityInheritParent_ptr => (ParticleModuleVelocityInheritParent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocityInheritParent(IntPtr p) => UObject.Make<ParticleModuleVelocityInheritParent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocityInheritParent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocityInheritParent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
