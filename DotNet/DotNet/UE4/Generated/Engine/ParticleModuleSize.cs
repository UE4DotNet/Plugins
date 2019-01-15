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
    ///<summary>Particle Module Size</summary>
    public unsafe partial class ParticleModuleSize : ParticleModuleSizeBase  {
        ///<summary>The initial size that should be used for a particle.</summary>
        ///<remarks>
        ///The value is retrieved using the EmitterTime during the spawn of a particle.
        ///It is added to the Size and BaseSize fields of the spawning particle.
        ///</remarks>
        public unsafe RawDistributionVector StartSize {
            get {return ParticleModuleSize_ptr->StartSize;}
            set {ParticleModuleSize_ptr->StartSize = value;}
        }
        static ParticleModuleSize() {
            StaticClass = Main.GetClass("ParticleModuleSize");
        }
        internal unsafe ParticleModuleSize_fields* ParticleModuleSize_ptr => (ParticleModuleSize_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSize(IntPtr p) => UObject.Make<ParticleModuleSize>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSize DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSize New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
