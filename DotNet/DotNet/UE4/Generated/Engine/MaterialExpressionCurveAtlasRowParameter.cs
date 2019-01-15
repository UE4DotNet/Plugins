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
    ///<summary>Material Expression Curve Atlas Row Parameter</summary>
    public unsafe partial class MaterialExpressionCurveAtlasRowParameter : MaterialExpressionScalarParameter  {
        ///<summary>Curve</summary>
        public unsafe CurveLinearColor Curve {
            get {return MaterialExpressionCurveAtlasRowParameter_ptr->Curve;}
            set {MaterialExpressionCurveAtlasRowParameter_ptr->Curve = value;}
        }
        ///<summary>Atlas</summary>
        public unsafe CurveLinearColorAtlas Atlas {
            get {return MaterialExpressionCurveAtlasRowParameter_ptr->Atlas;}
            set {MaterialExpressionCurveAtlasRowParameter_ptr->Atlas = value;}
        }
        ///<summary>Input Time</summary>
        public unsafe ExpressionInput InputTime {
            get {return MaterialExpressionCurveAtlasRowParameter_ptr->InputTime;}
            set {MaterialExpressionCurveAtlasRowParameter_ptr->InputTime = value;}
        }
        static MaterialExpressionCurveAtlasRowParameter() {
            StaticClass = Main.GetClass("MaterialExpressionCurveAtlasRowParameter");
        }
        internal unsafe MaterialExpressionCurveAtlasRowParameter_fields* MaterialExpressionCurveAtlasRowParameter_ptr => (MaterialExpressionCurveAtlasRowParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionCurveAtlasRowParameter(IntPtr p) => UObject.Make<MaterialExpressionCurveAtlasRowParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionCurveAtlasRowParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionCurveAtlasRowParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
