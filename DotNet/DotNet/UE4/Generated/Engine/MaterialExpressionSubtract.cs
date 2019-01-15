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
    ///<summary>Material Expression Subtract</summary>
    public unsafe partial class MaterialExpressionSubtract : MaterialExpression  {
        ///<summary>Defaults to 'ConstA' if not specified</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionSubtract_ptr->A;}
            set {MaterialExpressionSubtract_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionSubtract_ptr->B;}
            set {MaterialExpressionSubtract_ptr->B = value;}
        }
        ///<summary>only used if A is not hooked up</summary>
        public unsafe float ConstA {
            get {return MaterialExpressionSubtract_ptr->ConstA;}
            set {MaterialExpressionSubtract_ptr->ConstA = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionSubtract_ptr->ConstB;}
            set {MaterialExpressionSubtract_ptr->ConstB = value;}
        }
        static MaterialExpressionSubtract() {
            StaticClass = Main.GetClass("MaterialExpressionSubtract");
        }
        internal unsafe MaterialExpressionSubtract_fields* MaterialExpressionSubtract_ptr => (MaterialExpressionSubtract_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSubtract(IntPtr p) => UObject.Make<MaterialExpressionSubtract>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSubtract DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSubtract New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
