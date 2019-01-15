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
    ///<summary>Material Expression Max</summary>
    public unsafe partial class MaterialExpressionMax : MaterialExpression  {
        ///<summary>Defaults to 'ConstA' if not specified</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionMax_ptr->A;}
            set {MaterialExpressionMax_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionMax_ptr->B;}
            set {MaterialExpressionMax_ptr->B = value;}
        }
        ///<summary>only used if A is not hooked up</summary>
        public unsafe float ConstA {
            get {return MaterialExpressionMax_ptr->ConstA;}
            set {MaterialExpressionMax_ptr->ConstA = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionMax_ptr->ConstB;}
            set {MaterialExpressionMax_ptr->ConstB = value;}
        }
        static MaterialExpressionMax() {
            StaticClass = Main.GetClass("MaterialExpressionMax");
        }
        internal unsafe MaterialExpressionMax_fields* MaterialExpressionMax_ptr => (MaterialExpressionMax_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMax(IntPtr p) => UObject.Make<MaterialExpressionMax>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMax DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMax New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
