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
    ///<summary>Particle Module Mesh Rotation</summary>
    public unsafe partial class ParticleModuleMeshRotation : ParticleModuleRotationBase  {
        ///<summary>Initial rotation in ROTATIONS PER SECOND (1 = 360 degrees).</summary>
        ///<remarks>The value is retrieved using the EmitterTime.</remarks>
        public unsafe RawDistributionVector StartRotation {
            get {return ParticleModuleMeshRotation_ptr->StartRotation;}
            set {ParticleModuleMeshRotation_ptr->StartRotation = value;}
        }
        public bool bInheritParent {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritParent"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritParent", value); }
        }
        static ParticleModuleMeshRotation() {
            StaticClass = Main.GetClass("ParticleModuleMeshRotation");
        }
        internal unsafe ParticleModuleMeshRotation_fields* ParticleModuleMeshRotation_ptr => (ParticleModuleMeshRotation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleMeshRotation(IntPtr p) => UObject.Make<ParticleModuleMeshRotation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleMeshRotation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleMeshRotation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
