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
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct ParticleEmitter_fields {
        [FieldOffset(56)] public Name EmitterName;
        [FieldOffset(68)] public int SubUVDataOffset;
        [FieldOffset(72)] public byte EmitterRenderMode;
        [FieldOffset(73)] byte SignificanceLevel; //TODO: enum EParticleSignificanceLevel SignificanceLevel
        [FieldOffset(75)] public bool bUseLegacySpawningBehavior;
        [FieldOffset(75)] public bool ConvertedModules;
        [FieldOffset(75)] public bool bIsSoloing;
        [FieldOffset(75)] public bool bCookedOut;
        [FieldOffset(75)] public bool bDisabledLODsKeepEmitterAlive;
        [FieldOffset(76)] public bool bDisableWhenInsignficant;
        [FieldOffset(76)] public bool bCollapsed;
        [FieldOffset(80)] public Color EmitterEditorColor;
        [FieldOffset(88)] public NativeArray LODLevels;
        [FieldOffset(104)] public int PeakActiveParticles;
        [FieldOffset(108)] public int InitialAllocationCount;
        [FieldOffset(112)] public float QualityLevelSpawnRateScale;
        [FieldOffset(116)] byte DetailModeBitmask; //TODO: numeric uint32 DetailModeBitmask
        [FieldOffset(120)] byte DetailModeDisplay; //TODO: string FString DetailModeDisplay
    }
    internal unsafe struct ParticleEmitter_methods {
    }
    internal unsafe struct ParticleEmitter_events {
    }
}
