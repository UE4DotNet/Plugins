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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct SpiralStairBuilder_fields {
        [FieldOffset(144)] public int InnerRadius;
        [FieldOffset(148)] public int StepWidth;
        [FieldOffset(152)] public int StepHeight;
        [FieldOffset(156)] public int StepThickness;
        [FieldOffset(160)] public int NumStepsPer360;
        [FieldOffset(164)] public int NumSteps;
        [FieldOffset(168)] public Name GroupName;
        [FieldOffset(180)] public bool SlopedCeiling;
        [FieldOffset(180)] public bool SlopedFloor;
        [FieldOffset(180)] public bool CounterClockwise;
    }
    internal unsafe struct SpiralStairBuilder_methods {
    }
    internal unsafe struct SpiralStairBuilder_events {
    }
}
