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
    [StructLayout( LayoutKind.Explicit, Size=984 )]
    internal unsafe struct SoundCue_fields {
        [FieldOffset(192)] public bool bOverrideAttenuation;
        [FieldOffset(192)] public bool bExcludeFromRandomNodeBranchCulling;
        [FieldOffset(200)]  public IntPtr  FirstNode;
        [FieldOffset(208)] public float VolumeMultiplier;
        [FieldOffset(212)] public float PitchMultiplier;
        [FieldOffset(216)] public SoundAttenuationSettings AttenuationOverrides;
        [FieldOffset(936)] public NativeArray AllNodes;
        [FieldOffset(952)]  public IntPtr  SoundCueGraph;
        [FieldOffset(960)] public float SubtitlePriority;
    }
    internal unsafe struct SoundCue_methods {
    }
    internal unsafe struct SoundCue_events {
    }
}
