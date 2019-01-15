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
    ///<summary>Particle Module Spawn Base</summary>
    public unsafe partial class ParticleModuleSpawnBase : ParticleModule  {
        public bool bProcessSpawnRate {
            get {return Main.GetGetBoolPropertyByName(this, "bProcessSpawnRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bProcessSpawnRate", value); }
        }
        public bool bProcessBurstList {
            get {return Main.GetGetBoolPropertyByName(this, "bProcessBurstList"); }
            set {Main.SetGetBoolPropertyByName(this, "bProcessBurstList", value); }
        }
        static ParticleModuleSpawnBase() {
            StaticClass = Main.GetClass("ParticleModuleSpawnBase");
        }
        internal unsafe ParticleModuleSpawnBase_fields* ParticleModuleSpawnBase_ptr => (ParticleModuleSpawnBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSpawnBase(IntPtr p) => UObject.Make<ParticleModuleSpawnBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSpawnBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSpawnBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
