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
    ///<summary>Material Expression Multiply</summary>
    public unsafe partial class MaterialExpressionMultiply : MaterialExpression  {
        ///<summary>Defaults to 'ConstA' if not specified</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionMultiply_ptr->A;}
            set {MaterialExpressionMultiply_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionMultiply_ptr->B;}
            set {MaterialExpressionMultiply_ptr->B = value;}
        }
        ///<summary>only used if A is not hooked up</summary>
        public unsafe float ConstA {
            get {return MaterialExpressionMultiply_ptr->ConstA;}
            set {MaterialExpressionMultiply_ptr->ConstA = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionMultiply_ptr->ConstB;}
            set {MaterialExpressionMultiply_ptr->ConstB = value;}
        }
        static MaterialExpressionMultiply() {
            StaticClass = Main.GetClass("MaterialExpressionMultiply");
        }
        internal unsafe MaterialExpressionMultiply_fields* MaterialExpressionMultiply_ptr => (MaterialExpressionMultiply_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMultiply(IntPtr p) => UObject.Make<MaterialExpressionMultiply>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMultiply DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMultiply New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
