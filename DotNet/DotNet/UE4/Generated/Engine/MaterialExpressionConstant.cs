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
    ///<summary>Material Expression Constant</summary>
    public unsafe partial class MaterialExpressionConstant : MaterialExpression  {
        ///<summary>R</summary>
        public unsafe float R {
            get {return MaterialExpressionConstant_ptr->R;}
            set {MaterialExpressionConstant_ptr->R = value;}
        }
        static MaterialExpressionConstant() {
            StaticClass = Main.GetClass("MaterialExpressionConstant");
        }
        internal unsafe MaterialExpressionConstant_fields* MaterialExpressionConstant_ptr => (MaterialExpressionConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionConstant(IntPtr p) => UObject.Make<MaterialExpressionConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
