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
    [StructLayout( LayoutKind.Explicit, Size=712 )]
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
        [FieldOffset(152)] public Name CollisionProfileName;
        [FieldOffset(164)] public bool bCastShadow;
        [FieldOffset(168)] public float LDMaxDrawDistance;
        [FieldOffset(172)] public int TranslucencySortPriority;
        [FieldOffset(176)] public bool bPlaceSplineMeshesInStreamingLevels;
        [FieldOffset(184)] public BodyInstance BodyInstance;
        [FieldOffset(568)] public bool bSelected;
        [FieldOffset(568)] public bool bNavDirty;
        [FieldOffset(576)] public NativeArray ConnectedSegments;
        [FieldOffset(592)] public NativeArray Points;
        [FieldOffset(608)] public Box Bounds;
        [FieldOffset(640)]  public IntPtr  LocalMeshComponent;
        [FieldOffset(648)] byte ForeignWorld; //TODO: soft object TSoftObjectPtr<UWorld> ForeignWorld
        [FieldOffset(696)] public FGuid ModificationKey;
    }
    internal unsafe struct LandscapeSplineControlPoint_methods {
    }
    internal unsafe struct LandscapeSplineControlPoint_events {
    }
}
