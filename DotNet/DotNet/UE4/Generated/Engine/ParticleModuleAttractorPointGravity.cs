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
    ///<summary>Particle Module Attractor Point Gravity</summary>
    public unsafe partial class ParticleModuleAttractorPointGravity : ParticleModuleAttractorBase  {
        ///<summary>The position of the point gravity source.</summary>
        public unsafe Vector Position {
            get {return ParticleModuleAttractorPointGravity_ptr->Position;}
            set {ParticleModuleAttractorPointGravity_ptr->Position = value;}
        }
        ///<summary>The distance at which the influence of the point begins to falloff.</summary>
        public unsafe float Radius {
            get {return ParticleModuleAttractorPointGravity_ptr->Radius;}
            set {ParticleModuleAttractorPointGravity_ptr->Radius = value;}
        }
        ///<summary>The strength of the point source.</summary>
        public unsafe RawDistributionFloat StrengthRaw {
            get {return ParticleModuleAttractorPointGravity_ptr->StrengthRaw;}
            set {ParticleModuleAttractorPointGravity_ptr->StrengthRaw = value;}
        }
        static ParticleModuleAttractorPointGravity() {
            StaticClass = Main.GetClass("ParticleModuleAttractorPointGravity");
        }
        internal unsafe ParticleModuleAttractorPointGravity_fields* ParticleModuleAttractorPointGravity_ptr => (ParticleModuleAttractorPointGravity_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAttractorPointGravity(IntPtr p) => UObject.Make<ParticleModuleAttractorPointGravity>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAttractorPointGravity DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAttractorPointGravity New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
