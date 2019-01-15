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
    ///<summary>Particle Module Size Multiply Life</summary>
    public unsafe partial class ParticleModuleSizeMultiplyLife : ParticleModuleSizeBase  {
        ///<summary>The scale factor for the size that should be used for a particle.</summary>
        ///<remarks>The value is retrieved using the RelativeTime of the particle during its update.</remarks>
        public unsafe RawDistributionVector LifeMultiplier {
            get {return ParticleModuleSizeMultiplyLife_ptr->LifeMultiplier;}
            set {ParticleModuleSizeMultiplyLife_ptr->LifeMultiplier = value;}
        }
        public bool MultiplyX {
            get {return Main.GetGetBoolPropertyByName(this, "MultiplyX"); }
            set {Main.SetGetBoolPropertyByName(this, "MultiplyX", value); }
        }
        public bool MultiplyY {
            get {return Main.GetGetBoolPropertyByName(this, "MultiplyY"); }
            set {Main.SetGetBoolPropertyByName(this, "MultiplyY", value); }
        }
        public bool MultiplyZ {
            get {return Main.GetGetBoolPropertyByName(this, "MultiplyZ"); }
            set {Main.SetGetBoolPropertyByName(this, "MultiplyZ", value); }
        }
        static ParticleModuleSizeMultiplyLife() {
            StaticClass = Main.GetClass("ParticleModuleSizeMultiplyLife");
        }
        internal unsafe ParticleModuleSizeMultiplyLife_fields* ParticleModuleSizeMultiplyLife_ptr => (ParticleModuleSizeMultiplyLife_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSizeMultiplyLife(IntPtr p) => UObject.Make<ParticleModuleSizeMultiplyLife>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSizeMultiplyLife DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSizeMultiplyLife New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
