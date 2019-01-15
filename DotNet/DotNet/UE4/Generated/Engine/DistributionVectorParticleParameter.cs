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
    ///<summary>Distribution Vector Particle Parameter</summary>
    public unsafe partial class DistributionVectorParticleParameter : DistributionVectorParameterBase  {
        static DistributionVectorParticleParameter() {
            StaticClass = Main.GetClass("DistributionVectorParticleParameter");
        }
        internal unsafe DistributionVectorParticleParameter_fields* DistributionVectorParticleParameter_ptr => (DistributionVectorParticleParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorParticleParameter(IntPtr p) => UObject.Make<DistributionVectorParticleParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorParticleParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorParticleParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
