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
    ///<summary>Material Expression Reroute</summary>
    public unsafe partial class MaterialExpressionReroute : MaterialExpression  {
        ///<summary>Link to the input expression to be evaluated</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionReroute_ptr->Input;}
            set {MaterialExpressionReroute_ptr->Input = value;}
        }
        static MaterialExpressionReroute() {
            StaticClass = Main.GetClass("MaterialExpressionReroute");
        }
        internal unsafe MaterialExpressionReroute_fields* MaterialExpressionReroute_ptr => (MaterialExpressionReroute_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionReroute(IntPtr p) => UObject.Make<MaterialExpressionReroute>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionReroute DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionReroute New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
