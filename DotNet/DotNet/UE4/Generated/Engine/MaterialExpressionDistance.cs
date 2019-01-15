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
    ///<summary>Material Expression Distance</summary>
    public unsafe partial class MaterialExpressionDistance : MaterialExpression  {
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionDistance_ptr->A;}
            set {MaterialExpressionDistance_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionDistance_ptr->B;}
            set {MaterialExpressionDistance_ptr->B = value;}
        }
        static MaterialExpressionDistance() {
            StaticClass = Main.GetClass("MaterialExpressionDistance");
        }
        internal unsafe MaterialExpressionDistance_fields* MaterialExpressionDistance_ptr => (MaterialExpressionDistance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDistance(IntPtr p) => UObject.Make<MaterialExpressionDistance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDistance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDistance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
