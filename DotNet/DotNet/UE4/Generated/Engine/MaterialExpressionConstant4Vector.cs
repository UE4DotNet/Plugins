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
    ///<summary>Material Expression Constant 4Vector</summary>
    public unsafe partial class MaterialExpressionConstant4Vector : MaterialExpression  {
        ///<summary>Constant</summary>
        public unsafe LinearColor Constant {
            get {return MaterialExpressionConstant4Vector_ptr->Constant;}
            set {MaterialExpressionConstant4Vector_ptr->Constant = value;}
        }
        static MaterialExpressionConstant4Vector() {
            StaticClass = Main.GetClass("MaterialExpressionConstant4Vector");
        }
        internal unsafe MaterialExpressionConstant4Vector_fields* MaterialExpressionConstant4Vector_ptr => (MaterialExpressionConstant4Vector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionConstant4Vector(IntPtr p) => UObject.Make<MaterialExpressionConstant4Vector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionConstant4Vector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionConstant4Vector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
