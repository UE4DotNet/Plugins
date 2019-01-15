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
    ///<summary>Texture</summary>
    public unsafe partial class Texture : UObject  {
        ///<summary>Source</summary>
        public unsafe TextureSource Source {
            get {return Texture_ptr->Source;}
            set {Texture_ptr->Source = value;}
        }
        ///<summary>Unique ID for this material, used for caching during distributed lighting</summary>
        public unsafe FGuid LightingGuid {
            get {return Texture_ptr->LightingGuid;}
            set {Texture_ptr->LightingGuid = value;}
        }
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return Texture_ptr->AssetImportData;}
            set {Texture_ptr->AssetImportData = value;}
        }
        ///<summary>Static texture brightness adjustment (scales HSV value.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustBrightness {
            get {return Texture_ptr->AdjustBrightness;}
            set {Texture_ptr->AdjustBrightness = value;}
        }
        ///<summary>Static texture curve adjustment (raises HSV value to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustBrightnessCurve {
            get {return Texture_ptr->AdjustBrightnessCurve;}
            set {Texture_ptr->AdjustBrightnessCurve = value;}
        }
        ///<summary>Static texture "vibrance" adjustment (0 - 1) (HSV saturation algorithm adjustment.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustVibrance {
            get {return Texture_ptr->AdjustVibrance;}
            set {Texture_ptr->AdjustVibrance = value;}
        }
        ///<summary>Static texture saturation adjustment (scales HSV saturation.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustSaturation {
            get {return Texture_ptr->AdjustSaturation;}
            set {Texture_ptr->AdjustSaturation = value;}
        }
        ///<summary>Static texture RGB curve adjustment (raises linear-space RGB color to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustRGBCurve {
            get {return Texture_ptr->AdjustRGBCurve;}
            set {Texture_ptr->AdjustRGBCurve = value;}
        }
        ///<summary>Static texture hue adjustment (0 - 360) (offsets HSV hue by value in degrees.)  (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustHue {
            get {return Texture_ptr->AdjustHue;}
            set {Texture_ptr->AdjustHue = value;}
        }
        ///<summary>Remaps the alpha to the specified min/max range, defines the new value of 0 (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustMinAlpha {
            get {return Texture_ptr->AdjustMinAlpha;}
            set {Texture_ptr->AdjustMinAlpha = value;}
        }
        ///<summary>Remaps the alpha to the specified min/max range, defines the new value of 1 (Non-destructive; Requires texture source art to be available.)</summary>
        public unsafe float AdjustMaxAlpha {
            get {return Texture_ptr->AdjustMaxAlpha;}
            set {Texture_ptr->AdjustMaxAlpha = value;}
        }
        public bool CompressionNoAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "CompressionNoAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "CompressionNoAlpha", value); }
        }
        public bool CompressionNone {
            get {return Main.GetGetBoolPropertyByName(this, "CompressionNone"); }
            set {Main.SetGetBoolPropertyByName(this, "CompressionNone", value); }
        }
        public bool DeferCompression {
            get {return Main.GetGetBoolPropertyByName(this, "DeferCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "DeferCompression", value); }
        }
        ///<summary>The maximum resolution for generated textures. A value of 0 means the maximum size for the format on each platform, except HDR long/lat cubemaps, which default to a resolution of 512.</summary>
        public unsafe int MaxTextureSize {
            get {return Texture_ptr->MaxTextureSize;}
        }
        ///<summary>The compression quality for generated textures.</summary>
        public unsafe byte CompressionQuality {
            get {return Texture_ptr->CompressionQuality;}
            set {Texture_ptr->CompressionQuality = value;}
        }
        public bool bDitherMipMapAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bDitherMipMapAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bDitherMipMapAlpha", value); }
        }
        ///<summary>Alpha values per channel to compare to when preserving alpha coverage.</summary>
        public unsafe Vector4 AlphaCoverageThresholds {
            get {return Texture_ptr->AlphaCoverageThresholds;}
            set {Texture_ptr->AlphaCoverageThresholds = value;}
        }
        public bool bPreserveBorder {
            get {return Main.GetGetBoolPropertyByName(this, "bPreserveBorder"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreserveBorder", value); }
        }
        public bool bFlipGreenChannel {
            get {return Main.GetGetBoolPropertyByName(this, "bFlipGreenChannel"); }
            set {Main.SetGetBoolPropertyByName(this, "bFlipGreenChannel", value); }
        }
        public bool bForcePVRTC4 {
            get {return Main.GetGetBoolPropertyByName(this, "bForcePVRTC4"); }
            set {Main.SetGetBoolPropertyByName(this, "bForcePVRTC4", value); }
        }
        ///<summary>How to pad the texture to a power of 2 size (if necessary)</summary>
        public unsafe byte PowerOfTwoMode {
            get {return Texture_ptr->PowerOfTwoMode;}
            set {Texture_ptr->PowerOfTwoMode = value;}
        }
        ///<summary>The color used to pad the texture out if it is resized due to PowerOfTwoMode</summary>
        public unsafe Color PaddingColor {
            get {return Texture_ptr->PaddingColor;}
            set {Texture_ptr->PaddingColor = value;}
        }
        public bool bChromaKeyTexture {
            get {return Main.GetGetBoolPropertyByName(this, "bChromaKeyTexture"); }
            set {Main.SetGetBoolPropertyByName(this, "bChromaKeyTexture", value); }
        }
        ///<summary>The threshold that components have to match for the texel to be considered equal to the ChromaKeyColor when chroma keying (<=, set to 0 to require a perfect exact match)</summary>
        public unsafe float ChromaKeyThreshold {
            get {return Texture_ptr->ChromaKeyThreshold;}
            set {Texture_ptr->ChromaKeyThreshold = value;}
        }
        ///<summary>The color that will be replaced with transparent black if chroma keying is enabled</summary>
        public unsafe Color ChromaKeyColor {
            get {return Texture_ptr->ChromaKeyColor;}
            set {Texture_ptr->ChromaKeyColor = value;}
        }
        ///<summary>Per asset specific setting to define the mip-map generation properties like sharpening and kernel size.</summary>
        public unsafe byte MipGenSettings {
            get {return Texture_ptr->MipGenSettings;}
            set {Texture_ptr->MipGenSettings = value;}
        }
        ///<summary>Can be defined to modify the roughness based on the normal map variation (mostly from mip maps).</summary>
        ///<remarks>
        ///MaxAlpha comes in handy to define a base roughness if no source alpha was there.
        ///Make sure the normal map has at least as many mips as this texture.
        ///</remarks>
        public unsafe Texture CompositeTexture {
            get {return Texture_ptr->CompositeTexture;}
            set {Texture_ptr->CompositeTexture = value;}
        }
        ///<summary>defines how the CompositeTexture is applied, e.g. CTM_RoughnessFromNormalAlpha</summary>
        public unsafe byte CompositeTextureMode {
            get {return Texture_ptr->CompositeTextureMode;}
            set {Texture_ptr->CompositeTextureMode = value;}
        }
        ///<summary>default 1, high values result in a stronger effect e.</summary>
        ///<remarks>
        ///g 1, 2, 4, 8
        ///this is no slider because the texture update would not be fast enough
        ///</remarks>
        public unsafe float CompositePower {
            get {return Texture_ptr->CompositePower;}
            set {Texture_ptr->CompositePower = value;}
        }
        ///<summary>A bias to the index of the top mip level to use.</summary>
        public unsafe int LODBias {
            get {return Texture_ptr->LODBias;}
            set {Texture_ptr->LODBias = value;}
        }
        ///<summary>Number of mip-levels to use for cinematic quality.</summary>
        public unsafe int NumCinematicMipLevels {
            get {return Texture_ptr->NumCinematicMipLevels;}
            set {Texture_ptr->NumCinematicMipLevels = value;}
        }
        ///<summary>Compression settings to use when building the texture.</summary>
        public unsafe byte CompressionSettings {
            get {return Texture_ptr->CompressionSettings;}
            set {Texture_ptr->CompressionSettings = value;}
        }
        ///<summary>The texture filtering mode to use when sampling this texture.</summary>
        public unsafe byte Filter {
            get {return Texture_ptr->Filter;}
            set {Texture_ptr->Filter = value;}
        }
        ///<summary>Texture group this texture belongs to</summary>
        public unsafe byte LODGroup {
            get {return Texture_ptr->LODGroup;}
            set {Texture_ptr->LODGroup = value;}
        }
        public bool SRGB {
            get {return Main.GetGetBoolPropertyByName(this, "SRGB"); }
            set {Main.SetGetBoolPropertyByName(this, "SRGB", value); }
        }
        public bool bUseLegacyGamma {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLegacyGamma"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLegacyGamma", value); }
        }
        public bool NeverStream {
            get {return Main.GetGetBoolPropertyByName(this, "NeverStream"); }
            set {Main.SetGetBoolPropertyByName(this, "NeverStream", value); }
        }
        public bool bNoTiling {
            get {return Main.GetGetBoolPropertyByName(this, "bNoTiling"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoTiling", value); }
        }
        public bool bUseCinematicMipLevels {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCinematicMipLevels"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCinematicMipLevels", value); }
        }
        public bool bAsyncResourceReleaseHasBeenStarted {
            get {return Main.GetGetBoolPropertyByName(this, "bAsyncResourceReleaseHasBeenStarted"); }
            set {Main.SetGetBoolPropertyByName(this, "bAsyncResourceReleaseHasBeenStarted", value); }
        }
        ///<summary>Cached combined group and texture LOD bias to use.</summary>
        public unsafe int CachedCombinedLODBias {
            get {return Texture_ptr->CachedCombinedLODBias;}
            set {Texture_ptr->CachedCombinedLODBias = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&Texture_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        static Texture() {
            StaticClass = Main.GetClass("Texture");
        }
        internal unsafe Texture_fields* Texture_ptr => (Texture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Texture(IntPtr p) => UObject.Make<Texture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Texture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Texture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
