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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct AnimCompress_RemoveLinearKeys_fields {
        [FieldOffset(88)] public float MaxPosDiff;
        [FieldOffset(92)] public float MaxAngleDiff;
        [FieldOffset(96)] public float MaxScaleDiff;
        [FieldOffset(100)] public float MaxEffectorDiff;
        [FieldOffset(104)] public float MinEffectorDiff;
        [FieldOffset(108)] public float EffectorDiffSocket;
        [FieldOffset(112)] public float ParentKeyScale;
        [FieldOffset(116)] public bool bRetarget;
        [FieldOffset(116)] public bool bActuallyFilterLinearKeys;
    }
    internal unsafe struct AnimCompress_RemoveLinearKeys_methods {
    }
    internal unsafe struct AnimCompress_RemoveLinearKeys_events {
    }
}
