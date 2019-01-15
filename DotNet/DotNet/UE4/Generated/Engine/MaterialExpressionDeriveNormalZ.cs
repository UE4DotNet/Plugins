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
    ///<summary>Material Expression Derive Normal Z</summary>
    public unsafe partial class MaterialExpressionDeriveNormalZ : MaterialExpression  {
        ///<summary>In XY</summary>
        public unsafe ExpressionInput InXY {
            get {return MaterialExpressionDeriveNormalZ_ptr->InXY;}
            set {MaterialExpressionDeriveNormalZ_ptr->InXY = value;}
        }
        static MaterialExpressionDeriveNormalZ() {
            StaticClass = Main.GetClass("MaterialExpressionDeriveNormalZ");
        }
        internal unsafe MaterialExpressionDeriveNormalZ_fields* MaterialExpressionDeriveNormalZ_ptr => (MaterialExpressionDeriveNormalZ_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDeriveNormalZ(IntPtr p) => UObject.Make<MaterialExpressionDeriveNormalZ>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDeriveNormalZ DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDeriveNormalZ New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
