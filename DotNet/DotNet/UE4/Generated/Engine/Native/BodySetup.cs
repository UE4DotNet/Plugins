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
    [StructLayout( LayoutKind.Explicit, Size=728 )]
    internal unsafe struct BodySetup_fields {
        [FieldOffset(56)] public KAggregateGeom AggGeom;
        [FieldOffset(144)] public Name BoneName;
        [FieldOffset(156)] public byte PhysicsType;
        [FieldOffset(157)] public bool bConsiderForBounds;
        [FieldOffset(157)] public bool bMeshCollideAll;
        [FieldOffset(157)] public bool bDoubleSidedGeometry;
        [FieldOffset(157)] public bool bGenerateNonMirroredCollision;
        [FieldOffset(157)] public bool bSharedCookedData;
        [FieldOffset(157)] public bool bGenerateMirroredCollision;
        [FieldOffset(159)] public byte CollisionReponse;
        [FieldOffset(160)] public byte CollisionTraceFlag;
        [FieldOffset(168)]  public IntPtr  PhysMaterial;
        [FieldOffset(176)] public WalkableSlopeOverride WalkableSlopeOverride;
        [FieldOffset(328)] public BodyInstance DefaultInstance;
        [FieldOffset(704)] public Vector BuildScale3D;
    }
    internal unsafe struct BodySetup_methods {
    }
    internal unsafe struct BodySetup_events {
    }
}
