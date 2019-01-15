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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct AISenseConfig_Sight_fields {
        [FieldOffset(88)] public IntPtr Implementation;
        [FieldOffset(96)] public float SightRadius;
        [FieldOffset(100)] public float LoseSightRadius;
        [FieldOffset(104)] public float PeripheralVisionAngleDegrees;
        [FieldOffset(108)] public AISenseAffiliationFilter DetectionByAffiliation;
        [FieldOffset(112)] public float AutoSuccessRangeFromLastSeenLocation;
    }
    internal unsafe struct AISenseConfig_Sight_methods {
    }
    internal unsafe struct AISenseConfig_Sight_events {
    }
}
