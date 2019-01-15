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
    ///<summary>Particle Module Pivot Offset</summary>
    public unsafe partial class ParticleModulePivotOffset : ParticleModuleLocationBase  {
        ///<summary>Offset applied in UV space to the particle vertex positions. Defaults to (0.5,0.5) putting the pivot in the centre of the partilce.</summary>
        public unsafe Vector2D PivotOffset {
            get {return ParticleModulePivotOffset_ptr->PivotOffset;}
            set {ParticleModulePivotOffset_ptr->PivotOffset = value;}
        }
        static ParticleModulePivotOffset() {
            StaticClass = Main.GetClass("ParticleModulePivotOffset");
        }
        internal unsafe ParticleModulePivotOffset_fields* ParticleModulePivotOffset_ptr => (ParticleModulePivotOffset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModulePivotOffset(IntPtr p) => UObject.Make<ParticleModulePivotOffset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModulePivotOffset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModulePivotOffset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
