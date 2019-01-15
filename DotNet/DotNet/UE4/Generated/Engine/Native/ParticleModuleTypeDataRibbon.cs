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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct ParticleModuleTypeDataRibbon_fields {
        [FieldOffset(72)] public int MaxTessellationBetweenParticles;
        [FieldOffset(76)] public int SheetsPerTrail;
        [FieldOffset(80)] public int MaxTrailCount;
        [FieldOffset(84)] public int MaxParticleInTrailCount;
        [FieldOffset(88)] public bool bDeadTrailsOnDeactivate;
        [FieldOffset(88)] public bool bDeadTrailsOnSourceLoss;
        [FieldOffset(88)] public bool bClipSourceSegement;
        [FieldOffset(88)] public bool bEnablePreviousTangentRecalculation;
        [FieldOffset(88)] public bool bTangentRecalculationEveryFrame;
        [FieldOffset(88)] public bool bSpawnInitialParticle;
        [FieldOffset(92)] public byte RenderAxis;
        [FieldOffset(96)] public float TangentSpawningScalar;
        [FieldOffset(100)] public bool bRenderGeometry;
        [FieldOffset(100)] public bool bRenderSpawnPoints;
        [FieldOffset(100)] public bool bRenderTangents;
        [FieldOffset(100)] public bool bRenderTessellation;
        [FieldOffset(104)] public float TilingDistance;
        [FieldOffset(108)] public float DistanceTessellationStepSize;
        [FieldOffset(112)] public bool bEnableTangentDiffInterpScale;
        [FieldOffset(116)] public float TangentTessellationScalar;
    }
    internal unsafe struct ParticleModuleTypeDataRibbon_methods {
    }
    internal unsafe struct ParticleModuleTypeDataRibbon_events {
    }
}
