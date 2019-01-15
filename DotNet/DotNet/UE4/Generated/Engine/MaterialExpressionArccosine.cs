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
    ///<summary>Material Expression Arccosine</summary>
    public unsafe partial class MaterialExpressionArccosine : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionArccosine_ptr->Input;}
            set {MaterialExpressionArccosine_ptr->Input = value;}
        }
        static MaterialExpressionArccosine() {
            StaticClass = Main.GetClass("MaterialExpressionArccosine");
        }
        internal unsafe MaterialExpressionArccosine_fields* MaterialExpressionArccosine_ptr => (MaterialExpressionArccosine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionArccosine(IntPtr p) => UObject.Make<MaterialExpressionArccosine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionArccosine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionArccosine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
