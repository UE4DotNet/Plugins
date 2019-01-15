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
    ///<summary>Material Expression Depth Of Field Function</summary>
    public unsafe partial class MaterialExpressionDepthOfFieldFunction : MaterialExpression  {
        ///<summary>Determines the mapping place to use on the terrain.</summary>
        public unsafe byte FunctionValue {
            get {return MaterialExpressionDepthOfFieldFunction_ptr->FunctionValue;}
            set {MaterialExpressionDepthOfFieldFunction_ptr->FunctionValue = value;}
        }
        ///<summary>usually nothing or PixelDepth</summary>
        public unsafe ExpressionInput Depth {
            get {return MaterialExpressionDepthOfFieldFunction_ptr->Depth;}
            set {MaterialExpressionDepthOfFieldFunction_ptr->Depth = value;}
        }
        static MaterialExpressionDepthOfFieldFunction() {
            StaticClass = Main.GetClass("MaterialExpressionDepthOfFieldFunction");
        }
        internal unsafe MaterialExpressionDepthOfFieldFunction_fields* MaterialExpressionDepthOfFieldFunction_ptr => (MaterialExpressionDepthOfFieldFunction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDepthOfFieldFunction(IntPtr p) => UObject.Make<MaterialExpressionDepthOfFieldFunction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDepthOfFieldFunction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDepthOfFieldFunction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
