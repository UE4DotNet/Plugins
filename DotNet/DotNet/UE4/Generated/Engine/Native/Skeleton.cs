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
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct Skeleton_fields {
        [FieldOffset(72)] public NativeArray BoneTree;
        [FieldOffset(384)] public FGuid VirtualBoneGuid;
        [FieldOffset(400)] public NativeArray VirtualBones;
        [FieldOffset(416)] public NativeArray Sockets;
        [FieldOffset(512)] public SmartNameContainer SmartNames;
        [FieldOffset(616)] public NativeArray BlendProfiles;
        [FieldOffset(632)] public NativeArray SlotGroups;
        [FieldOffset(728)] byte PreviewSkeletalMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
        [FieldOffset(776)] byte AdditionalPreviewSkeletalMeshes; //TODO: soft object TSoftObjectPtr<UDataAsset> AdditionalPreviewSkeletalMeshes
        [FieldOffset(824)] public RigConfiguration RigConfig;
        [FieldOffset(848)] public NativeArray AnimationNotifies;
        [FieldOffset(864)] public PreviewAssetAttachContainer PreviewAttachedAssetContainer;
        [FieldOffset(1024)] public NativeArray AssetUserData;
    }
    internal unsafe struct Skeleton_methods {
    }
    internal unsafe struct Skeleton_events {
    }
}
