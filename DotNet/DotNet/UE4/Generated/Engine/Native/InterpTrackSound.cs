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
    [StructLayout( LayoutKind.Explicit, Size=232 )]
    internal unsafe struct InterpTrackSound_fields {
        [FieldOffset(208)] public NativeArray Sounds;
        [FieldOffset(224)] public bool bPlayOnReverse;
        [FieldOffset(224)] public bool bContinueSoundOnMatineeEnd;
        [FieldOffset(224)] public bool bSuppressSubtitles;
        [FieldOffset(224)] public bool bTreatAsDialogue;
        [FieldOffset(224)] public bool bAttach;
    }
    internal unsafe struct InterpTrackSound_methods {
    }
    internal unsafe struct InterpTrackSound_events {
    }
}
