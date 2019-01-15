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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Texture Factory</summary>
    public unsafe partial class TextureFactory : Factory  {
        public bool NoCompression {
            get {return Main.GetGetBoolPropertyByName(this, "NoCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "NoCompression", value); }
        }
        public bool NoAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "NoAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "NoAlpha", value); }
        }
        public bool bDeferCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bDeferCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeferCompression", value); }
        }
        ///<summary>Compression settings for the texture</summary>
        public unsafe byte CompressionSettings {
            get {return TextureFactory_ptr->CompressionSettings;}
            set {TextureFactory_ptr->CompressionSettings = value;}
        }
        public bool bCreateMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateMaterial", value); }
        }
        public bool bRGBToBaseColor {
            get {return Main.GetGetBoolPropertyByName(this, "bRGBToBaseColor"); }
            set {Main.SetGetBoolPropertyByName(this, "bRGBToBaseColor", value); }
        }
        public bool bRGBToEmissive {
            get {return Main.GetGetBoolPropertyByName(this, "bRGBToEmissive"); }
            set {Main.SetGetBoolPropertyByName(this, "bRGBToEmissive", value); }
        }
        public bool bAlphaToRoughness {
            get {return Main.GetGetBoolPropertyByName(this, "bAlphaToRoughness"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlphaToRoughness", value); }
        }
        public bool bAlphaToEmissive {
            get {return Main.GetGetBoolPropertyByName(this, "bAlphaToEmissive"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlphaToEmissive", value); }
        }
        public bool bAlphaToOpacity {
            get {return Main.GetGetBoolPropertyByName(this, "bAlphaToOpacity"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlphaToOpacity", value); }
        }
        public bool bAlphaToOpacityMask {
            get {return Main.GetGetBoolPropertyByName(this, "bAlphaToOpacityMask"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlphaToOpacityMask", value); }
        }
        public bool bTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bTwoSided"); }
            set {Main.SetGetBoolPropertyByName(this, "bTwoSided", value); }
        }
        ///<summary>The blend mode of the created material</summary>
        public unsafe byte Blending {
            get {return TextureFactory_ptr->Blending;}
            set {TextureFactory_ptr->Blending = value;}
        }
        ///<summary>The shading model of the created material</summary>
        public unsafe byte ShadingModel {
            get {return TextureFactory_ptr->ShadingModel;}
            set {TextureFactory_ptr->ShadingModel = value;}
        }
        ///<summary>The mip-map generation settings for the texture; Allows customization of the content of the mip-map chain</summary>
        public unsafe byte MipGenSettings {
            get {return TextureFactory_ptr->MipGenSettings;}
            set {TextureFactory_ptr->MipGenSettings = value;}
        }
        ///<summary>The group the texture belongs to</summary>
        public unsafe byte LODGroup {
            get {return TextureFactory_ptr->LODGroup;}
            set {TextureFactory_ptr->LODGroup = value;}
        }
        public bool bDitherMipMapAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bDitherMipMapAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bDitherMipMapAlpha", value); }
        }
        ///<summary>Channel values to compare to when preserving alpha coverage from a mask for mips</summary>
        public unsafe Vector4 AlphaCoverageThresholds {
            get {return TextureFactory_ptr->AlphaCoverageThresholds;}
            set {TextureFactory_ptr->AlphaCoverageThresholds = value;}
        }
        public bool bPreserveBorder {
            get {return Main.GetGetBoolPropertyByName(this, "bPreserveBorder"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreserveBorder", value); }
        }
        public bool bFlipNormalMapGreenChannel {
            get {return Main.GetGetBoolPropertyByName(this, "bFlipNormalMapGreenChannel"); }
            set {Main.SetGetBoolPropertyByName(this, "bFlipNormalMapGreenChannel", value); }
        }
        public bool bUsingExistingSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bUsingExistingSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsingExistingSettings", value); }
        }
        static TextureFactory() {
            StaticClass = Main.GetClass("TextureFactory");
        }
        internal unsafe TextureFactory_fields* TextureFactory_ptr => (TextureFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureFactory(IntPtr p) => UObject.Make<TextureFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
