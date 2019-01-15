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
    [StructLayout( LayoutKind.Explicit, Size=192 )]
    internal unsafe struct SoundBase_fields {
        [FieldOffset(56)]  public IntPtr  SoundClassObject;
        [FieldOffset(64)] public bool bDebug;
        [FieldOffset(64)] public bool bOverrideConcurrency;
        [FieldOffset(64)] public bool bOutputToBusOnly;
        [FieldOffset(64)] public bool bHasDelayNode;
        [FieldOffset(64)] public bool bHasConcatenatorNode;
        [FieldOffset(64)] public bool bHasVirtualizeWhenSilent;
        [FieldOffset(64)] public bool bBypassVolumeScaleForPriority;
        [FieldOffset(72)]  public IntPtr  SoundConcurrencySettings;
        [FieldOffset(80)] public SoundConcurrencySettings ConcurrencyOverrides;
        [FieldOffset(100)] public float Duration;
        [FieldOffset(104)] public float MaxDistance;
        [FieldOffset(108)] public float TotalSamples;
        [FieldOffset(112)] public float Priority;
        [FieldOffset(120)]  public IntPtr  AttenuationSettings;
        [FieldOffset(128)]  public IntPtr  SoundSubmixObject;
        [FieldOffset(136)] public NativeArray SoundSubmixSends;
        [FieldOffset(152)]  public IntPtr  SourceEffectChain;
        [FieldOffset(160)] public NativeArray BusSends;
        [FieldOffset(176)] public NativeArray PreEffectBusSends;
    }
    internal unsafe struct SoundBase_methods {
    }
    internal unsafe struct SoundBase_events {
    }
}
