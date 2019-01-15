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
    ///<summary>Particle Module Velocity Base</summary>
    public unsafe partial class ParticleModuleVelocityBase : ParticleModule  {
        public bool bInWorldSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bInWorldSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bInWorldSpace", value); }
        }
        public bool bApplyOwnerScale {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyOwnerScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyOwnerScale", value); }
        }
        static ParticleModuleVelocityBase() {
            StaticClass = Main.GetClass("ParticleModuleVelocityBase");
        }
        internal unsafe ParticleModuleVelocityBase_fields* ParticleModuleVelocityBase_ptr => (ParticleModuleVelocityBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVelocityBase(IntPtr p) => UObject.Make<ParticleModuleVelocityBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVelocityBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVelocityBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
