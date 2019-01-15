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
    ///<summary>Material Expression Tangent</summary>
    public unsafe partial class MaterialExpressionTangent : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionTangent_ptr->Input;}
            set {MaterialExpressionTangent_ptr->Input = value;}
        }
        ///<summary>Period</summary>
        public unsafe float Period {
            get {return MaterialExpressionTangent_ptr->Period;}
            set {MaterialExpressionTangent_ptr->Period = value;}
        }
        static MaterialExpressionTangent() {
            StaticClass = Main.GetClass("MaterialExpressionTangent");
        }
        internal unsafe MaterialExpressionTangent_fields* MaterialExpressionTangent_ptr => (MaterialExpressionTangent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTangent(IntPtr p) => UObject.Make<MaterialExpressionTangent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTangent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTangent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
