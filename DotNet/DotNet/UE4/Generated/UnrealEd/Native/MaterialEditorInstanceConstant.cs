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

using UE4.Engine;

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct MaterialEditorInstanceConstant_fields {
        [FieldOffset(56)]  public IntPtr  PhysMaterial;
        [FieldOffset(64)]  public IntPtr  Parent;
        [FieldOffset(72)] public NativeArray ParameterGroups;
        [FieldOffset(88)] public float RefractionDepthBias;
        [FieldOffset(96)]  public IntPtr  SubsurfaceProfile;
        [FieldOffset(104)] public bool bOverrideSubsurfaceProfile;
        [FieldOffset(104)] public bool bIsFunctionPreviewMaterial;
        [FieldOffset(104)] public bool bIsFunctionInstanceDirty;
        [FieldOffset(108)] public MaterialInstanceBasePropertyOverrides BasePropertyOverrides;
        [FieldOffset(128)]  public IntPtr  SourceInstance;
        [FieldOffset(136)]  public IntPtr  SourceFunction;
        [FieldOffset(144)] public NativeArray VisibleExpressions;
        [FieldOffset(160)] public LightmassParameterizedMaterialSettings LightmassSettings;
        [FieldOffset(192)] public bool bUseOldStyleMICEditorGroups;
        [FieldOffset(216)] public NativeArray StoredLayerPreviews;
        [FieldOffset(232)] public NativeArray StoredBlendPreviews;
    }
    internal unsafe struct MaterialEditorInstanceConstant_methods {
    }
    internal unsafe struct MaterialEditorInstanceConstant_events {
    }
}
