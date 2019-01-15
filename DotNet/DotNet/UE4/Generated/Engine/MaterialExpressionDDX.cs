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
    ///<summary>Material Expression DDX</summary>
    public unsafe partial class MaterialExpressionDDX : MaterialExpression  {
        ///<summary>The value we want to compute ddx/ddy from</summary>
        public unsafe ExpressionInput Value {
            get {return MaterialExpressionDDX_ptr->Value;}
            set {MaterialExpressionDDX_ptr->Value = value;}
        }
        static MaterialExpressionDDX() {
            StaticClass = Main.GetClass("MaterialExpressionDDX");
        }
        internal unsafe MaterialExpressionDDX_fields* MaterialExpressionDDX_ptr => (MaterialExpressionDDX_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDDX(IntPtr p) => UObject.Make<MaterialExpressionDDX>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDDX DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDDX New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
