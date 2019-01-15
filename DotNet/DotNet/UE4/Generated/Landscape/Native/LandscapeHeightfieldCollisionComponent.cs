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
    [StructLayout( LayoutKind.Explicit, Size=2032 )]
    internal unsafe struct LandscapeHeightfieldCollisionComponent_fields {
        [FieldOffset(1520)] public NativeArray ComponentLayerInfos;
        [FieldOffset(1536)] public int SectionBaseX;
        [FieldOffset(1540)] public int SectionBaseY;
        [FieldOffset(1544)] public int CollisionSizeQuads;
        [FieldOffset(1548)] public float CollisionScale;
        [FieldOffset(1552)] public int SimpleCollisionSizeQuads;
        [FieldOffset(1560)] public NativeArray CollisionQuadFlags;
        [FieldOffset(1576)] public FGuid HeightfieldGuid;
        [FieldOffset(1592)] public Box CachedLocalBox;
        [FieldOffset(1620)] byte RenderComponent; //TODO: lazy_object TLazyObjectPtr<ULandscapeComponent> RenderComponent
        [FieldOffset(1944)] public NativeArray CookedPhysicalMaterials;
    }
    internal unsafe struct LandscapeHeightfieldCollisionComponent_methods {
    }
    internal unsafe struct LandscapeHeightfieldCollisionComponent_events {
    }
}
