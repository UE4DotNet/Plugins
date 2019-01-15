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
    ///<summary>Particle Module Parameter Dynamic</summary>
    public unsafe partial class ParticleModuleParameterDynamic : ParticleModuleParameterBase  {
         //TODO: array not UObject TArray DynamicParams
        ///<summary>Flags for optimizing update</summary>
        public unsafe int UpdateFlags {
            get {return ParticleModuleParameterDynamic_ptr->UpdateFlags;}
            set {ParticleModuleParameterDynamic_ptr->UpdateFlags = value;}
        }
        public bool bUsesVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bUsesVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsesVelocity", value); }
        }
        static ParticleModuleParameterDynamic() {
            StaticClass = Main.GetClass("ParticleModuleParameterDynamic");
        }
        internal unsafe ParticleModuleParameterDynamic_fields* ParticleModuleParameterDynamic_ptr => (ParticleModuleParameterDynamic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleParameterDynamic(IntPtr p) => UObject.Make<ParticleModuleParameterDynamic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleParameterDynamic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleParameterDynamic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
