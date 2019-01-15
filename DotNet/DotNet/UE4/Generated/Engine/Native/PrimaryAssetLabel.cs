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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct PrimaryAssetLabel_fields {
        [FieldOffset(80)] public PrimaryAssetRules Rules;
        [FieldOffset(96)] public bool bLabelAssetsInMyDirectory;
        [FieldOffset(96)] public bool bIsRuntimeLabel;
        [FieldOffset(104)] public NativeArray ExplicitAssets;
        [FieldOffset(120)] public NativeArray ExplicitBlueprints;
        [FieldOffset(136)] public CollectionReference AssetCollection;
    }
    internal unsafe struct PrimaryAssetLabel_methods {
    }
    internal unsafe struct PrimaryAssetLabel_events {
    }
}
