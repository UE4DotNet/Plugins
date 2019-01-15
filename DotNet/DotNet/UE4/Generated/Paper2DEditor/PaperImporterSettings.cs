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
using UE4.Paper2DEditor.Native;

namespace UE4.Paper2DEditor {
    ///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
    public unsafe partial class PaperImporterSettings : UObject  {
        public bool bPickBestMaterialWhenCreatingSprites {
            get {return Main.GetGetBoolPropertyByName(this, "bPickBestMaterialWhenCreatingSprites"); }
            set {Main.SetGetBoolPropertyByName(this, "bPickBestMaterialWhenCreatingSprites", value); }
        }
        public bool bPickBestMaterialWhenCreatingTileMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bPickBestMaterialWhenCreatingTileMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bPickBestMaterialWhenCreatingTileMaps", value); }
        }
        public bool bAnalysisCanUseOpaque {
            get {return Main.GetGetBoolPropertyByName(this, "bAnalysisCanUseOpaque"); }
            set {Main.SetGetBoolPropertyByName(this, "bAnalysisCanUseOpaque", value); }
        }
        ///<summary>The default scaling factor between pixels and Unreal units (cm) to use for newly created sprite assets (e.g., 0.64 would make a 64 pixel wide sprite take up 100 cm)</summary>
        public unsafe float DefaultPixelsPerUnrealUnit {
            get {return PaperImporterSettings_ptr->DefaultPixelsPerUnrealUnit;}
            set {PaperImporterSettings_ptr->DefaultPixelsPerUnrealUnit = value;}
        }
         //TODO: array not UObject TArray NormalMapTextureSuffixes
         //TODO: array not UObject TArray BaseMapTextureSuffixes
        ///<summary>The default texture group for imported sprite textures, tile sheets, etc... (typically set to UI for 'modern 2D' or 2D pixels for 'retro 2D')</summary>
        public unsafe byte DefaultSpriteTextureGroup {
            get {return PaperImporterSettings_ptr->DefaultSpriteTextureGroup;}
            set {PaperImporterSettings_ptr->DefaultSpriteTextureGroup = value;}
        }
        public bool bOverrideTextureCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideTextureCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideTextureCompression", value); }
        }
        ///<summary>Compression settings to use when building the texture.</summary>
        ///<remarks>The default texture group for imported sprite textures, tile sheets, etc... (typically set to UI for 'modern 2D' or 2D pixels for 'retro 2D')</remarks>
        public unsafe byte DefaultSpriteTextureCompression {
            get {return PaperImporterSettings_ptr->DefaultSpriteTextureCompression;}
            set {PaperImporterSettings_ptr->DefaultSpriteTextureCompression = value;}
        }
        ///<summary>The unlit default masked material for newly created sprites (masked means binary opacity: things are either opaque or see-thru, with nothing in between)</summary>
        public unsafe SoftObjectPath UnlitDefaultMaskedMaterialName {
            get {return PaperImporterSettings_ptr->UnlitDefaultMaskedMaterialName;}
            set {PaperImporterSettings_ptr->UnlitDefaultMaskedMaterialName = value;}
        }
        ///<summary>The unlit default translucent material for newly created sprites (translucent means smooth opacity which can vary continuously from 0..1, but translucent rendering is more expensive that opaque or masked rendering and has different sorting rules)</summary>
        public unsafe SoftObjectPath UnlitDefaultTranslucentMaterialName {
            get {return PaperImporterSettings_ptr->UnlitDefaultTranslucentMaterialName;}
            set {PaperImporterSettings_ptr->UnlitDefaultTranslucentMaterialName = value;}
        }
        ///<summary>The unlit default opaque material for newly created sprites</summary>
        public unsafe SoftObjectPath UnlitDefaultOpaqueMaterialName {
            get {return PaperImporterSettings_ptr->UnlitDefaultOpaqueMaterialName;}
            set {PaperImporterSettings_ptr->UnlitDefaultOpaqueMaterialName = value;}
        }
        ///<summary>The lit default masked material for newly created sprites (masked means binary opacity: things are either opaque or see-thru, with nothing in between)</summary>
        public unsafe SoftObjectPath LitDefaultMaskedMaterialName {
            get {return PaperImporterSettings_ptr->LitDefaultMaskedMaterialName;}
            set {PaperImporterSettings_ptr->LitDefaultMaskedMaterialName = value;}
        }
        ///<summary>The lit default translucent material for newly created sprites (translucent means smooth opacity which can vary continuously from 0..1, but translucent rendering is more expensive that opaque or masked rendering and has different sorting rules)</summary>
        public unsafe SoftObjectPath LitDefaultTranslucentMaterialName {
            get {return PaperImporterSettings_ptr->LitDefaultTranslucentMaterialName;}
            set {PaperImporterSettings_ptr->LitDefaultTranslucentMaterialName = value;}
        }
        ///<summary>The lit default opaque material for newly created sprites</summary>
        public unsafe SoftObjectPath LitDefaultOpaqueMaterialName {
            get {return PaperImporterSettings_ptr->LitDefaultOpaqueMaterialName;}
            set {PaperImporterSettings_ptr->LitDefaultOpaqueMaterialName = value;}
        }
        static PaperImporterSettings() {
            StaticClass = Main.GetClass("PaperImporterSettings");
        }
        internal unsafe PaperImporterSettings_fields* PaperImporterSettings_ptr => (PaperImporterSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperImporterSettings(IntPtr p) => UObject.Make<PaperImporterSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperImporterSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperImporterSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
