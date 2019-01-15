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
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct AnimNotify_PlaySound_fields {
        [FieldOffset(72)]  public IntPtr  Sound;
        [FieldOffset(80)] public float VolumeMultiplier;
        [FieldOffset(84)] public float PitchMultiplier;
        [FieldOffset(88)] public bool bFollow;
        [FieldOffset(92)] public Name AttachName;
    }
    internal unsafe struct AnimNotify_PlaySound_methods {
    }
    internal unsafe struct AnimNotify_PlaySound_events {
    }
}
