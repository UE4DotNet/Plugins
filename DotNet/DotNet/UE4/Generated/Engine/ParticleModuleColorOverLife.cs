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
    ///<summary>Particle Module Color Over Life</summary>
    public unsafe partial class ParticleModuleColorOverLife : ParticleModuleColorBase  {
        ///<summary>The color to apply to the particle, as a function of the particle RelativeTime.</summary>
        public unsafe RawDistributionVector ColorOverLife {
            get {return ParticleModuleColorOverLife_ptr->ColorOverLife;}
            set {ParticleModuleColorOverLife_ptr->ColorOverLife = value;}
        }
        ///<summary>The alpha to apply to the particle, as a function of the particle RelativeTime.</summary>
        public unsafe RawDistributionFloat AlphaOverLife {
            get {return ParticleModuleColorOverLife_ptr->AlphaOverLife;}
            set {ParticleModuleColorOverLife_ptr->AlphaOverLife = value;}
        }
        public bool bClampAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bClampAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bClampAlpha", value); }
        }
        static ParticleModuleColorOverLife() {
            StaticClass = Main.GetClass("ParticleModuleColorOverLife");
        }
        internal unsafe ParticleModuleColorOverLife_fields* ParticleModuleColorOverLife_ptr => (ParticleModuleColorOverLife_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleColorOverLife(IntPtr p) => UObject.Make<ParticleModuleColorOverLife>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleColorOverLife DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleColorOverLife New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
