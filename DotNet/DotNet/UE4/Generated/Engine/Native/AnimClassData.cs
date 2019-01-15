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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct AnimClassData_fields {
        [FieldOffset(64)] public NativeArray BakedStateMachines;
        [FieldOffset(80)]  public IntPtr  TargetSkeleton;
        [FieldOffset(88)] public NativeArray AnimNotifies;
        [FieldOffset(104)] public int RootAnimNodeIndex;
        [FieldOffset(112)] public NativeArray OrderedSavedPoseIndices;
        [FieldOffset(128)]  public IntPtr  RootAnimNodeProperty;
        [FieldOffset(136)] public NativeArray AnimNodeProperties;
        [FieldOffset(152)] public NativeArray SyncGroupNames;
    }
    internal unsafe struct AnimClassData_methods {
    }
    internal unsafe struct AnimClassData_events {
    }
}
