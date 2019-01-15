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
    ///<summary>Material Expression Dot Product</summary>
    public unsafe partial class MaterialExpressionDotProduct : MaterialExpression  {
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionDotProduct_ptr->A;}
            set {MaterialExpressionDotProduct_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionDotProduct_ptr->B;}
            set {MaterialExpressionDotProduct_ptr->B = value;}
        }
        static MaterialExpressionDotProduct() {
            StaticClass = Main.GetClass("MaterialExpressionDotProduct");
        }
        internal unsafe MaterialExpressionDotProduct_fields* MaterialExpressionDotProduct_ptr => (MaterialExpressionDotProduct_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDotProduct(IntPtr p) => UObject.Make<MaterialExpressionDotProduct>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDotProduct DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDotProduct New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
