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
    ///<summary>Material Expression Arccosine Fast</summary>
    public unsafe partial class MaterialExpressionArccosineFast : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionArccosineFast_ptr->Input;}
            set {MaterialExpressionArccosineFast_ptr->Input = value;}
        }
        static MaterialExpressionArccosineFast() {
            StaticClass = Main.GetClass("MaterialExpressionArccosineFast");
        }
        internal unsafe MaterialExpressionArccosineFast_fields* MaterialExpressionArccosineFast_ptr => (MaterialExpressionArccosineFast_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionArccosineFast(IntPtr p) => UObject.Make<MaterialExpressionArccosineFast>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionArccosineFast DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionArccosineFast New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
