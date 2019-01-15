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
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct NodeMappingContainer_fields {
        [FieldOffset(56)] byte SourceItems; //TODO: map TMap SourceItems
        [FieldOffset(136)] byte TargetItems; //TODO: map TMap TargetItems
        [FieldOffset(216)] byte SourceToTarget; //TODO: map TMap SourceToTarget
        [FieldOffset(296)] byte SourceAsset; //TODO: soft object TSoftObjectPtr<UObject> SourceAsset
        [FieldOffset(344)] byte TargetAsset; //TODO: soft object TSoftObjectPtr<UObject> TargetAsset
    }
    internal unsafe struct NodeMappingContainer_methods {
    }
    internal unsafe struct NodeMappingContainer_events {
    }
}
