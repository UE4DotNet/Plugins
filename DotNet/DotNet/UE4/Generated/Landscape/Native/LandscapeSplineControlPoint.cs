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

namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=696 )]
    internal unsafe struct LandscapeSplineControlPoint_fields {
        [FieldOffset(56)] public Vector Location;
        [FieldOffset(68)] public Rotator Rotation;
        [FieldOffset(80)] public float Width;
        [FieldOffset(84)] public float SideFalloff;
        [FieldOffset(88)] public float EndFalloff;
        [FieldOffset(92)] public float SegmentMeshOffset;
        [FieldOffset(96)] public Name LayerName;
        [FieldOffset(108)] public bool bRaiseTerrain;
        [FieldOffset(108)] public bool bLowerTerrain;
        [FieldOffset(112)]  public IntPtr  Mesh;
        [FieldOffset(120)] public NativeArray MaterialOverrides;
        [FieldOffset(136)] public Vector MeshScale;
        [FieldOffset(148)] public bool bHiddenInGame;
        [FieldOffset(156)] public Name CollisionProfileName;
        [FieldOffset(168)] public bool bCastShadow;
        [FieldOffset(172)] public float LDMaxDrawDistance;
        [FieldOffset(176)] public int TranslucencySortPriority;
        [FieldOffset(180)] public bool bPlaceSplineMeshesInStreamingLevels;
        [FieldOffset(184)] public BodyInstance BodyInstance;
        [FieldOffset(552)] public bool bSelected;
        [FieldOffset(552)] public bool bNavDirty;
        [FieldOffset(560)] public NativeArray ConnectedSegments;
        [FieldOffset(576)] public NativeArray Points;
        [FieldOffset(592)] public Box Bounds;
        [FieldOffset(624)]  public IntPtr  LocalMeshComponent;
        [FieldOffset(632)] byte ForeignWorld; //TODO: soft object TSoftObjectPtr<UWorld> ForeignWorld
        [FieldOffset(680)] public FGuid ModificationKey;
    }
    internal unsafe struct LandscapeSplineControlPoint_methods {
    }
    internal unsafe struct LandscapeSplineControlPoint_events {
    }
}
