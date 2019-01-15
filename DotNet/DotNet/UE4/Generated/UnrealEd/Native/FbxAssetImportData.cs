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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct FbxAssetImportData_fields {
        [FieldOffset(104)] public Vector ImportTranslation;
        [FieldOffset(116)] public Rotator ImportRotation;
        [FieldOffset(128)] public float ImportUniformScale;
        [FieldOffset(132)] public bool bConvertScene;
        [FieldOffset(133)] public bool bForceFrontXAxis;
        [FieldOffset(134)] public bool bConvertSceneUnit;
        [FieldOffset(135)] public bool bImportAsScene;
        [FieldOffset(136)]  public IntPtr  FbxSceneImportDataReference;
    }
    internal unsafe struct FbxAssetImportData_methods {
    }
    internal unsafe struct FbxAssetImportData_events {
    }
}
