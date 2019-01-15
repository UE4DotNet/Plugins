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
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct FbxExportOption_fields {
        [FieldOffset(56)] byte FbxExportCompatibility; //TODO: enum EFbxExportCompatibility FbxExportCompatibility
        [FieldOffset(60)] public bool bASCII;
        [FieldOffset(60)] public bool bForceFrontXAxis;
        [FieldOffset(60)] public bool VertexColor;
        [FieldOffset(60)] public bool LevelOfDetail;
        [FieldOffset(60)] public bool Collision;
        [FieldOffset(60)] public bool MapSkeletalMotionToRoot;
    }
    internal unsafe struct FbxExportOption_methods {
    }
    internal unsafe struct FbxExportOption_events {
    }
}
