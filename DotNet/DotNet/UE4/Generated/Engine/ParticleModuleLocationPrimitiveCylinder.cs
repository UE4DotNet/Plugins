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
    ///<summary>Particle Module Location Primitive Cylinder</summary>
    public unsafe partial class ParticleModuleLocationPrimitiveCylinder : ParticleModuleLocationPrimitiveBase  {
        public bool RadialVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "RadialVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "RadialVelocity", value); }
        }
        ///<summary>The radius of the cylinder.</summary>
        public unsafe RawDistributionFloat StartRadius {
            get {return ParticleModuleLocationPrimitiveCylinder_ptr->StartRadius;}
            set {ParticleModuleLocationPrimitiveCylinder_ptr->StartRadius = value;}
        }
        ///<summary>The height of the cylinder, centered about the location.</summary>
        public unsafe RawDistributionFloat StartHeight {
            get {return ParticleModuleLocationPrimitiveCylinder_ptr->StartHeight;}
            set {ParticleModuleLocationPrimitiveCylinder_ptr->StartHeight = value;}
        }
        ///<summary>Determine particle particle system axis that should represent the height of the cylinder.</summary>
        ///<remarks>
        ///Can be one of the following:
        ///  PMLPC_HEIGHTAXIS_X - Orient the height along the particle system X-axis.
        ///  PMLPC_HEIGHTAXIS_Y - Orient the height along the particle system Y-axis.
        ///  PMLPC_HEIGHTAXIS_Z - Orient the height along the particle system Z-axis.
        ///</remarks>
        public unsafe byte HeightAxis {
            get {return ParticleModuleLocationPrimitiveCylinder_ptr->HeightAxis;}
            set {ParticleModuleLocationPrimitiveCylinder_ptr->HeightAxis = value;}
        }
        static ParticleModuleLocationPrimitiveCylinder() {
            StaticClass = Main.GetClass("ParticleModuleLocationPrimitiveCylinder");
        }
        internal unsafe ParticleModuleLocationPrimitiveCylinder_fields* ParticleModuleLocationPrimitiveCylinder_ptr => (ParticleModuleLocationPrimitiveCylinder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationPrimitiveCylinder(IntPtr p) => UObject.Make<ParticleModuleLocationPrimitiveCylinder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationPrimitiveCylinder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationPrimitiveCylinder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
