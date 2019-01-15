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
    [StructLayout( LayoutKind.Explicit, Size=560 )]
    internal unsafe struct EnvQueryTest_fields {
        [FieldOffset(64)] public int TestOrder;
        [FieldOffset(68)] public byte TestPurpose;
        [FieldOffset(72)] byte TestComment; //TODO: string FString TestComment
        [FieldOffset(88)] public byte MultipleContextFilterOp;
        [FieldOffset(89)] public byte MultipleContextScoreOp;
        [FieldOffset(90)] public byte FilterType;
        [FieldOffset(96)] public AIDataProviderBoolValue BoolValue;
        [FieldOffset(152)] public AIDataProviderFloatValue FloatValueMin;
        [FieldOffset(208)] public AIDataProviderFloatValue FloatValueMax;
        [FieldOffset(265)] public byte ScoringEquation;
        [FieldOffset(266)] public byte ClampMinType;
        [FieldOffset(267)] public byte ClampMaxType;
        [FieldOffset(268)] byte NormalizationType; //TODO: enum EEQSNormalizationType NormalizationType
        [FieldOffset(272)] public AIDataProviderFloatValue ScoreClampMin;
        [FieldOffset(328)] public AIDataProviderFloatValue ScoreClampMax;
        [FieldOffset(384)] public AIDataProviderFloatValue ScoringFactor;
        [FieldOffset(440)] public AIDataProviderFloatValue ReferenceValue;
        [FieldOffset(496)] public bool bDefineReferenceValue;
        [FieldOffset(552)] public bool bWorkOnFloatValues;
    }
    internal unsafe struct EnvQueryTest_methods {
    }
    internal unsafe struct EnvQueryTest_events {
    }
}
