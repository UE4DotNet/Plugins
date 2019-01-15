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
    ///<summary>Material Expression Scene Color</summary>
    public unsafe partial class MaterialExpressionSceneColor : MaterialExpression  {
        ///<summary>Coordinates - UV coordinates to apply to the scene color lookup.</summary>
        ///<remarks>OffsetFraction -      An offset to apply to the scene color lookup in a 2d fraction of the screen.</remarks>
        public unsafe byte InputMode {
            get {return MaterialExpressionSceneColor_ptr->InputMode;}
            set {MaterialExpressionSceneColor_ptr->InputMode = value;}
        }
        ///<summary>Defaults to 'ConstInput' if not specified</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionSceneColor_ptr->Input;}
            set {MaterialExpressionSceneColor_ptr->Input = value;}
        }
        ///<summary>only used if Input is not hooked up</summary>
        public unsafe Vector2D ConstInput {
            get {return MaterialExpressionSceneColor_ptr->ConstInput;}
            set {MaterialExpressionSceneColor_ptr->ConstInput = value;}
        }
        static MaterialExpressionSceneColor() {
            StaticClass = Main.GetClass("MaterialExpressionSceneColor");
        }
        internal unsafe MaterialExpressionSceneColor_fields* MaterialExpressionSceneColor_ptr => (MaterialExpressionSceneColor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSceneColor(IntPtr p) => UObject.Make<MaterialExpressionSceneColor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSceneColor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSceneColor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
