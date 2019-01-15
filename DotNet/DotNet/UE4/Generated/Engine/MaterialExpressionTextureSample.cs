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
    ///<summary>Material Expression Texture Sample</summary>
    public unsafe partial class MaterialExpressionTextureSample : MaterialExpressionTextureBase  {
        ///<summary>Defaults to 'ConstCoordinate' if not specified</summary>
        public unsafe ExpressionInput Coordinates {
            get {return MaterialExpressionTextureSample_ptr->Coordinates;}
            set {MaterialExpressionTextureSample_ptr->Coordinates = value;}
        }
        ///<summary>Defaults to 'Texture' if not specified</summary>
        public unsafe ExpressionInput TextureObject {
            get {return MaterialExpressionTextureSample_ptr->TextureObject;}
            set {MaterialExpressionTextureSample_ptr->TextureObject = value;}
        }
        ///<summary>Defaults to 'AutomaticViewMipBias' if not specified</summary>
        public unsafe ExpressionInput MipValue {
            get {return MaterialExpressionTextureSample_ptr->MipValue;}
            set {MaterialExpressionTextureSample_ptr->MipValue = value;}
        }
        ///<summary>Coordinates derivative over the X axis</summary>
        public unsafe ExpressionInput CoordinatesDX {
            get {return MaterialExpressionTextureSample_ptr->CoordinatesDX;}
            set {MaterialExpressionTextureSample_ptr->CoordinatesDX = value;}
        }
        ///<summary>Coordinates derivative over the Y axis</summary>
        public unsafe ExpressionInput CoordinatesDY {
            get {return MaterialExpressionTextureSample_ptr->CoordinatesDY;}
            set {MaterialExpressionTextureSample_ptr->CoordinatesDY = value;}
        }
        ///<summary>Ignored if not specified</summary>
        public unsafe ExpressionInput AutomaticViewMipBiasValue {
            get {return MaterialExpressionTextureSample_ptr->AutomaticViewMipBiasValue;}
            set {MaterialExpressionTextureSample_ptr->AutomaticViewMipBiasValue = value;}
        }
        ///<summary>Defines how the MipValue property is applied to the texture lookup</summary>
        public unsafe byte MipValueMode {
            get {return MaterialExpressionTextureSample_ptr->MipValueMode;}
            set {MaterialExpressionTextureSample_ptr->MipValueMode = value;}
        }
        ///<summary>Controls where the sampler for this texture lookup will come from.</summary>
        ///<remarks>
        ///Choose 'from texture asset' to make use of the UTexture addressing settings,
        ///Otherwise use one of the global samplers, which will not consume a sampler slot.
        ///This allows materials to use more than 16 unique textures on SM5 platforms.
        ///</remarks>
        public unsafe byte SamplerSource {
            get {return MaterialExpressionTextureSample_ptr->SamplerSource;}
            set {MaterialExpressionTextureSample_ptr->SamplerSource = value;}
        }
         //TODO: numeric uint32 ConstCoordinate
        ///<summary>only used if MipValue is not hooked up</summary>
        public unsafe int ConstMipValue {
            get {return MaterialExpressionTextureSample_ptr->ConstMipValue;}
            set {MaterialExpressionTextureSample_ptr->ConstMipValue = value;}
        }
        public bool AutomaticViewMipBias {
            get {return Main.GetGetBoolPropertyByName(this, "AutomaticViewMipBias"); }
            set {Main.SetGetBoolPropertyByName(this, "AutomaticViewMipBias", value); }
        }
        static MaterialExpressionTextureSample() {
            StaticClass = Main.GetClass("MaterialExpressionTextureSample");
        }
        internal unsafe MaterialExpressionTextureSample_fields* MaterialExpressionTextureSample_ptr => (MaterialExpressionTextureSample_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTextureSample(IntPtr p) => UObject.Make<MaterialExpressionTextureSample>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTextureSample DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTextureSample New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
