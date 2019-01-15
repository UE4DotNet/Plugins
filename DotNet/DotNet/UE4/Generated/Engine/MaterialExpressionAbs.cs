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
    ///<summary>Material Expression Abs</summary>
    public unsafe partial class MaterialExpressionAbs : MaterialExpression  {
        ///<summary>Link to the input expression to be evaluated</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionAbs_ptr->Input;}
            set {MaterialExpressionAbs_ptr->Input = value;}
        }
        static MaterialExpressionAbs() {
            StaticClass = Main.GetClass("MaterialExpressionAbs");
        }
        internal unsafe MaterialExpressionAbs_fields* MaterialExpressionAbs_ptr => (MaterialExpressionAbs_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionAbs(IntPtr p) => UObject.Make<MaterialExpressionAbs>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionAbs DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionAbs New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
