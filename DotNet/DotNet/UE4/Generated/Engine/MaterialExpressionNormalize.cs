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
    ///<summary>Material Expression Normalize</summary>
    public unsafe partial class MaterialExpressionNormalize : MaterialExpression  {
        ///<summary>Vector Input</summary>
        public unsafe ExpressionInput VectorInput {
            get {return MaterialExpressionNormalize_ptr->VectorInput;}
            set {MaterialExpressionNormalize_ptr->VectorInput = value;}
        }
        static MaterialExpressionNormalize() {
            StaticClass = Main.GetClass("MaterialExpressionNormalize");
        }
        internal unsafe MaterialExpressionNormalize_fields* MaterialExpressionNormalize_ptr => (MaterialExpressionNormalize_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionNormalize(IntPtr p) => UObject.Make<MaterialExpressionNormalize>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionNormalize DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionNormalize New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
