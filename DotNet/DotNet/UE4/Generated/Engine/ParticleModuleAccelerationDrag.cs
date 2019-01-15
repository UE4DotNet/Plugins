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
    ///<summary>Particle Module Acceleration Drag</summary>
    public unsafe partial class ParticleModuleAccelerationDrag : ParticleModuleAccelerationBase  {
        ///<summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
        public unsafe RawDistributionFloat DragCoefficientRaw {
            get {return ParticleModuleAccelerationDrag_ptr->DragCoefficientRaw;}
            set {ParticleModuleAccelerationDrag_ptr->DragCoefficientRaw = value;}
        }
        static ParticleModuleAccelerationDrag() {
            StaticClass = Main.GetClass("ParticleModuleAccelerationDrag");
        }
        internal unsafe ParticleModuleAccelerationDrag_fields* ParticleModuleAccelerationDrag_ptr => (ParticleModuleAccelerationDrag_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAccelerationDrag(IntPtr p) => UObject.Make<ParticleModuleAccelerationDrag>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAccelerationDrag DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAccelerationDrag New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
