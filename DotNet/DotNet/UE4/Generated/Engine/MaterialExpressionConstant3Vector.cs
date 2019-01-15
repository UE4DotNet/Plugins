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
    ///<summary>Material Expression Constant 3Vector</summary>
    public unsafe partial class MaterialExpressionConstant3Vector : MaterialExpression  {
        ///<summary>Constant</summary>
        public unsafe LinearColor Constant {
            get {return MaterialExpressionConstant3Vector_ptr->Constant;}
            set {MaterialExpressionConstant3Vector_ptr->Constant = value;}
        }
        static MaterialExpressionConstant3Vector() {
            StaticClass = Main.GetClass("MaterialExpressionConstant3Vector");
        }
        internal unsafe MaterialExpressionConstant3Vector_fields* MaterialExpressionConstant3Vector_ptr => (MaterialExpressionConstant3Vector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionConstant3Vector(IntPtr p) => UObject.Make<MaterialExpressionConstant3Vector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionConstant3Vector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionConstant3Vector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
