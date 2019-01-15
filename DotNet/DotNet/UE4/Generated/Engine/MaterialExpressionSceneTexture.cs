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
    ///<summary>Material Expression Scene Texture</summary>
    public unsafe partial class MaterialExpressionSceneTexture : MaterialExpression  {
        ///<summary>Ignored if not specified</summary>
        public unsafe ExpressionInput Coordinates {
            get {return MaterialExpressionSceneTexture_ptr->Coordinates;}
            set {MaterialExpressionSceneTexture_ptr->Coordinates = value;}
        }
        ///<summary>Which scene texture (screen aligned texture) we want to make a lookup into</summary>
        public unsafe byte SceneTextureId {
            get {return MaterialExpressionSceneTexture_ptr->SceneTextureId;}
            set {MaterialExpressionSceneTexture_ptr->SceneTextureId = value;}
        }
        public bool bFiltered {
            get {return Main.GetGetBoolPropertyByName(this, "bFiltered"); }
            set {Main.SetGetBoolPropertyByName(this, "bFiltered", value); }
        }
        static MaterialExpressionSceneTexture() {
            StaticClass = Main.GetClass("MaterialExpressionSceneTexture");
        }
        internal unsafe MaterialExpressionSceneTexture_fields* MaterialExpressionSceneTexture_ptr => (MaterialExpressionSceneTexture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSceneTexture(IntPtr p) => UObject.Make<MaterialExpressionSceneTexture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSceneTexture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSceneTexture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
