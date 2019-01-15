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
    ///<summary>Particle Module Attractor Point</summary>
    public unsafe partial class ParticleModuleAttractorPoint : ParticleModuleAttractorBase  {
        ///<summary>The position of the point attractor from the source of the emitter.</summary>
        public unsafe RawDistributionVector Position {
            get {return ParticleModuleAttractorPoint_ptr->Position;}
            set {ParticleModuleAttractorPoint_ptr->Position = value;}
        }
        ///<summary>The radial range of the attractor.</summary>
        public unsafe RawDistributionFloat Range {
            get {return ParticleModuleAttractorPoint_ptr->Range;}
            set {ParticleModuleAttractorPoint_ptr->Range = value;}
        }
        ///<summary>The strength of the point attractor.</summary>
        public unsafe RawDistributionFloat Strength {
            get {return ParticleModuleAttractorPoint_ptr->Strength;}
            set {ParticleModuleAttractorPoint_ptr->Strength = value;}
        }
        public bool StrengthByDistance {
            get {return Main.GetGetBoolPropertyByName(this, "StrengthByDistance"); }
            set {Main.SetGetBoolPropertyByName(this, "StrengthByDistance", value); }
        }
        public bool bAffectBaseVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectBaseVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bAffectBaseVelocity", value); }
        }
        public bool bOverrideVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideVelocity", value); }
        }
        public bool bUseWorldSpacePosition {
            get {return Main.GetGetBoolPropertyByName(this, "bUseWorldSpacePosition"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseWorldSpacePosition", value); }
        }
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
        static ParticleModuleAttractorPoint() {
            StaticClass = Main.GetClass("ParticleModuleAttractorPoint");
        }
        internal unsafe ParticleModuleAttractorPoint_fields* ParticleModuleAttractorPoint_ptr => (ParticleModuleAttractorPoint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAttractorPoint(IntPtr p) => UObject.Make<ParticleModuleAttractorPoint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAttractorPoint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAttractorPoint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
