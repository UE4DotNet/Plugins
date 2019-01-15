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
    ///<summary>Particle Module Attractor Particle</summary>
    public unsafe partial class ParticleModuleAttractorParticle : ParticleModuleAttractorBase  {
        ///<summary>The source emitter for attractors</summary>
        public unsafe Name EmitterName {
            get {return ParticleModuleAttractorParticle_ptr->EmitterName;}
            set {ParticleModuleAttractorParticle_ptr->EmitterName = value;}
        }
        ///<summary>The radial range of the attraction around the source particle.</summary>
        ///<remarks>Particle-life relative.</remarks>
        public unsafe RawDistributionFloat Range {
            get {return ParticleModuleAttractorParticle_ptr->Range;}
            set {ParticleModuleAttractorParticle_ptr->Range = value;}
        }
        public bool bStrengthByDistance {
            get {return Main.GetGetBoolPropertyByName(this, "bStrengthByDistance"); }
            set {Main.SetGetBoolPropertyByName(this, "bStrengthByDistance", value); }
        }
        ///<summary>The strength of the attraction (negative values repel).</summary>
        ///<remarks>Particle-life relative if StrengthByDistance is false.</remarks>
        public unsafe RawDistributionFloat Strength {
            get {return ParticleModuleAttractorParticle_ptr->Strength;}
            set {ParticleModuleAttractorParticle_ptr->Strength = value;}
        }
        public bool bAffectBaseVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectBaseVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bAffectBaseVelocity", value); }
        }
        ///<summary>The method to use when selecting an attractor target particle from the emitter.</summary>
        ///<remarks>
        ///One of the following:
        ///Random          - Randomly select a particle from the source emitter.
        ///Sequential  - Select a particle using a sequential order.
        ///</remarks>
        public unsafe byte SelectionMethod {
            get {return ParticleModuleAttractorParticle_ptr->SelectionMethod;}
            set {ParticleModuleAttractorParticle_ptr->SelectionMethod = value;}
        }
        public bool bRenewSource {
            get {return Main.GetGetBoolPropertyByName(this, "bRenewSource"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenewSource", value); }
        }
        public bool bInheritSourceVel {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritSourceVel"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritSourceVel", value); }
        }
        ///<summary>Last Sel Index</summary>
        public unsafe int LastSelIndex {
            get {return ParticleModuleAttractorParticle_ptr->LastSelIndex;}
            set {ParticleModuleAttractorParticle_ptr->LastSelIndex = value;}
        }
        static ParticleModuleAttractorParticle() {
            StaticClass = Main.GetClass("ParticleModuleAttractorParticle");
        }
        internal unsafe ParticleModuleAttractorParticle_fields* ParticleModuleAttractorParticle_ptr => (ParticleModuleAttractorParticle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAttractorParticle(IntPtr p) => UObject.Make<ParticleModuleAttractorParticle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAttractorParticle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAttractorParticle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
