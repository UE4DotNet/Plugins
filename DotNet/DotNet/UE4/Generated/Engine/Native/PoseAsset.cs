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
    [StructLayout( LayoutKind.Explicit, Size=440 )]
    internal unsafe struct PoseAsset_fields {
        [FieldOffset(240)] public PoseDataContainer PoseContainer;
        [FieldOffset(384)] public bool bAdditivePose;
        [FieldOffset(388)] public int BasePoseIndex;
        [FieldOffset(392)] public Name RetargetSource;
        [FieldOffset(408)]  public IntPtr  SourceAnimation;
    }
    internal unsafe struct PoseAsset_methods {
    }
    internal unsafe struct PoseAsset_events {
    }
}
