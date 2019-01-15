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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>This is a texture sampler 2D with a special automatically defined parameter name. The texture specified here will be replaced by the SourceTexture or an AdditionalSourceTextures entry of a Paper2D sprite if this material is used on a sprite.</summary>
    public unsafe partial class MaterialExpressionSpriteTextureSampler : MaterialExpressionTextureSampleParameter2D  {
        public bool bSampleAdditionalTextures {
            get {return Main.GetGetBoolPropertyByName(this, "bSampleAdditionalTextures"); }
            set {Main.SetGetBoolPropertyByName(this, "bSampleAdditionalTextures", value); }
        }
        ///<summary>This is the slot index into the AdditionalSourceTextures array</summary>
        public unsafe int AdditionalSlotIndex {
            get {return MaterialExpressionSpriteTextureSampler_ptr->AdditionalSlotIndex;}
            set {MaterialExpressionSpriteTextureSampler_ptr->AdditionalSlotIndex = value;}
        }
         //TODO: text FText SlotDisplayName
        static MaterialExpressionSpriteTextureSampler() {
            StaticClass = Main.GetClass("MaterialExpressionSpriteTextureSampler");
        }
        internal unsafe MaterialExpressionSpriteTextureSampler_fields* MaterialExpressionSpriteTextureSampler_ptr => (MaterialExpressionSpriteTextureSampler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSpriteTextureSampler(IntPtr p) => UObject.Make<MaterialExpressionSpriteTextureSampler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSpriteTextureSampler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSpriteTextureSampler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
