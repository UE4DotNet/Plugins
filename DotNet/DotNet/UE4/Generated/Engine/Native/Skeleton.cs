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
    [StructLayout( LayoutKind.Explicit, Size=1056 )]
    internal unsafe struct Skeleton_fields {
        [FieldOffset(72)] public NativeArray BoneTree;
        [FieldOffset(384)] public FGuid VirtualBoneGuid;
        [FieldOffset(400)] public NativeArray VirtualBones;
        [FieldOffset(416)] public NativeArray Sockets;
        [FieldOffset(512)] public SmartNameContainer SmartNames;
        [FieldOffset(632)] public NativeArray BlendProfiles;
        [FieldOffset(648)] public NativeArray SlotGroups;
        [FieldOffset(744)] byte PreviewSkeletalMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
        [FieldOffset(792)] byte AdditionalPreviewSkeletalMeshes; //TODO: soft object TSoftObjectPtr<UDataAsset> AdditionalPreviewSkeletalMeshes
        [FieldOffset(840)] public RigConfiguration RigConfig;
        [FieldOffset(864)] public NativeArray AnimationNotifies;
        [FieldOffset(880)] public PreviewAssetAttachContainer PreviewAttachedAssetContainer;
        [FieldOffset(1040)] public NativeArray AssetUserData;
    }
    internal unsafe struct Skeleton_methods {
    }
    internal unsafe struct Skeleton_events {
    }
}
