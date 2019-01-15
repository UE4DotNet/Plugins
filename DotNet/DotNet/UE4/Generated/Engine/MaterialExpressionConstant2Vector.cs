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
    ///<summary>Material Expression Constant 2Vector</summary>
    public unsafe partial class MaterialExpressionConstant2Vector : MaterialExpression  {
        ///<summary>R</summary>
        public unsafe float R {
            get {return MaterialExpressionConstant2Vector_ptr->R;}
            set {MaterialExpressionConstant2Vector_ptr->R = value;}
        }
        ///<summary>G</summary>
        public unsafe float G {
            get {return MaterialExpressionConstant2Vector_ptr->G;}
            set {MaterialExpressionConstant2Vector_ptr->G = value;}
        }
        static MaterialExpressionConstant2Vector() {
            StaticClass = Main.GetClass("MaterialExpressionConstant2Vector");
        }
        internal unsafe MaterialExpressionConstant2Vector_fields* MaterialExpressionConstant2Vector_ptr => (MaterialExpressionConstant2Vector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionConstant2Vector(IntPtr p) => UObject.Make<MaterialExpressionConstant2Vector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionConstant2Vector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionConstant2Vector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
