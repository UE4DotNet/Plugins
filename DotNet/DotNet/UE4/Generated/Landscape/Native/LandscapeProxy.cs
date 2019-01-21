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
    [StructLayout( LayoutKind.Explicit, Size=2056 )]
    internal unsafe struct LandscapeProxy_fields {
        [FieldOffset(1008)]  public IntPtr  SplineComponent;
        [FieldOffset(1016)] public FGuid LandscapeGuid;
        [FieldOffset(1032)] public IntPoint LandscapeSectionOffset;
        [FieldOffset(1040)] public int MaxLODLevel;
        [FieldOffset(1052)] public float ComponentScreenSizeToUseSubSections;
        [FieldOffset(1056)] public float LOD0DistributionSetting;
        [FieldOffset(1060)] public float LODDistributionSetting;
        [FieldOffset(1064)] public float TessellationComponentScreenSize;
        [FieldOffset(1068)] public bool UseTessellationComponentScreenSizeFalloff;
        [FieldOffset(1072)] public float TessellationComponentScreenSizeFalloff;
        [FieldOffset(1076)] public int OccluderGeometryLOD;
        [FieldOffset(1080)] public int ExportLOD;
        [FieldOffset(1088)] public NativeArray TargetDisplayOrderList;
        [FieldOffset(1104)] byte TargetDisplayOrder; //TODO: enum ELandscapeLayerDisplayMode TargetDisplayOrder
        [FieldOffset(1108)] public int StaticLightingLOD;
        [FieldOffset(1112)]  public IntPtr  DefaultPhysMaterial;
        [FieldOffset(1120)] public float StreamingDistanceMultiplier;
        [FieldOffset(1128)]  public IntPtr  LandscapeMaterial;
        [FieldOffset(1136)]  public IntPtr  LandscapeHoleMaterial;
        [FieldOffset(1144)] public NativeArray LandscapeMaterialsOverride;
        [FieldOffset(1160)] public float NegativeZBoundsExtension;
        [FieldOffset(1164)] public float PositiveZBoundsExtension;
        [FieldOffset(1168)] public NativeArray LandscapeComponents;
        [FieldOffset(1184)] public NativeArray CollisionComponents;
        [FieldOffset(1200)] public NativeArray FoliageComponents;
        [FieldOffset(1316)] public bool bHasLandscapeGrass;
        [FieldOffset(1320)] public float StaticLightingResolution;
        [FieldOffset(1324)] public bool bCastStaticShadow;
        [FieldOffset(1324)] public bool bCastShadowAsTwoSided;
        [FieldOffset(1324)] public bool bCastFarShadow;
        [FieldOffset(1328)] public bool bAffectDistanceFieldLighting;
        [FieldOffset(1329)] public LightingChannels LightingChannels;
        [FieldOffset(1332)] public bool bUseMaterialPositionOffsetInStaticLighting;
        [FieldOffset(1332)] public bool bRenderCustomDepth;
        [FieldOffset(1336)] public int CustomDepthStencilValue;
        [FieldOffset(1340)] public float LDMaxDrawDistance;
        [FieldOffset(1344)] public bool bIsMovingToLevel;
        [FieldOffset(1348)] public LightmassPrimitiveSettings LightmassSettings;
        [FieldOffset(1372)] public int CollisionMipLevel;
        [FieldOffset(1376)] public int SimpleCollisionMipLevel;
        [FieldOffset(1380)] public float CollisionThickness;
        [FieldOffset(1384)] public BodyInstance BodyInstance;
        [FieldOffset(1752)] public bool bGenerateOverlapEvents;
        [FieldOffset(1752)] public bool bBakeMaterialPositionOffsetIntoCollision;
        [FieldOffset(1776)] byte ReimportHeightmapFilePath; //TODO: string FString ReimportHeightmapFilePath
        [FieldOffset(1792)] public NativeArray EditorLayerSettings;
        [FieldOffset(1808)] public int ComponentSizeQuads;
        [FieldOffset(1812)] public int SubsectionSizeQuads;
        [FieldOffset(1816)] public int NumSubsections;
        [FieldOffset(1820)] public bool bUsedForNavigation;
        [FieldOffset(1824)] public bool bUseDynamicMaterialInstance;
        [FieldOffset(1825)] byte NavigationGeometryGatheringMode; //TODO: enum ENavDataGatheringMode NavigationGeometryGatheringMode
        [FieldOffset(1828)] public int MaxPaintedLayersPerComponent;
        [FieldOffset(1832)] public bool bUseLandscapeForCullingInvisibleHLODVertices;
    }
    internal unsafe struct LandscapeProxy_methods {
        internal struct ChangeComponentScreenSizeToUseSubSections_method {
            static internal IntPtr ChangeComponentScreenSizeToUseSubSections_ptr;
            static ChangeComponentScreenSizeToUseSubSections_method() {
                ChangeComponentScreenSizeToUseSubSections_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "ChangeComponentScreenSizeToUseSubSections");
            }

            internal static unsafe void Invoke(IntPtr obj, float InComponentScreenSizeToUseSubSections) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InComponentScreenSizeToUseSubSections;
                Main.GetProcessEvent(obj, ChangeComponentScreenSizeToUseSubSections_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ChangeLODDistanceFactor_method {
            static internal IntPtr ChangeLODDistanceFactor_ptr;
            static ChangeLODDistanceFactor_method() {
                ChangeLODDistanceFactor_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "ChangeLODDistanceFactor");
            }

            internal static unsafe void Invoke(IntPtr obj, float InLODDistanceFactor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InLODDistanceFactor;
                Main.GetProcessEvent(obj, ChangeLODDistanceFactor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ChangeTessellationComponentScreenSize_method {
            static internal IntPtr ChangeTessellationComponentScreenSize_ptr;
            static ChangeTessellationComponentScreenSize_method() {
                ChangeTessellationComponentScreenSize_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "ChangeTessellationComponentScreenSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float InTessellationComponentScreenSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InTessellationComponentScreenSize;
                Main.GetProcessEvent(obj, ChangeTessellationComponentScreenSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ChangeTessellationComponentScreenSizeFalloff_method {
            static internal IntPtr ChangeTessellationComponentScreenSizeFalloff_ptr;
            static ChangeTessellationComponentScreenSizeFalloff_method() {
                ChangeTessellationComponentScreenSizeFalloff_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "ChangeTessellationComponentScreenSizeFalloff");
            }

            internal static unsafe void Invoke(IntPtr obj, float InUseTessellationComponentScreenSizeFalloff) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InUseTessellationComponentScreenSizeFalloff;
                Main.GetProcessEvent(obj, ChangeTessellationComponentScreenSizeFalloff_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ChangeUseTessellationComponentScreenSizeFalloff_method {
            static internal IntPtr ChangeUseTessellationComponentScreenSizeFalloff_ptr;
            static ChangeUseTessellationComponentScreenSizeFalloff_method() {
                ChangeUseTessellationComponentScreenSizeFalloff_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "ChangeUseTessellationComponentScreenSizeFalloff");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InComponentScreenSizeToUseSubSections) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InComponentScreenSizeToUseSubSections;
                Main.GetProcessEvent(obj, ChangeUseTessellationComponentScreenSizeFalloff_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EditorApplySpline_method {
            static internal IntPtr EditorApplySpline_ptr;
            static EditorApplySpline_method() {
                EditorApplySpline_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "EditorApplySpline");
            }

            internal static unsafe void Invoke(IntPtr obj, SplineComponent InSplineComponent, float StartWidth, float EndWidth, float StartSideFalloff, float EndSideFalloff, float StartRoll, float EndRoll, int NumSubdivisions, bool bRaiseHeights, bool bLowerHeights, LandscapeLayerInfoObject PaintLayer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InSplineComponent;
                *((float*)(b+8)) = StartWidth;
                *((float*)(b+12)) = EndWidth;
                *((float*)(b+16)) = StartSideFalloff;
                *((float*)(b+20)) = EndSideFalloff;
                *((float*)(b+24)) = StartRoll;
                *((float*)(b+28)) = EndRoll;
                *((int*)(b+32)) = NumSubdivisions;
                *((bool*)(b+36)) = bRaiseHeights;
                *((bool*)(b+37)) = bLowerHeights;
                *((IntPtr*)(b+40)) = PaintLayer;
                Main.GetProcessEvent(obj, EditorApplySpline_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EditorSetLandscapeMaterial_method {
            static internal IntPtr EditorSetLandscapeMaterial_ptr;
            static EditorSetLandscapeMaterial_method() {
                EditorSetLandscapeMaterial_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "EditorSetLandscapeMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface NewLandscapeMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewLandscapeMaterial;
                Main.GetProcessEvent(obj, EditorSetLandscapeMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct LandscapeExportHeightmapToRenderTarget_method {
            static internal IntPtr LandscapeExportHeightmapToRenderTarget_ptr;
            static LandscapeExportHeightmapToRenderTarget_method() {
                LandscapeExportHeightmapToRenderTarget_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "LandscapeExportHeightmapToRenderTarget");
            }

            internal static unsafe bool Invoke(IntPtr obj, TextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InRenderTarget;
                *((bool*)(b+8)) = InExportHeightIntoRGChannel;
                Main.GetProcessEvent(obj, LandscapeExportHeightmapToRenderTarget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+9));
            }
        }
        internal struct LandscapeExportWeightmapToRenderTarget_method {
            static internal IntPtr LandscapeExportWeightmapToRenderTarget_ptr;
            static LandscapeExportWeightmapToRenderTarget_method() {
                LandscapeExportWeightmapToRenderTarget_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "LandscapeExportWeightmapToRenderTarget");
            }

            internal static unsafe bool Invoke(IntPtr obj, TextureRenderTarget2D InRenderTarget, Name InLayerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InRenderTarget;
                *((Name*)(b+8)) = InLayerName;
                Main.GetProcessEvent(obj, LandscapeExportWeightmapToRenderTarget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct LandscapeImportHeightmapFromRenderTarget_method {
            static internal IntPtr LandscapeImportHeightmapFromRenderTarget_ptr;
            static LandscapeImportHeightmapFromRenderTarget_method() {
                LandscapeImportHeightmapFromRenderTarget_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "LandscapeImportHeightmapFromRenderTarget");
            }

            internal static unsafe bool Invoke(IntPtr obj, TextureRenderTarget2D InRenderTarget, bool InImportHeightFromRGChannel) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InRenderTarget;
                *((bool*)(b+8)) = InImportHeightFromRGChannel;
                Main.GetProcessEvent(obj, LandscapeImportHeightmapFromRenderTarget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+9));
            }
        }
        internal struct LandscapeImportWeightmapFromRenderTarget_method {
            static internal IntPtr LandscapeImportWeightmapFromRenderTarget_ptr;
            static LandscapeImportWeightmapFromRenderTarget_method() {
                LandscapeImportWeightmapFromRenderTarget_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "LandscapeImportWeightmapFromRenderTarget");
            }

            internal static unsafe bool Invoke(IntPtr obj, TextureRenderTarget2D InRenderTarget, Name InLayerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InRenderTarget;
                *((Name*)(b+8)) = InLayerName;
                Main.GetProcessEvent(obj, LandscapeImportWeightmapFromRenderTarget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct SetLandscapeMaterialScalarParameterValue_method {
            static internal IntPtr SetLandscapeMaterialScalarParameterValue_ptr;
            static SetLandscapeMaterialScalarParameterValue_method() {
                SetLandscapeMaterialScalarParameterValue_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "SetLandscapeMaterialScalarParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((float*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetLandscapeMaterialScalarParameterValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLandscapeMaterialTextureParameterValue_method {
            static internal IntPtr SetLandscapeMaterialTextureParameterValue_ptr;
            static SetLandscapeMaterialTextureParameterValue_method() {
                SetLandscapeMaterialTextureParameterValue_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "SetLandscapeMaterialTextureParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Texture Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Value;
                Main.GetProcessEvent(obj, SetLandscapeMaterialTextureParameterValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLandscapeMaterialVectorParameterValue_method {
            static internal IntPtr SetLandscapeMaterialVectorParameterValue_ptr;
            static SetLandscapeMaterialVectorParameterValue_method() {
                SetLandscapeMaterialVectorParameterValue_ptr = Main.GetMethodUFunction(LandscapeProxy.StaticClass, "SetLandscapeMaterialVectorParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((LinearColor*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetLandscapeMaterialVectorParameterValue_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LandscapeProxy_events {
    }
}
