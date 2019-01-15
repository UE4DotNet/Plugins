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


namespace UE4.AlembicLibrary.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct AbcImportSettings_fields {
        [FieldOffset(56)] byte ImportType; //TODO: enum EAlembicImportType ImportType
        [FieldOffset(60)] public AbcSamplingSettings SamplingSettings;
        [FieldOffset(84)] public AbcNormalGenerationSettings NormalGenerationSettings;
        [FieldOffset(96)] public AbcMaterialSettings MaterialSettings;
        [FieldOffset(100)] public AbcCompressionSettings CompressionSettings;
        [FieldOffset(116)] public AbcStaticMeshSettings StaticMeshSettings;
        [FieldOffset(120)] public AbcGeometryCacheSettings GeometryCacheSettings;
        [FieldOffset(132)] public AbcConversionSettings ConversionSettings;
    }
    internal unsafe struct AbcImportSettings_methods {
    }
    internal unsafe struct AbcImportSettings_events {
    }
}
