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
    ///<summary>Material Expression Transform Position</summary>
    public unsafe partial class MaterialExpressionTransformPosition : MaterialExpression  {
        ///<summary>input expression for this transform</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionTransformPosition_ptr->Input;}
            set {MaterialExpressionTransformPosition_ptr->Input = value;}
        }
        ///<summary>source format of the position that will be transformed</summary>
        public unsafe byte TransformSourceType {
            get {return MaterialExpressionTransformPosition_ptr->TransformSourceType;}
            set {MaterialExpressionTransformPosition_ptr->TransformSourceType = value;}
        }
        ///<summary>type of transform to apply to the input expression</summary>
        public unsafe byte TransformType {
            get {return MaterialExpressionTransformPosition_ptr->TransformType;}
            set {MaterialExpressionTransformPosition_ptr->TransformType = value;}
        }
        static MaterialExpressionTransformPosition() {
            StaticClass = Main.GetClass("MaterialExpressionTransformPosition");
        }
        internal unsafe MaterialExpressionTransformPosition_fields* MaterialExpressionTransformPosition_ptr => (MaterialExpressionTransformPosition_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTransformPosition(IntPtr p) => UObject.Make<MaterialExpressionTransformPosition>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTransformPosition DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTransformPosition New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
