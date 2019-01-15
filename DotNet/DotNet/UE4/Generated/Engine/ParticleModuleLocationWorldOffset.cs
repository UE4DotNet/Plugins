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
    ///<summary>Particle Module Location World Offset</summary>
    public unsafe partial class ParticleModuleLocationWorldOffset : ParticleModuleLocation  {
        static ParticleModuleLocationWorldOffset() {
            StaticClass = Main.GetClass("ParticleModuleLocationWorldOffset");
        }
        internal unsafe ParticleModuleLocationWorldOffset_fields* ParticleModuleLocationWorldOffset_ptr => (ParticleModuleLocationWorldOffset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationWorldOffset(IntPtr p) => UObject.Make<ParticleModuleLocationWorldOffset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationWorldOffset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationWorldOffset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
