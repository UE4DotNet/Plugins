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
    ///<summary>Material Expression Arctangent Fast</summary>
    public unsafe partial class MaterialExpressionArctangentFast : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionArctangentFast_ptr->Input;}
            set {MaterialExpressionArctangentFast_ptr->Input = value;}
        }
        static MaterialExpressionArctangentFast() {
            StaticClass = Main.GetClass("MaterialExpressionArctangentFast");
        }
        internal unsafe MaterialExpressionArctangentFast_fields* MaterialExpressionArctangentFast_ptr => (MaterialExpressionArctangentFast_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionArctangentFast(IntPtr p) => UObject.Make<MaterialExpressionArctangentFast>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionArctangentFast DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionArctangentFast New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
