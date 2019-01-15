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
    ///<summary>Material Expression Make Material Attributes</summary>
    public unsafe partial class MaterialExpressionMakeMaterialAttributes : MaterialExpression  {
        ///<summary>Base Color</summary>
        public unsafe ExpressionInput BaseColor {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->BaseColor;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->BaseColor = value;}
        }
        ///<summary>Metallic</summary>
        public unsafe ExpressionInput Metallic {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Metallic;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Metallic = value;}
        }
        ///<summary>Specular</summary>
        public unsafe ExpressionInput Specular {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Specular;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Specular = value;}
        }
        ///<summary>Roughness</summary>
        public unsafe ExpressionInput Roughness {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Roughness;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Roughness = value;}
        }
        ///<summary>Emissive Color</summary>
        public unsafe ExpressionInput EmissiveColor {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->EmissiveColor;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->EmissiveColor = value;}
        }
        ///<summary>Opacity</summary>
        public unsafe ExpressionInput Opacity {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Opacity;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Opacity = value;}
        }
        ///<summary>Opacity Mask</summary>
        public unsafe ExpressionInput OpacityMask {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->OpacityMask;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->OpacityMask = value;}
        }
        ///<summary>Normal</summary>
        public unsafe ExpressionInput Normal {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Normal;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Normal = value;}
        }
        ///<summary>World Position Offset</summary>
        public unsafe ExpressionInput WorldPositionOffset {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->WorldPositionOffset;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->WorldPositionOffset = value;}
        }
        ///<summary>World Displacement</summary>
        public unsafe ExpressionInput WorldDisplacement {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->WorldDisplacement;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->WorldDisplacement = value;}
        }
        ///<summary>Tessellation Multiplier</summary>
        public unsafe ExpressionInput TessellationMultiplier {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->TessellationMultiplier;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->TessellationMultiplier = value;}
        }
        ///<summary>Subsurface Color</summary>
        public unsafe ExpressionInput SubsurfaceColor {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->SubsurfaceColor;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->SubsurfaceColor = value;}
        }
        ///<summary>Clear Coat</summary>
        public unsafe ExpressionInput ClearCoat {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->ClearCoat;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->ClearCoat = value;}
        }
        ///<summary>Clear Coat Roughness</summary>
        public unsafe ExpressionInput ClearCoatRoughness {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->ClearCoatRoughness;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->ClearCoatRoughness = value;}
        }
        ///<summary>Ambient Occlusion</summary>
        public unsafe ExpressionInput AmbientOcclusion {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->AmbientOcclusion;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->AmbientOcclusion = value;}
        }
        ///<summary>Refraction</summary>
        public unsafe ExpressionInput Refraction {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->Refraction;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->Refraction = value;}
        }
        ///<summary>Customized UVs</summary>
        public unsafe ExpressionInput CustomizedUVs {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->CustomizedUVs;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->CustomizedUVs = value;}
        }
        ///<summary>Pixel Depth Offset</summary>
        public unsafe ExpressionInput PixelDepthOffset {
            get {return MaterialExpressionMakeMaterialAttributes_ptr->PixelDepthOffset;}
            set {MaterialExpressionMakeMaterialAttributes_ptr->PixelDepthOffset = value;}
        }
        static MaterialExpressionMakeMaterialAttributes() {
            StaticClass = Main.GetClass("MaterialExpressionMakeMaterialAttributes");
        }
        internal unsafe MaterialExpressionMakeMaterialAttributes_fields* MaterialExpressionMakeMaterialAttributes_ptr => (MaterialExpressionMakeMaterialAttributes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMakeMaterialAttributes(IntPtr p) => UObject.Make<MaterialExpressionMakeMaterialAttributes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMakeMaterialAttributes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMakeMaterialAttributes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
