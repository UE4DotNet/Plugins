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
    ///<summary>Particle Module Size Scale by Speed</summary>
    public unsafe partial class ParticleModuleSizeScaleBySpeed : ParticleModuleSizeBase  {
        ///<summary>By how much speed affects the size of the particle in each dimension.</summary>
        public unsafe Vector2D SpeedScale {
            get {return ParticleModuleSizeScaleBySpeed_ptr->SpeedScale;}
            set {ParticleModuleSizeScaleBySpeed_ptr->SpeedScale = value;}
        }
        ///<summary>The maximum amount by which to scale a particle in each dimension.</summary>
        public unsafe Vector2D MaxScale {
            get {return ParticleModuleSizeScaleBySpeed_ptr->MaxScale;}
            set {ParticleModuleSizeScaleBySpeed_ptr->MaxScale = value;}
        }
        static ParticleModuleSizeScaleBySpeed() {
            StaticClass = Main.GetClass("ParticleModuleSizeScaleBySpeed");
        }
        internal unsafe ParticleModuleSizeScaleBySpeed_fields* ParticleModuleSizeScaleBySpeed_ptr => (ParticleModuleSizeScaleBySpeed_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSizeScaleBySpeed(IntPtr p) => UObject.Make<ParticleModuleSizeScaleBySpeed>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSizeScaleBySpeed DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSizeScaleBySpeed New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
