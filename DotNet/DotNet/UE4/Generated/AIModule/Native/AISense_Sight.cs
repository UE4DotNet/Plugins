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
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct AISense_Sight_fields {
        [FieldOffset(328)] public int MaxTracesPerTick;
        [FieldOffset(332)] public int MinQueriesPerTimeSliceCheck;
        [FieldOffset(336)] public double MaxTimeSlicePerTick;
        [FieldOffset(344)] public float HighImportanceQueryDistanceThreshold;
        [FieldOffset(352)] public float MaxQueryImportance;
        [FieldOffset(356)] public float SightLimitQueryImportance;
    }
    internal unsafe struct AISense_Sight_methods {
    }
    internal unsafe struct AISense_Sight_events {
    }
}
