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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct AISenseConfig_Hearing_fields {
        [FieldOffset(88)] public IntPtr Implementation;
        [FieldOffset(96)] public float HearingRange;
        [FieldOffset(100)] public float LoSHearingRange;
        [FieldOffset(104)] public bool bUseLoSHearing;
        [FieldOffset(108)] public AISenseAffiliationFilter DetectionByAffiliation;
    }
    internal unsafe struct AISenseConfig_Hearing_methods {
    }
    internal unsafe struct AISenseConfig_Hearing_events {
    }
}
