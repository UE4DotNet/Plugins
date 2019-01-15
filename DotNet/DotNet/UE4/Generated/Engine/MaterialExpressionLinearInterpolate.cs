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
    ///<summary>Material Expression Linear Interpolate</summary>
    public unsafe partial class MaterialExpressionLinearInterpolate : MaterialExpression  {
        ///<summary>Defaults to 'ConstA' if not specified</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionLinearInterpolate_ptr->A;}
            set {MaterialExpressionLinearInterpolate_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionLinearInterpolate_ptr->B;}
            set {MaterialExpressionLinearInterpolate_ptr->B = value;}
        }
        ///<summary>Defaults to 'ConstAlpha' if not specified</summary>
        public unsafe ExpressionInput Alpha {
            get {return MaterialExpressionLinearInterpolate_ptr->Alpha;}
            set {MaterialExpressionLinearInterpolate_ptr->Alpha = value;}
        }
        ///<summary>only used if A is not hooked up</summary>
        public unsafe float ConstA {
            get {return MaterialExpressionLinearInterpolate_ptr->ConstA;}
            set {MaterialExpressionLinearInterpolate_ptr->ConstA = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionLinearInterpolate_ptr->ConstB;}
            set {MaterialExpressionLinearInterpolate_ptr->ConstB = value;}
        }
        ///<summary>only used if Alpha is not hooked up</summary>
        public unsafe float ConstAlpha {
            get {return MaterialExpressionLinearInterpolate_ptr->ConstAlpha;}
            set {MaterialExpressionLinearInterpolate_ptr->ConstAlpha = value;}
        }
        static MaterialExpressionLinearInterpolate() {
            StaticClass = Main.GetClass("MaterialExpressionLinearInterpolate");
        }
        internal unsafe MaterialExpressionLinearInterpolate_fields* MaterialExpressionLinearInterpolate_ptr => (MaterialExpressionLinearInterpolate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLinearInterpolate(IntPtr p) => UObject.Make<MaterialExpressionLinearInterpolate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLinearInterpolate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLinearInterpolate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
