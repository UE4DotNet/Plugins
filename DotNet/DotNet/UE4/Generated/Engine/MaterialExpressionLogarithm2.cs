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
    ///<summary>Material Expression Logarithm 2</summary>
    public unsafe partial class MaterialExpressionLogarithm2 : MaterialExpression  {
        ///<summary>X</summary>
        public unsafe ExpressionInput X {
            get {return MaterialExpressionLogarithm2_ptr->X;}
            set {MaterialExpressionLogarithm2_ptr->X = value;}
        }
        static MaterialExpressionLogarithm2() {
            StaticClass = Main.GetClass("MaterialExpressionLogarithm2");
        }
        internal unsafe MaterialExpressionLogarithm2_fields* MaterialExpressionLogarithm2_ptr => (MaterialExpressionLogarithm2_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLogarithm2(IntPtr p) => UObject.Make<MaterialExpressionLogarithm2>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLogarithm2 DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLogarithm2 New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
