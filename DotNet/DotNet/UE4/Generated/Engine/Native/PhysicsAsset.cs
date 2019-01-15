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
    [StructLayout( LayoutKind.Explicit, Size=448 )]
    internal unsafe struct PhysicsAsset_fields {
        [FieldOffset(72)] byte PreviewSkeletalMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
        [FieldOffset(120)] public NativeArray PhysicalAnimationProfiles;
        [FieldOffset(136)] public NativeArray ConstraintProfiles;
        [FieldOffset(152)] public Name CurrentPhysicalAnimationProfileName;
        [FieldOffset(164)] public Name CurrentConstraintProfileName;
        [FieldOffset(176)] public NativeArray BoundsBodies;
        [FieldOffset(192)] public NativeArray SkeletalBodySetups;
        [FieldOffset(208)] public NativeArray ConstraintSetup;
        [FieldOffset(224)] public bool bUseAsyncScene;
        [FieldOffset(224)] public bool bNotForDedicatedServer;
        [FieldOffset(392)]  public IntPtr  ThumbnailInfo;
    }
    internal unsafe struct PhysicsAsset_methods {
    }
    internal unsafe struct PhysicsAsset_events {
    }
}
