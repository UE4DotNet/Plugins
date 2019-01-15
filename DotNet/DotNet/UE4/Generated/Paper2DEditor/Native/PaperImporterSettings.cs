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


namespace UE4.Paper2DEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct PaperImporterSettings_fields {
        [FieldOffset(56)] public bool bPickBestMaterialWhenCreatingSprites;
        [FieldOffset(57)] public bool bPickBestMaterialWhenCreatingTileMaps;
        [FieldOffset(58)] public bool bAnalysisCanUseOpaque;
        [FieldOffset(60)] public float DefaultPixelsPerUnrealUnit;
        [FieldOffset(64)] public NativeArray NormalMapTextureSuffixes;
        [FieldOffset(80)] public NativeArray BaseMapTextureSuffixes;
        [FieldOffset(96)] public byte DefaultSpriteTextureGroup;
        [FieldOffset(97)] public bool bOverrideTextureCompression;
        [FieldOffset(98)] public byte DefaultSpriteTextureCompression;
        [FieldOffset(104)] public SoftObjectPath UnlitDefaultMaskedMaterialName;
        [FieldOffset(136)] public SoftObjectPath UnlitDefaultTranslucentMaterialName;
        [FieldOffset(168)] public SoftObjectPath UnlitDefaultOpaqueMaterialName;
        [FieldOffset(200)] public SoftObjectPath LitDefaultMaskedMaterialName;
        [FieldOffset(232)] public SoftObjectPath LitDefaultTranslucentMaterialName;
        [FieldOffset(264)] public SoftObjectPath LitDefaultOpaqueMaterialName;
    }
    internal unsafe struct PaperImporterSettings_methods {
    }
    internal unsafe struct PaperImporterSettings_events {
    }
}
