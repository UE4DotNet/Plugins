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


namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=1360 )]
    internal unsafe struct LandscapeGizmoActiveActor_fields {
        [FieldOffset(1048)] public byte DataType;
        [FieldOffset(1056)]  public IntPtr  GizmoTexture;
        [FieldOffset(1064)] public Vector2D TextureScale;
        [FieldOffset(1072)] public NativeArray SampledHeight;
        [FieldOffset(1088)] public NativeArray SampledNormal;
        [FieldOffset(1104)] public int SampleSizeX;
        [FieldOffset(1108)] public int SampleSizeY;
        [FieldOffset(1112)] public float CachedWidth;
        [FieldOffset(1116)] public float CachedHeight;
        [FieldOffset(1120)] public float CachedScaleXY;
        [FieldOffset(1124)] public Vector FrustumVerts;
        [FieldOffset(1224)]  public IntPtr  GizmoMaterial;
        [FieldOffset(1232)]  public IntPtr  GizmoDataMaterial;
        [FieldOffset(1240)]  public IntPtr  GizmoMeshMaterial;
        [FieldOffset(1248)] public NativeArray LayerInfos;
        [FieldOffset(1264)] public bool bSnapToLandscapeGrid;
        [FieldOffset(1268)] public Rotator UnsnappedRotation;
    }
    internal unsafe struct LandscapeGizmoActiveActor_methods {
    }
    internal unsafe struct LandscapeGizmoActiveActor_events {
    }
}
