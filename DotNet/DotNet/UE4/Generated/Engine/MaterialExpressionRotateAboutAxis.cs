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
    ///<summary>Material Expression Rotate About Axis</summary>
    public unsafe partial class MaterialExpressionRotateAboutAxis : MaterialExpression  {
        ///<summary>Normalized Rotation Axis</summary>
        public unsafe ExpressionInput NormalizedRotationAxis {
            get {return MaterialExpressionRotateAboutAxis_ptr->NormalizedRotationAxis;}
            set {MaterialExpressionRotateAboutAxis_ptr->NormalizedRotationAxis = value;}
        }
        ///<summary>Rotation Angle</summary>
        public unsafe ExpressionInput RotationAngle {
            get {return MaterialExpressionRotateAboutAxis_ptr->RotationAngle;}
            set {MaterialExpressionRotateAboutAxis_ptr->RotationAngle = value;}
        }
        ///<summary>Pivot Point</summary>
        public unsafe ExpressionInput PivotPoint {
            get {return MaterialExpressionRotateAboutAxis_ptr->PivotPoint;}
            set {MaterialExpressionRotateAboutAxis_ptr->PivotPoint = value;}
        }
        ///<summary>Position</summary>
        public unsafe ExpressionInput Position {
            get {return MaterialExpressionRotateAboutAxis_ptr->Position;}
            set {MaterialExpressionRotateAboutAxis_ptr->Position = value;}
        }
        ///<summary>Period</summary>
        public unsafe float Period {
            get {return MaterialExpressionRotateAboutAxis_ptr->Period;}
            set {MaterialExpressionRotateAboutAxis_ptr->Period = value;}
        }
        static MaterialExpressionRotateAboutAxis() {
            StaticClass = Main.GetClass("MaterialExpressionRotateAboutAxis");
        }
        internal unsafe MaterialExpressionRotateAboutAxis_fields* MaterialExpressionRotateAboutAxis_ptr => (MaterialExpressionRotateAboutAxis_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionRotateAboutAxis(IntPtr p) => UObject.Make<MaterialExpressionRotateAboutAxis>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionRotateAboutAxis DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionRotateAboutAxis New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
