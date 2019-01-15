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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct SoundNodeRandom_fields {
        [FieldOffset(80)] public NativeArray Weights;
        [FieldOffset(96)] public int PreselectAtLevelLoad;
        [FieldOffset(100)] public bool bShouldExcludeFromBranchCulling;
        [FieldOffset(100)] public bool bSoundCueExcludedFromBranchCulling;
        [FieldOffset(104)] public bool bRandomizeWithoutReplacement;
        [FieldOffset(112)] public NativeArray HasBeenUsed;
        [FieldOffset(128)] public int NumRandomUsed;
        [FieldOffset(136)] public NativeArray PIEHiddenNodes;
    }
    internal unsafe struct SoundNodeRandom_methods {
    }
    internal unsafe struct SoundNodeRandom_events {
    }
}
