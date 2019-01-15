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

using UE4.Engine;

namespace UE4.Foliage.Native {
    [StructLayout( LayoutKind.Explicit, Size=1008 )]
    internal unsafe struct FoliageType_fields {
        [FieldOffset(56)] public FGuid UpdateGuid;
        [FieldOffset(72)] public float Density;
        [FieldOffset(76)] public float DensityAdjustmentFactor;
        [FieldOffset(80)] public float Radius;
        [FieldOffset(84)] byte Scaling; //TODO: enum EFoliageScaling Scaling
        [FieldOffset(88)] public FloatInterval ScaleX;
        [FieldOffset(96)] public FloatInterval ScaleY;
        [FieldOffset(104)] public FloatInterval ScaleZ;
        [FieldOffset(112)] public FoliageVertexColorChannelMask VertexColorMaskByChannel;
        [FieldOffset(172)] public FloatInterval ZOffset;
        [FieldOffset(180)] public bool AlignToNormal;
        [FieldOffset(184)] public float AlignMaxAngle;
        [FieldOffset(188)] public bool RandomYaw;
        [FieldOffset(192)] public float RandomPitchAngle;
        [FieldOffset(196)] public FloatInterval GroundSlopeAngle;
        [FieldOffset(204)] public FloatInterval Height;
        [FieldOffset(216)] public NativeArray LandscapeLayers;
        [FieldOffset(244)] public bool CollisionWithWorld;
        [FieldOffset(248)] public Vector CollisionScale;
        [FieldOffset(260)] public float MinimumLayerWeight;
        [FieldOffset(264)] public BoxSphereBounds MeshBounds;
        [FieldOffset(292)] public Vector LowBoundOriginRadius;
        [FieldOffset(304)] public byte Mobility;
        [FieldOffset(308)] public Int32Interval CullDistance;
        [FieldOffset(316)] public bool CastShadow;
        [FieldOffset(316)] public bool bAffectDynamicIndirectLighting;
        [FieldOffset(316)] public bool bAffectDistanceFieldLighting;
        [FieldOffset(316)] public bool bCastDynamicShadow;
        [FieldOffset(316)] public bool bCastStaticShadow;
        [FieldOffset(316)] public bool bCastShadowAsTwoSided;
        [FieldOffset(316)] public bool bReceivesDecals;
        [FieldOffset(317)] public bool bOverrideLightMapRes;
        [FieldOffset(320)] public int OverriddenLightMapRes;
        [FieldOffset(324)] byte LightmapType; //TODO: enum ELightmapType LightmapType
        [FieldOffset(328)] public bool bUseAsOccluder;
        [FieldOffset(336)] public BodyInstance BodyInstance;
        [FieldOffset(720)] public byte CustomNavigableGeometry;
        [FieldOffset(721)] public LightingChannels LightingChannels;
        [FieldOffset(724)] public bool bRenderCustomDepth;
        [FieldOffset(728)] public int CustomDepthStencilValue;
        [FieldOffset(736)] byte HiddenEditorViews; //TODO: numeric uint64 HiddenEditorViews
        [FieldOffset(744)] public bool IsSelected;
        [FieldOffset(748)] public float CollisionRadius;
        [FieldOffset(752)] public float ShadeRadius;
        [FieldOffset(756)] public int NumSteps;
        [FieldOffset(760)] public float InitialSeedDensity;
        [FieldOffset(764)] public float AverageSpreadDistance;
        [FieldOffset(768)] public float SpreadVariance;
        [FieldOffset(772)] public int SeedsPerStep;
        [FieldOffset(776)] public int DistributionSeed;
        [FieldOffset(780)] public float MaxInitialSeedOffset;
        [FieldOffset(784)] public bool bCanGrowInShade;
        [FieldOffset(785)] public bool bSpawnsInShade;
        [FieldOffset(788)] public float MaxInitialAge;
        [FieldOffset(792)] public float MaxAge;
        [FieldOffset(796)] public float OverlapPriority;
        [FieldOffset(800)] public FloatInterval ProceduralScale;
        [FieldOffset(808)] public RuntimeFloatCurve ScaleCurve;
        [FieldOffset(928)] public int ChangeCount;
        [FieldOffset(932)] public bool ReapplyDensity;
        [FieldOffset(932)] public bool ReapplyRadius;
        [FieldOffset(932)] public bool ReapplyAlignToNormal;
        [FieldOffset(932)] public bool ReapplyRandomYaw;
        [FieldOffset(932)] public bool ReapplyScaling;
        [FieldOffset(932)] public bool ReapplyScaleX;
        [FieldOffset(932)] public bool ReapplyScaleY;
        [FieldOffset(932)] public bool ReapplyScaleZ;
        [FieldOffset(933)] public bool ReapplyRandomPitchAngle;
        [FieldOffset(933)] public bool ReapplyGroundSlope;
        [FieldOffset(933)] public bool ReapplyHeight;
        [FieldOffset(933)] public bool ReapplyLandscapeLayers;
        [FieldOffset(933)] public bool ReapplyZOffset;
        [FieldOffset(933)] public bool ReapplyCollisionWithWorld;
        [FieldOffset(933)] public bool ReapplyVertexColorMask;
        [FieldOffset(933)] public bool bEnableDensityScaling;
    }
    internal unsafe struct FoliageType_methods {
    }
    internal unsafe struct FoliageType_events {
    }
}
