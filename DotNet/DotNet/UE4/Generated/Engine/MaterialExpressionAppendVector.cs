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
    ///<summary>Material Expression Append Vector</summary>
    public unsafe partial class MaterialExpressionAppendVector : MaterialExpression  {
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionAppendVector_ptr->A;}
            set {MaterialExpressionAppendVector_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionAppendVector_ptr->B;}
            set {MaterialExpressionAppendVector_ptr->B = value;}
        }
        static MaterialExpressionAppendVector() {
            StaticClass = Main.GetClass("MaterialExpressionAppendVector");
        }
        internal unsafe MaterialExpressionAppendVector_fields* MaterialExpressionAppendVector_ptr => (MaterialExpressionAppendVector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionAppendVector(IntPtr p) => UObject.Make<MaterialExpressionAppendVector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionAppendVector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionAppendVector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
