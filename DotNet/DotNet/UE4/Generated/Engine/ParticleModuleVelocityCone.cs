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
    ///<summary>Particle Module Velocity Cone</summary>
    public unsafe partial class ParticleModuleVelocityCone : ParticleModuleVelocityBase  {
        ///<summary>The Min value represents the inner cone angle value and the Max value represents the outer cone angle value.</summary>
        public unsafe RawDistributionFloat Angle {
            get {return ParticleModuleVelocityCone_ptr->Angle;}
            set {ParticleModuleVelocityCone_ptr->Angle = value;}
        }
        ///<summary>The initial velocity of the particles.</summary>
        public unsafe RawDistributionFloat Velocity {
            get {return ParticleModuleVelocityCone_ptr->Velocity;}
            set {ParticleModuleVelocityCone_ptr->Velocity = value;}
        }
        ///<summary>The direction FVector of the cone.</summary>
        public unsafe Vector Direction {
            get {return ParticleModuleVelocityCone_ptr->Direction;}
            set {ParticleModuleVelocityCone_ptr->Direction = value;}
        }
        static ParticleModuleVelocityCone() {
            StaticClass = Main.GetClass("ParticleModuleVelocityCone");
        }
        internal unsafe ParticleModuleVelocityCone_fields* ParticleModuleVelocityCone_ptr => (ParticleModuleVelocityCone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocityCone(IntPtr p) => UObject.Make<ParticleModuleVelocityCone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocityCone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocityCone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
