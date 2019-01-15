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
    [StructLayout( LayoutKind.Explicit, Size=80 )]
    internal unsafe struct MaterialEditorOptions_fields {
        [FieldOffset(56)] public bool bShowGrid;
        [FieldOffset(56)] public bool bHideUnusedConnectors;
        [FieldOffset(56)] public bool bRealtimeMaterialViewport;
        [FieldOffset(56)] public bool bRealtimeExpressionViewport;
        [FieldOffset(56)] public bool bLivePreviewUpdate;
        [FieldOffset(56)] public bool bAlwaysRefreshAllPreviews;
        [FieldOffset(56)] public bool bUseUnsortedMenus;
        [FieldOffset(64)] public NativeArray FavoriteExpressions;
    }
    internal unsafe struct MaterialEditorOptions_methods {
    }
    internal unsafe struct MaterialEditorOptions_events {
    }
}
