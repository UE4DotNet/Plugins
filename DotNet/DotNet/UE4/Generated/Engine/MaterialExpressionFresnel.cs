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
    ///<summary>Material Expression Fresnel</summary>
    public unsafe partial class MaterialExpressionFresnel : MaterialExpression  {
        ///<summary>Defaults to 'Exponent' if not specified</summary>
        public unsafe ExpressionInput ExponentIn {
            get {return MaterialExpressionFresnel_ptr->ExponentIn;}
            set {MaterialExpressionFresnel_ptr->ExponentIn = value;}
        }
        ///<summary>The exponent to pass into the pow() function</summary>
        public unsafe float Exponent {
            get {return MaterialExpressionFresnel_ptr->Exponent;}
            set {MaterialExpressionFresnel_ptr->Exponent = value;}
        }
        ///<summary>Defaults to 'BaseReflectFraction' if not specified</summary>
        public unsafe ExpressionInput BaseReflectFractionIn {
            get {return MaterialExpressionFresnel_ptr->BaseReflectFractionIn;}
            set {MaterialExpressionFresnel_ptr->BaseReflectFractionIn = value;}
        }
        ///<summary>Specifies the fraction of specular reflection when the surfaces is viewed from straight on.</summary>
        ///<remarks>A value of 1 effectively disables Fresnel.</remarks>
        public unsafe float BaseReflectFraction {
            get {return MaterialExpressionFresnel_ptr->BaseReflectFraction;}
            set {MaterialExpressionFresnel_ptr->BaseReflectFraction = value;}
        }
        ///<summary>Defaults to Pixel World Normal if not specified</summary>
        public unsafe ExpressionInput Normal {
            get {return MaterialExpressionFresnel_ptr->Normal;}
            set {MaterialExpressionFresnel_ptr->Normal = value;}
        }
        static MaterialExpressionFresnel() {
            StaticClass = Main.GetClass("MaterialExpressionFresnel");
        }
        internal unsafe MaterialExpressionFresnel_fields* MaterialExpressionFresnel_ptr => (MaterialExpressionFresnel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFresnel(IntPtr p) => UObject.Make<MaterialExpressionFresnel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFresnel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFresnel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
