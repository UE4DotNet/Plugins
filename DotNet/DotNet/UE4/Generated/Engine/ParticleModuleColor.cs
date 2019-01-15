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
    ///<summary>Particle Module Color</summary>
    public unsafe partial class ParticleModuleColor : ParticleModuleColorBase  {
        ///<summary>Initial color for a particle as a function of Emitter time.</summary>
        public unsafe RawDistributionVector StartColor {
            get {return ParticleModuleColor_ptr->StartColor;}
            set {ParticleModuleColor_ptr->StartColor = value;}
        }
        ///<summary>Initial alpha for a particle as a function of Emitter time.</summary>
        public unsafe RawDistributionFloat StartAlpha {
            get {return ParticleModuleColor_ptr->StartAlpha;}
            set {ParticleModuleColor_ptr->StartAlpha = value;}
        }
        public bool bClampAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bClampAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bClampAlpha", value); }
        }
        static ParticleModuleColor() {
            StaticClass = Main.GetClass("ParticleModuleColor");
        }
        internal unsafe ParticleModuleColor_fields* ParticleModuleColor_ptr => (ParticleModuleColor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleColor(IntPtr p) => UObject.Make<ParticleModuleColor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleColor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleColor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
