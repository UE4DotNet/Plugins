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
    ///<summary>Particle Module Location Primitive Base</summary>
    public unsafe partial class ParticleModuleLocationPrimitiveBase : ParticleModuleLocationBase  {
        public bool Positive_X {
            get {return Main.GetGetBoolPropertyByName(this, "Positive_X"); }
            set {Main.SetGetBoolPropertyByName(this, "Positive_X", value); }
        }
        public bool Positive_Y {
            get {return Main.GetGetBoolPropertyByName(this, "Positive_Y"); }
            set {Main.SetGetBoolPropertyByName(this, "Positive_Y", value); }
        }
        public bool Positive_Z {
            get {return Main.GetGetBoolPropertyByName(this, "Positive_Z"); }
            set {Main.SetGetBoolPropertyByName(this, "Positive_Z", value); }
        }
        public bool Negative_X {
            get {return Main.GetGetBoolPropertyByName(this, "Negative_X"); }
            set {Main.SetGetBoolPropertyByName(this, "Negative_X", value); }
        }
        public bool Negative_Y {
            get {return Main.GetGetBoolPropertyByName(this, "Negative_Y"); }
            set {Main.SetGetBoolPropertyByName(this, "Negative_Y", value); }
        }
        public bool Negative_Z {
            get {return Main.GetGetBoolPropertyByName(this, "Negative_Z"); }
            set {Main.SetGetBoolPropertyByName(this, "Negative_Z", value); }
        }
        public bool SurfaceOnly {
            get {return Main.GetGetBoolPropertyByName(this, "SurfaceOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "SurfaceOnly", value); }
        }
        public bool Velocity {
            get {return Main.GetGetBoolPropertyByName(this, "Velocity"); }
            set {Main.SetGetBoolPropertyByName(this, "Velocity", value); }
        }
        ///<summary>The scale applied to the velocity. (Only used if 'Velocity' is checked).</summary>
        public unsafe RawDistributionFloat VelocityScale {
            get {return ParticleModuleLocationPrimitiveBase_ptr->VelocityScale;}
            set {ParticleModuleLocationPrimitiveBase_ptr->VelocityScale = value;}
        }
        ///<summary>The location of the bounding primitive relative to the position of the emitter.</summary>
        public unsafe RawDistributionVector StartLocation {
            get {return ParticleModuleLocationPrimitiveBase_ptr->StartLocation;}
            set {ParticleModuleLocationPrimitiveBase_ptr->StartLocation = value;}
        }
        static ParticleModuleLocationPrimitiveBase() {
            StaticClass = Main.GetClass("ParticleModuleLocationPrimitiveBase");
        }
        internal unsafe ParticleModuleLocationPrimitiveBase_fields* ParticleModuleLocationPrimitiveBase_ptr => (ParticleModuleLocationPrimitiveBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationPrimitiveBase(IntPtr p) => UObject.Make<ParticleModuleLocationPrimitiveBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationPrimitiveBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationPrimitiveBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
