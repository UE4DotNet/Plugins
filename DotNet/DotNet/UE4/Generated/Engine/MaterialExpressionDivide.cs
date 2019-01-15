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
    ///<summary>Material Expression Divide</summary>
    public unsafe partial class MaterialExpressionDivide : MaterialExpression  {
        ///<summary>Defaults to 'ConstA' if not specified</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionDivide_ptr->A;}
            set {MaterialExpressionDivide_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionDivide_ptr->B;}
            set {MaterialExpressionDivide_ptr->B = value;}
        }
        ///<summary>only used if A is not hooked up</summary>
        public unsafe float ConstA {
            get {return MaterialExpressionDivide_ptr->ConstA;}
            set {MaterialExpressionDivide_ptr->ConstA = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionDivide_ptr->ConstB;}
            set {MaterialExpressionDivide_ptr->ConstB = value;}
        }
        static MaterialExpressionDivide() {
            StaticClass = Main.GetClass("MaterialExpressionDivide");
        }
        internal unsafe MaterialExpressionDivide_fields* MaterialExpressionDivide_ptr => (MaterialExpressionDivide_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDivide(IntPtr p) => UObject.Make<MaterialExpressionDivide>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDivide DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDivide New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
