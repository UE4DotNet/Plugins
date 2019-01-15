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
    ///<summary>Particle Module Location Primitive Sphere</summary>
    public unsafe partial class ParticleModuleLocationPrimitiveSphere : ParticleModuleLocationPrimitiveBase  {
        ///<summary>The radius of the sphere. Retrieved using EmitterTime.</summary>
        public unsafe RawDistributionFloat StartRadius {
            get {return ParticleModuleLocationPrimitiveSphere_ptr->StartRadius;}
            set {ParticleModuleLocationPrimitiveSphere_ptr->StartRadius = value;}
        }
        static ParticleModuleLocationPrimitiveSphere() {
            StaticClass = Main.GetClass("ParticleModuleLocationPrimitiveSphere");
        }
        internal unsafe ParticleModuleLocationPrimitiveSphere_fields* ParticleModuleLocationPrimitiveSphere_ptr => (ParticleModuleLocationPrimitiveSphere_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationPrimitiveSphere(IntPtr p) => UObject.Make<ParticleModuleLocationPrimitiveSphere>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationPrimitiveSphere DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationPrimitiveSphere New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
