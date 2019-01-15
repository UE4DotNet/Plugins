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
    ///<summary>Material Expression Cosine</summary>
    public unsafe partial class MaterialExpressionCosine : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionCosine_ptr->Input;}
            set {MaterialExpressionCosine_ptr->Input = value;}
        }
        ///<summary>Period</summary>
        public unsafe float Period {
            get {return MaterialExpressionCosine_ptr->Period;}
            set {MaterialExpressionCosine_ptr->Period = value;}
        }
        static MaterialExpressionCosine() {
            StaticClass = Main.GetClass("MaterialExpressionCosine");
        }
        internal unsafe MaterialExpressionCosine_fields* MaterialExpressionCosine_ptr => (MaterialExpressionCosine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionCosine(IntPtr p) => UObject.Make<MaterialExpressionCosine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionCosine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionCosine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
