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
    ///<summary>Material Expression Spherical Particle Opacity</summary>
    public unsafe partial class MaterialExpressionSphericalParticleOpacity : MaterialExpression  {
        ///<summary>Defaults to 'ConstantDensity' if not specified</summary>
        public unsafe ExpressionInput Density {
            get {return MaterialExpressionSphericalParticleOpacity_ptr->Density;}
            set {MaterialExpressionSphericalParticleOpacity_ptr->Density = value;}
        }
        ///<summary>Constant density of the particle sphere.  Will be overridden if Density is connected.</summary>
        public unsafe float ConstantDensity {
            get {return MaterialExpressionSphericalParticleOpacity_ptr->ConstantDensity;}
            set {MaterialExpressionSphericalParticleOpacity_ptr->ConstantDensity = value;}
        }
        static MaterialExpressionSphericalParticleOpacity() {
            StaticClass = Main.GetClass("MaterialExpressionSphericalParticleOpacity");
        }
        internal unsafe MaterialExpressionSphericalParticleOpacity_fields* MaterialExpressionSphericalParticleOpacity_ptr => (MaterialExpressionSphericalParticleOpacity_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSphericalParticleOpacity(IntPtr p) => UObject.Make<MaterialExpressionSphericalParticleOpacity>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSphericalParticleOpacity DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSphericalParticleOpacity New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
