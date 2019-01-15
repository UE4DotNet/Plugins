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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct FbxTextureImportData_fields {
        [FieldOffset(144)] public bool bInvertNormalMaps;
        [FieldOffset(148)] byte MaterialSearchLocation; //TODO: enum EMaterialSearchLocation MaterialSearchLocation
        [FieldOffset(152)] public SoftObjectPath BaseMaterialName;
        [FieldOffset(184)] byte BaseColorName; //TODO: string FString BaseColorName
        [FieldOffset(200)] byte BaseDiffuseTextureName; //TODO: string FString BaseDiffuseTextureName
        [FieldOffset(216)] byte BaseNormalTextureName; //TODO: string FString BaseNormalTextureName
        [FieldOffset(232)] byte BaseEmissiveColorName; //TODO: string FString BaseEmissiveColorName
        [FieldOffset(248)] byte BaseEmmisiveTextureName; //TODO: string FString BaseEmmisiveTextureName
        [FieldOffset(264)] byte BaseSpecularTextureName; //TODO: string FString BaseSpecularTextureName
    }
    internal unsafe struct FbxTextureImportData_methods {
    }
    internal unsafe struct FbxTextureImportData_events {
    }
}
