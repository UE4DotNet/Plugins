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
    [StructLayout( LayoutKind.Explicit, Size=2064 )]
    internal unsafe struct LandscapeComponent_fields {
        [FieldOffset(1520)] public int SectionBaseX;
        [FieldOffset(1524)] public int SectionBaseY;
        [FieldOffset(1528)] public int ComponentSizeQuads;
        [FieldOffset(1532)] public int SubsectionSizeQuads;
        [FieldOffset(1536)] public int NumSubsections;
        [FieldOffset(1544)]  public IntPtr  OverrideMaterial;
        [FieldOffset(1552)]  public IntPtr  OverrideHoleMaterial;
        [FieldOffset(1568)] public NativeArray MaterialInstances;
        [FieldOffset(1584)] public NativeArray MaterialInstancesDynamic;
        [FieldOffset(1600)] public NativeArray WeightmapLayerAllocations;
        [FieldOffset(1616)] public NativeArray WeightmapTextures;
        [FieldOffset(1632)]  public IntPtr  XYOffsetmapTexture;
        [FieldOffset(1648)] public Vector4 WeightmapScaleBias;
        [FieldOffset(1664)] public float WeightmapSubsectionOffset;
        [FieldOffset(1680)] public Vector4 HeightmapScaleBias;
        [FieldOffset(1696)]  public IntPtr  HeightmapTexture;
        [FieldOffset(1704)] public Box CachedLocalBox;
        [FieldOffset(1732)] byte CollisionComponent; //TODO: lazy_object TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent
        [FieldOffset(1760)] public FGuid LightingGuid;
        [FieldOffset(1776)] public FGuid MapBuildDataId;
        [FieldOffset(1808)] public int CollisionMipLevel;
        [FieldOffset(1812)] public int SimpleCollisionMipLevel;
        [FieldOffset(1816)] public float NegativeZBoundsExtension;
        [FieldOffset(1820)] public float PositiveZBoundsExtension;
        [FieldOffset(1824)] public float StaticLightingResolution;
        [FieldOffset(1828)] public int ForcedLOD;
        [FieldOffset(1832)] public int LODBias;
        [FieldOffset(1836)] public FGuid StateId;
        [FieldOffset(1852)] public FGuid BakedTextureMaterialGuid;
        [FieldOffset(1872)]  public IntPtr  GIBakedBaseColorTexture;
        [FieldOffset(1880)] public int LightingLODBias;
        [FieldOffset(1888)] public NativeArray LayerWhitelist;
        [FieldOffset(1904)] public LandscapeEditToolRenderData EditToolRenderData;
        [FieldOffset(1944)] public FGuid MobileDataSourceHash;
        [FieldOffset(1960)] public byte MobileBlendableLayerMask;
        [FieldOffset(1968)]  public IntPtr  MobileMaterialInterface;
        [FieldOffset(1976)] public NativeArray MobileWeightmapTextures;
        [FieldOffset(2008)]  public IntPtr  MobileCombinationMaterialInstance;
    }
    internal unsafe struct LandscapeComponent_methods {
        internal struct GetMaterialInstanceDynamic_method {
            static internal IntPtr GetMaterialInstanceDynamic_ptr;
            static GetMaterialInstanceDynamic_method() {
                GetMaterialInstanceDynamic_ptr = Main.GetMethodUFunction(LandscapeComponent.StaticClass, "GetMaterialInstanceDynamic");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, int InIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InIndex;
                Main.GetProcessEvent(obj, GetMaterialInstanceDynamic_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct LandscapeComponent_events {
    }
}
