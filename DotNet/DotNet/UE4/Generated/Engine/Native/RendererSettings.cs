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
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct RendererSettings_fields {
        [FieldOffset(80)] public bool bMobileHDR;
        [FieldOffset(80)] public bool bMobileDisableVertexFog;
        [FieldOffset(84)] public int MaxMobileCascades;
        [FieldOffset(88)] public byte MobileMSAASampleCount;
        [FieldOffset(92)] public bool bMobileUseLegacyShadingModel;
        [FieldOffset(92)] public bool bDiscardUnusedQualityLevels;
        [FieldOffset(92)] public bool bOcclusionCulling;
        [FieldOffset(96)] public float MinScreenRadiusForLights;
        [FieldOffset(100)] public float MinScreenRadiusForEarlyZPass;
        [FieldOffset(104)] public float MinScreenRadiusForCSMdepth;
        [FieldOffset(108)] public bool bPrecomputedVisibilityWarning;
        [FieldOffset(108)] public bool bTextureStreaming;
        [FieldOffset(108)] public bool bUseDXT5NormalMaps;
        [FieldOffset(108)] public bool bClearCoatEnableSecondNormal;
        [FieldOffset(112)] public int ReflectionCaptureResolution;
        [FieldOffset(116)] public bool ReflectionEnvironmentLightmapMixBasedOnRoughness;
        [FieldOffset(116)] public bool bForwardShading;
        [FieldOffset(116)] public bool bVertexFoggingForOpaque;
        [FieldOffset(116)] public bool bAllowStaticLighting;
        [FieldOffset(116)] public bool bUseNormalMapsForStaticLighting;
        [FieldOffset(116)] public bool bGenerateMeshDistanceFields;
        [FieldOffset(116)] public bool bEightBitMeshDistanceFields;
        [FieldOffset(116)] public bool bGenerateLandscapeGIData;
        [FieldOffset(117)] public bool bCompressMeshDistanceFields;
        [FieldOffset(120)] public float TessellationAdaptivePixelsPerTriangle;
        [FieldOffset(124)] public bool bSeparateTranslucency;
        [FieldOffset(128)] public byte TranslucentSortPolicy;
        [FieldOffset(132)] public Vector TranslucentSortAxis;
        [FieldOffset(144)] public byte CustomDepthStencil;
        [FieldOffset(148)] public bool bCustomDepthTaaJitter;
        [FieldOffset(152)] public byte bEnableAlphaChannelInPostProcessing;
        [FieldOffset(156)] public bool bUseNewAlgorithm;
        [FieldOffset(156)] public bool bUsePreExposure;
        [FieldOffset(156)] public bool bDefaultFeatureBloom;
        [FieldOffset(156)] public bool bDefaultFeatureAmbientOcclusion;
        [FieldOffset(156)] public bool bDefaultFeatureAmbientOcclusionStaticFraction;
        [FieldOffset(156)] public bool bDefaultFeatureAutoExposure;
        [FieldOffset(160)] public byte DefaultFeatureAutoExposure;
        [FieldOffset(164)] public bool bDefaultFeatureMotionBlur;
        [FieldOffset(164)] public bool bDefaultFeatureLensFlare;
        [FieldOffset(164)] public bool bTemporalUpsampling;
        [FieldOffset(168)] public byte DefaultFeatureAntiAliasing;
        [FieldOffset(169)] byte DefaultPointLightUnits; //TODO: enum ELightUnits DefaultPointLightUnits
        [FieldOffset(170)] byte DefaultSpotLightUnits; //TODO: enum ELightUnits DefaultSpotLightUnits
        [FieldOffset(171)] public byte DefaultBackBufferPixelFormat;
        [FieldOffset(172)] public bool bRenderUnbuiltPreviewShadowsInGame;
        [FieldOffset(172)] public bool bStencilForLODDither;
        [FieldOffset(176)] public byte EarlyZPass;
        [FieldOffset(180)] public bool bEarlyZPassMovable;
        [FieldOffset(180)] public bool bEarlyZPassOnlyMaterialMasking;
        [FieldOffset(180)] public bool bDBuffer;
        [FieldOffset(184)] public byte ClearSceneMethod;
        [FieldOffset(188)] public bool bBasePassOutputsVelocity;
        [FieldOffset(188)] public bool bSelectiveBasePassOutputs;
        [FieldOffset(188)] public bool bDefaultParticleCutouts;
        [FieldOffset(192)] public int GPUSimulationTextureSizeX;
        [FieldOffset(196)] public int GPUSimulationTextureSizeY;
        [FieldOffset(200)] public bool bGlobalClipPlane;
        [FieldOffset(204)] public byte GBufferFormat;
        [FieldOffset(208)] public bool bUseGPUMorphTargets;
        [FieldOffset(208)] public bool bNvidiaAftermathEnabled;
        [FieldOffset(208)] public bool bInstancedStereo;
        [FieldOffset(208)] public bool bMultiView;
        [FieldOffset(208)] public bool bMobileMultiView;
        [FieldOffset(208)] public bool bMobileMultiViewDirect;
        [FieldOffset(208)] public bool bMonoscopicFarField;
        [FieldOffset(208)] public bool bODSCapture;
        [FieldOffset(209)] public bool bDebugCanvasInLayer;
        [FieldOffset(212)] public float WireframeCullThreshold;
        [FieldOffset(216)] public bool bSupportStationarySkylight;
        [FieldOffset(216)] public bool bSupportLowQualityLightmaps;
        [FieldOffset(216)] public bool bSupportPointLightWholeSceneShadows;
        [FieldOffset(216)] public bool bSupportAtmosphericFog;
        [FieldOffset(216)] public bool bSupportSkinCacheShaders;
        [FieldOffset(216)] public bool bMobileEnableStaticAndCSMShadowReceivers;
        [FieldOffset(216)] public bool bMobileEnableMovableLightCSMShaderCulling;
        [FieldOffset(216)] public bool bMobileAllowDistanceFieldShadows;
        [FieldOffset(217)] public bool bMobileAllowMovableDirectionalLights;
        [FieldOffset(220)] byte MobileNumDynamicPointLights; //TODO: numeric uint32 MobileNumDynamicPointLights
        [FieldOffset(224)] public bool bMobileDynamicPointLightsUseStaticBranch;
        [FieldOffset(228)] public float SkinCacheSceneMemoryLimitInMB;
        [FieldOffset(232)] public bool bGPUSkinLimit2BoneInfluences;
        [FieldOffset(232)] public bool bSupportDepthOnlyIndexBuffers;
        [FieldOffset(232)] public bool bSupportReversedIndexBuffers;
        [FieldOffset(232)] public bool bSupportMaterialLayers;
    }
    internal unsafe struct RendererSettings_methods {
    }
    internal unsafe struct RendererSettings_events {
    }
}
