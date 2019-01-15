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
    ///<summary>Material Expression Scene Depth</summary>
    public unsafe partial class MaterialExpressionSceneDepth : MaterialExpression  {
        ///<summary>Coordinates - UV coordinates to apply to the scene depth lookup.</summary>
        ///<remarks>OffsetFraction - An offset to apply to the scene depth lookup in a 2d fraction of the screen.</remarks>
        public unsafe byte InputMode {
            get {return MaterialExpressionSceneDepth_ptr->InputMode;}
            set {MaterialExpressionSceneDepth_ptr->InputMode = value;}
        }
        ///<summary>Defaults to 'ConstInput' if not specified</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionSceneDepth_ptr->Input;}
            set {MaterialExpressionSceneDepth_ptr->Input = value;}
        }
        ///<summary>only used if Input is not hooked up</summary>
        public unsafe Vector2D ConstInput {
            get {return MaterialExpressionSceneDepth_ptr->ConstInput;}
            set {MaterialExpressionSceneDepth_ptr->ConstInput = value;}
        }
        static MaterialExpressionSceneDepth() {
            StaticClass = Main.GetClass("MaterialExpressionSceneDepth");
        }
        internal unsafe MaterialExpressionSceneDepth_fields* MaterialExpressionSceneDepth_ptr => (MaterialExpressionSceneDepth_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSceneDepth(IntPtr p) => UObject.Make<MaterialExpressionSceneDepth>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSceneDepth DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSceneDepth New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
