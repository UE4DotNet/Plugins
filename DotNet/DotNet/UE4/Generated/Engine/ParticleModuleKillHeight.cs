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
    ///<summary>Particle Module Kill Height</summary>
    public unsafe partial class ParticleModuleKillHeight : ParticleModuleKillBase  {
        ///<summary>The height at which to kill the particle.</summary>
        public unsafe RawDistributionFloat Height {
            get {return ParticleModuleKillHeight_ptr->Height;}
            set {ParticleModuleKillHeight_ptr->Height = value;}
        }
        public bool bAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsolute", value); }
        }
        public bool bFloor {
            get {return Main.GetGetBoolPropertyByName(this, "bFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "bFloor", value); }
        }
        public bool bApplyPSysScale {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyPSysScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyPSysScale", value); }
        }
        static ParticleModuleKillHeight() {
            StaticClass = Main.GetClass("ParticleModuleKillHeight");
        }
        internal unsafe ParticleModuleKillHeight_fields* ParticleModuleKillHeight_ptr => (ParticleModuleKillHeight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleKillHeight(IntPtr p) => UObject.Make<ParticleModuleKillHeight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleKillHeight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleKillHeight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
