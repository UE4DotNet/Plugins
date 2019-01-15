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
    ///<summary>Material Expression Constant Bias Scale</summary>
    public unsafe partial class MaterialExpressionConstantBiasScale : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionConstantBiasScale_ptr->Input;}
            set {MaterialExpressionConstantBiasScale_ptr->Input = value;}
        }
        ///<summary>Bias</summary>
        public unsafe float Bias {
            get {return MaterialExpressionConstantBiasScale_ptr->Bias;}
            set {MaterialExpressionConstantBiasScale_ptr->Bias = value;}
        }
        ///<summary>Scale</summary>
        public unsafe float Scale {
            get {return MaterialExpressionConstantBiasScale_ptr->Scale;}
            set {MaterialExpressionConstantBiasScale_ptr->Scale = value;}
        }
        static MaterialExpressionConstantBiasScale() {
            StaticClass = Main.GetClass("MaterialExpressionConstantBiasScale");
        }
        internal unsafe MaterialExpressionConstantBiasScale_fields* MaterialExpressionConstantBiasScale_ptr => (MaterialExpressionConstantBiasScale_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionConstantBiasScale(IntPtr p) => UObject.Make<MaterialExpressionConstantBiasScale>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionConstantBiasScale DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionConstantBiasScale New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
