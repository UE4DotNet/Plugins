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
    ///<summary>Particle Module Mesh Rotation Rate Over Life</summary>
    public unsafe partial class ParticleModuleMeshRotationRateOverLife : ParticleModuleRotationRateBase  {
        ///<summary>The rotation rate desired.</summary>
        ///<remarks>The value is retrieved using the RelativeTime of the particle.</remarks>
        public unsafe RawDistributionVector RotRate {
            get {return ParticleModuleMeshRotationRateOverLife_ptr->RotRate;}
            set {ParticleModuleMeshRotationRateOverLife_ptr->RotRate = value;}
        }
        public bool bScaleRotRate {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleRotRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bScaleRotRate", value); }
        }
        static ParticleModuleMeshRotationRateOverLife() {
            StaticClass = Main.GetClass("ParticleModuleMeshRotationRateOverLife");
        }
        internal unsafe ParticleModuleMeshRotationRateOverLife_fields* ParticleModuleMeshRotationRateOverLife_ptr => (ParticleModuleMeshRotationRateOverLife_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleMeshRotationRateOverLife(IntPtr p) => UObject.Make<ParticleModuleMeshRotationRateOverLife>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleMeshRotationRateOverLife DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleMeshRotationRateOverLife New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
