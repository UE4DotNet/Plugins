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
    [StructLayout( LayoutKind.Explicit, Size=1296 )]
    internal unsafe struct AnimBlueprint_fields {
        [FieldOffset(1160)]  public IntPtr  TargetSkeleton;
        [FieldOffset(1168)] public NativeArray Groups;
        [FieldOffset(1184)] public bool bUseMultiThreadedAnimationUpdate;
        [FieldOffset(1185)] public bool bWarnAboutBlueprintUsage;
        [FieldOffset(1216)] public NativeArray ParentAssetOverrides;
        [FieldOffset(1232)] public NativeArray PoseWatches;
        [FieldOffset(1248)] byte PreviewSkeletalMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
    }
    internal unsafe struct AnimBlueprint_methods {
    }
    internal unsafe struct AnimBlueprint_events {
    }
}
