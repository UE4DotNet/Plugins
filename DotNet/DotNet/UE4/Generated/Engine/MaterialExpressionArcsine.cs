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
    ///<summary>Material Expression Arcsine</summary>
    public unsafe partial class MaterialExpressionArcsine : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionArcsine_ptr->Input;}
            set {MaterialExpressionArcsine_ptr->Input = value;}
        }
        static MaterialExpressionArcsine() {
            StaticClass = Main.GetClass("MaterialExpressionArcsine");
        }
        internal unsafe MaterialExpressionArcsine_fields* MaterialExpressionArcsine_ptr => (MaterialExpressionArcsine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionArcsine(IntPtr p) => UObject.Make<MaterialExpressionArcsine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionArcsine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionArcsine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
