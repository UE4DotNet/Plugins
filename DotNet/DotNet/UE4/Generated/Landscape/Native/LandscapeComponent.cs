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
    [StructLayout( LayoutKind.Explicit, Size=2208 )]
    internal unsafe struct LandscapeComponent_fields {
        [FieldOffset(1504)] public int SectionBaseX;
        [FieldOffset(1508)] public int SectionBaseY;
        [FieldOffset(1512)] public int ComponentSizeQuads;
        [FieldOffset(1516)] public int SubsectionSizeQuads;
        [FieldOffset(1520)] public int NumSubsections;
        [FieldOffset(1528)]  public IntPtr  OverrideMaterial;
        [FieldOffset(1536)]  public IntPtr  OverrideHoleMaterial;
        [FieldOffset(1544)] public NativeArray OverrideMaterials;
        [FieldOffset(1568)] public NativeArray MaterialInstances;
        [FieldOffset(1584)] public NativeArray MaterialInstancesDynamic;
        [FieldOffset(1600)] public NativeArray LODIndexToMaterialIndex;
        [FieldOffset(1616)] public NativeArray MaterialIndexToDisabledTessellationMaterial;
        [FieldOffset(1632)] public NativeArray WeightmapLayerAllocations;
        [FieldOffset(1648)] public NativeArray WeightmapTextures;
        [FieldOffset(1664)]  public IntPtr  XYOffsetmapTexture;
        [FieldOffset(1680)] public Vector4 WeightmapScaleBias;
        [FieldOffset(1696)] public float WeightmapSubsectionOffset;
        [FieldOffset(1712)] public Vector4 HeightmapScaleBias;
        [FieldOffset(1728)]  public IntPtr  HeightmapTexture;
        [FieldOffset(1736)] public Box CachedLocalBox;
        [FieldOffset(1764)] byte CollisionComponent; //TODO: lazy_object TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent
        [FieldOffset(1792)] public FGuid LightingGuid;
        [FieldOffset(1808)] public FGuid MapBuildDataId;
        [FieldOffset(1840)] public int CollisionMipLevel;
        [FieldOffset(1844)] public int SimpleCollisionMipLevel;
        [FieldOffset(1848)] public float NegativeZBoundsExtension;
        [FieldOffset(1852)] public float PositiveZBoundsExtension;
        [FieldOffset(1856)] public float StaticLightingResolution;
        [FieldOffset(1860)] public int ForcedLOD;
        [FieldOffset(1864)] public int LODBias;
        [FieldOffset(1868)] public FGuid StateId;
        [FieldOffset(1884)] public FGuid BakedTextureMaterialGuid;
        [FieldOffset(1904)]  public IntPtr  GIBakedBaseColorTexture;
        [FieldOffset(1912)] public int LightingLODBias;
        [FieldOffset(1920)] public NativeArray LayerWhitelist;
        [FieldOffset(1936)] public LandscapeEditToolRenderData EditToolRenderData;
        [FieldOffset(1976)] public FGuid MobileDataSourceHash;
        [FieldOffset(1992)] byte MaterialPerLOD; //TODO: map TMap MaterialPerLOD
        [FieldOffset(2072)] public byte MobileBlendableLayerMask;
        [FieldOffset(2088)] public NativeArray MobileMaterialInterfaces;
        [FieldOffset(2104)] public NativeArray MobileWeightmapTextures;
        [FieldOffset(2136)] public NativeArray MobileCombinationMaterialInstances;
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
