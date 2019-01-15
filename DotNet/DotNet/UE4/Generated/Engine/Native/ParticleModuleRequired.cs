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
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct ParticleModuleRequired_fields {
        [FieldOffset(72)]  public IntPtr  Material;
        [FieldOffset(80)] public Vector EmitterOrigin;
        [FieldOffset(92)] public Rotator EmitterRotation;
        [FieldOffset(104)] public byte ScreenAlignment;
        [FieldOffset(108)] public float MinFacingCameraBlendDistance;
        [FieldOffset(112)] public float MaxFacingCameraBlendDistance;
        [FieldOffset(116)] public bool bUseLocalSpace;
        [FieldOffset(116)] public bool bKillOnDeactivate;
        [FieldOffset(116)] public bool bKillOnCompleted;
        [FieldOffset(120)] public byte SortMode;
        [FieldOffset(124)] public bool bUseLegacyEmitterTime;
        [FieldOffset(124)] public bool bRemoveHMDRoll;
        [FieldOffset(128)] public float EmitterDuration;
        [FieldOffset(132)] public float EmitterDurationLow;
        [FieldOffset(136)] public bool bEmitterDurationUseRange;
        [FieldOffset(136)] public bool bDurationRecalcEachLoop;
        [FieldOffset(140)] public int EmitterLoops;
        [FieldOffset(144)] public RawDistributionFloat SpawnRate;
        [FieldOffset(200)] public byte ParticleBurstMethod;
        [FieldOffset(208)] public NativeArray BurstList;
        [FieldOffset(224)] public float EmitterDelay;
        [FieldOffset(228)] public float EmitterDelayLow;
        [FieldOffset(232)] public bool bEmitterDelayUseRange;
        [FieldOffset(232)] public bool bDelayFirstLoopOnly;
        [FieldOffset(236)] public byte InterpolationMethod;
        [FieldOffset(240)] public int SubImages_Horizontal;
        [FieldOffset(244)] public int SubImages_Vertical;
        [FieldOffset(248)] public bool bScaleUV;
        [FieldOffset(252)] public float RandomImageTime;
        [FieldOffset(256)] public int RandomImageChanges;
        [FieldOffset(260)] public bool bOverrideSystemMacroUV;
        [FieldOffset(264)] public Vector MacroUVPosition;
        [FieldOffset(276)] public float MacroUVRadius;
        [FieldOffset(280)] public bool bUseMaxDrawCount;
        [FieldOffset(284)] public int MaxDrawCount;
        [FieldOffset(288)] byte UVFlippingMode; //TODO: enum EParticleUVFlipMode UVFlippingMode
        [FieldOffset(296)]  public IntPtr  CutoutTexture;
        [FieldOffset(304)] public byte BoundingMode;
        [FieldOffset(305)] public byte OpacitySourceMode;
        [FieldOffset(308)] public float AlphaThreshold;
        [FieldOffset(312)] public byte EmitterNormalsMode;
        [FieldOffset(316)] public Vector NormalsSphereCenter;
        [FieldOffset(328)] public Vector NormalsCylinderDirection;
        [FieldOffset(340)] public bool bOrbitModuleAffectsVelocityAlignment;
        [FieldOffset(344)] public NativeArray NamedMaterialOverrides;
    }
    internal unsafe struct ParticleModuleRequired_methods {
    }
    internal unsafe struct ParticleModuleRequired_events {
    }
}
