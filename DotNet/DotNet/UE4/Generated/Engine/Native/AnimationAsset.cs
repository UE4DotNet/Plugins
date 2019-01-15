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
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct AnimationAsset_fields {
        [FieldOffset(72)]  public IntPtr  Skeleton;
        [FieldOffset(112)] public NativeArray MetaData;
        [FieldOffset(128)]  public IntPtr  ParentAsset;
        [FieldOffset(136)] public NativeArray ChildrenAssets;
        [FieldOffset(152)]  public IntPtr  AssetMappingTable;
        [FieldOffset(160)] public NativeArray AssetUserData;
        [FieldOffset(176)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(184)]  public IntPtr  PreviewPoseAsset;
        [FieldOffset(192)] byte PreviewSkeletalMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
    }
    internal unsafe struct AnimationAsset_methods {
    }
    internal unsafe struct AnimationAsset_events {
    }
}
