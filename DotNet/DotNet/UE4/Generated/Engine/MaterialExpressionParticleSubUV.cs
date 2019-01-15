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
    ///<summary>Material Expression Particle Sub UV</summary>
    public unsafe partial class MaterialExpressionParticleSubUV : MaterialExpressionTextureSample  {
        public bool bBlend {
            get {return Main.GetGetBoolPropertyByName(this, "bBlend"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlend", value); }
        }
        static MaterialExpressionParticleSubUV() {
            StaticClass = Main.GetClass("MaterialExpressionParticleSubUV");
        }
        internal unsafe MaterialExpressionParticleSubUV_fields* MaterialExpressionParticleSubUV_ptr => (MaterialExpressionParticleSubUV_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionParticleSubUV(IntPtr p) => UObject.Make<MaterialExpressionParticleSubUV>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionParticleSubUV DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionParticleSubUV New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
