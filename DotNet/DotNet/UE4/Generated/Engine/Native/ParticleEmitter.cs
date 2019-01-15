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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct ParticleEmitter_fields {
        [FieldOffset(56)] public Name EmitterName;
        [FieldOffset(68)] public int SubUVDataOffset;
        [FieldOffset(72)] public byte EmitterRenderMode;
        [FieldOffset(76)] public Color EmitterEditorColor;
        [FieldOffset(80)] public NativeArray LODLevels;
        [FieldOffset(96)] public bool ConvertedModules;
        [FieldOffset(100)] public int PeakActiveParticles;
        [FieldOffset(104)] public int InitialAllocationCount;
        [FieldOffset(112)] public float QualityLevelSpawnRateScale;
        [FieldOffset(120)] byte DetailModeBitmask; //TODO: numeric uint32 DetailModeBitmask
        [FieldOffset(128)] byte DetailModeDisplay; //TODO: string FString DetailModeDisplay
        [FieldOffset(144)] public bool bCollapsed;
        [FieldOffset(144)] public bool bIsSoloing;
        [FieldOffset(144)] public bool bCookedOut;
        [FieldOffset(144)] public bool bDisabledLODsKeepEmitterAlive;
        [FieldOffset(144)] public bool bDisableWhenInsignficant;
        [FieldOffset(148)] byte SignificanceLevel; //TODO: enum EParticleSignificanceLevel SignificanceLevel
        [FieldOffset(152)] public bool bUseLegacySpawningBehavior;
    }
    internal unsafe struct ParticleEmitter_methods {
    }
    internal unsafe struct ParticleEmitter_events {
    }
}
