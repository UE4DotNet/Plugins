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


namespace UE4.DatasmithContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct DatasmithImportOptions_fields {
        [FieldOffset(56)] byte SearchPackagePolicy; //TODO: enum EDatasmithImportSearchPackagePolicy SearchPackagePolicy
        [FieldOffset(57)] byte MaterialConflictPolicy; //TODO: enum EDatasmithImportAssetConflictPolicy MaterialConflictPolicy
        [FieldOffset(58)] byte TextureConflictPolicy; //TODO: enum EDatasmithImportAssetConflictPolicy TextureConflictPolicy
        [FieldOffset(59)] byte StaticMeshActorImportPolicy; //TODO: enum EDatasmithImportActorPolicy StaticMeshActorImportPolicy
        [FieldOffset(60)] byte LightImportPolicy; //TODO: enum EDatasmithImportActorPolicy LightImportPolicy
        [FieldOffset(61)] byte CameraImportPolicy; //TODO: enum EDatasmithImportActorPolicy CameraImportPolicy
        [FieldOffset(62)] byte OtherActorImportPolicy; //TODO: enum EDatasmithImportActorPolicy OtherActorImportPolicy
        [FieldOffset(63)] byte MaterialQuality; //TODO: enum EDatasmithImportMaterialQuality MaterialQuality
        [FieldOffset(68)] public DatasmithImportBaseOptions BaseOptions;
        [FieldOffset(92)] public DatasmithTessellationOptions TessellationOptions;
        [FieldOffset(104)] public DatasmithReimportOptions ReimportOptions;
    }
    internal unsafe struct DatasmithImportOptions_methods {
    }
    internal unsafe struct DatasmithImportOptions_events {
    }
}
