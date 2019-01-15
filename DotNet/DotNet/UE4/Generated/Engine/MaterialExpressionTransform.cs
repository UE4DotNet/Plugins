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
    ///<summary>Material Expression Transform</summary>
    public unsafe partial class MaterialExpressionTransform : MaterialExpression  {
        ///<summary>input expression for this transform</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionTransform_ptr->Input;}
            set {MaterialExpressionTransform_ptr->Input = value;}
        }
        ///<summary>Source coordinate space of the FVector</summary>
        public unsafe byte TransformSourceType {
            get {return MaterialExpressionTransform_ptr->TransformSourceType;}
            set {MaterialExpressionTransform_ptr->TransformSourceType = value;}
        }
        ///<summary>Destination coordinate space of the FVector</summary>
        public unsafe byte TransformType {
            get {return MaterialExpressionTransform_ptr->TransformType;}
            set {MaterialExpressionTransform_ptr->TransformType = value;}
        }
        static MaterialExpressionTransform() {
            StaticClass = Main.GetClass("MaterialExpressionTransform");
        }
        internal unsafe MaterialExpressionTransform_fields* MaterialExpressionTransform_ptr => (MaterialExpressionTransform_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTransform(IntPtr p) => UObject.Make<MaterialExpressionTransform>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTransform DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTransform New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
