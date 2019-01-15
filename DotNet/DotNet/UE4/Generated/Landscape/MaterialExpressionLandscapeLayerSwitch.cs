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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Material Expression Landscape Layer Switch</summary>
    public unsafe partial class MaterialExpressionLandscapeLayerSwitch : MaterialExpression  {
        ///<summary>Layer Used</summary>
        public unsafe ExpressionInput LayerUsed {
            get {return MaterialExpressionLandscapeLayerSwitch_ptr->LayerUsed;}
            set {MaterialExpressionLandscapeLayerSwitch_ptr->LayerUsed = value;}
        }
        ///<summary>Layer Not Used</summary>
        public unsafe ExpressionInput LayerNotUsed {
            get {return MaterialExpressionLandscapeLayerSwitch_ptr->LayerNotUsed;}
            set {MaterialExpressionLandscapeLayerSwitch_ptr->LayerNotUsed = value;}
        }
        ///<summary>Parameter Name</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionLandscapeLayerSwitch_ptr->ParameterName;}
            set {MaterialExpressionLandscapeLayerSwitch_ptr->ParameterName = value;}
        }
        public bool PreviewUsed {
            get {return Main.GetGetBoolPropertyByName(this, "PreviewUsed"); }
            set {Main.SetGetBoolPropertyByName(this, "PreviewUsed", value); }
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionLandscapeLayerSwitch_ptr->ExpressionGUID;}
            set {MaterialExpressionLandscapeLayerSwitch_ptr->ExpressionGUID = value;}
        }
        static MaterialExpressionLandscapeLayerSwitch() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeLayerSwitch");
        }
        internal unsafe MaterialExpressionLandscapeLayerSwitch_fields* MaterialExpressionLandscapeLayerSwitch_ptr => (MaterialExpressionLandscapeLayerSwitch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeLayerSwitch(IntPtr p) => UObject.Make<MaterialExpressionLandscapeLayerSwitch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeLayerSwitch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeLayerSwitch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
