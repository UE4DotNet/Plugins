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
    ///<summary>Particle Module Location Primitive Triangle</summary>
    public unsafe partial class ParticleModuleLocationPrimitiveTriangle : ParticleModuleLocationBase  {
        ///<summary>Start Offset</summary>
        public unsafe RawDistributionVector StartOffset {
            get {return ParticleModuleLocationPrimitiveTriangle_ptr->StartOffset;}
            set {ParticleModuleLocationPrimitiveTriangle_ptr->StartOffset = value;}
        }
        ///<summary>Height</summary>
        public unsafe RawDistributionFloat Height {
            get {return ParticleModuleLocationPrimitiveTriangle_ptr->Height;}
            set {ParticleModuleLocationPrimitiveTriangle_ptr->Height = value;}
        }
        ///<summary>Angle</summary>
        public unsafe RawDistributionFloat Angle {
            get {return ParticleModuleLocationPrimitiveTriangle_ptr->Angle;}
            set {ParticleModuleLocationPrimitiveTriangle_ptr->Angle = value;}
        }
        ///<summary>Thickness</summary>
        public unsafe RawDistributionFloat Thickness {
            get {return ParticleModuleLocationPrimitiveTriangle_ptr->Thickness;}
            set {ParticleModuleLocationPrimitiveTriangle_ptr->Thickness = value;}
        }
        static ParticleModuleLocationPrimitiveTriangle() {
            StaticClass = Main.GetClass("ParticleModuleLocationPrimitiveTriangle");
        }
        internal unsafe ParticleModuleLocationPrimitiveTriangle_fields* ParticleModuleLocationPrimitiveTriangle_ptr => (ParticleModuleLocationPrimitiveTriangle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationPrimitiveTriangle(IntPtr p) => UObject.Make<ParticleModuleLocationPrimitiveTriangle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationPrimitiveTriangle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationPrimitiveTriangle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
