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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct AnimCompress_RemoveLinearKeys_fields {
        [FieldOffset(96)] public float MaxPosDiff;
        [FieldOffset(100)] public float MaxAngleDiff;
        [FieldOffset(104)] public float MaxScaleDiff;
        [FieldOffset(108)] public float MaxEffectorDiff;
        [FieldOffset(112)] public float MinEffectorDiff;
        [FieldOffset(116)] public float EffectorDiffSocket;
        [FieldOffset(120)] public float ParentKeyScale;
        [FieldOffset(124)] public bool bRetarget;
        [FieldOffset(124)] public bool bActuallyFilterLinearKeys;
        [FieldOffset(124)] public bool bOptimizeForForwardPlayback;
        [FieldOffset(124)] public bool bUseDecompression;
        [FieldOffset(124)] public bool bUseMultithreading;
    }
    internal unsafe struct AnimCompress_RemoveLinearKeys_methods {
    }
    internal unsafe struct AnimCompress_RemoveLinearKeys_events {
    }
}
