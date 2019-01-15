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
    ///<summary>Particle Module Type Data Gpu</summary>
    public unsafe partial class ParticleModuleTypeDataGpu : ParticleModuleTypeDataBase  {
        ///<summary>Information for runtime simulation.</summary>
        public unsafe GPUSpriteEmitterInfo EmitterInfo {
            get {return ParticleModuleTypeDataGpu_ptr->EmitterInfo;}
            set {ParticleModuleTypeDataGpu_ptr->EmitterInfo = value;}
        }
        ///<summary>Data used to initialize runtime resources.</summary>
        public unsafe GPUSpriteResourceData ResourceData {
            get {return ParticleModuleTypeDataGpu_ptr->ResourceData;}
            set {ParticleModuleTypeDataGpu_ptr->ResourceData = value;}
        }
        ///<summary>TEMP: How much to stretch sprites based on camera motion blur.</summary>
        public unsafe float CameraMotionBlurAmount {
            get {return ParticleModuleTypeDataGpu_ptr->CameraMotionBlurAmount;}
            set {ParticleModuleTypeDataGpu_ptr->CameraMotionBlurAmount = value;}
        }
        public bool bClearExistingParticlesOnInit {
            get {return Main.GetGetBoolPropertyByName(this, "bClearExistingParticlesOnInit"); }
            set {Main.SetGetBoolPropertyByName(this, "bClearExistingParticlesOnInit", value); }
        }
        static ParticleModuleTypeDataGpu() {
            StaticClass = Main.GetClass("ParticleModuleTypeDataGpu");
        }
        internal unsafe ParticleModuleTypeDataGpu_fields* ParticleModuleTypeDataGpu_ptr => (ParticleModuleTypeDataGpu_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTypeDataGpu(IntPtr p) => UObject.Make<ParticleModuleTypeDataGpu>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTypeDataGpu DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTypeDataGpu New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
