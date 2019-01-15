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
    [StructLayout( LayoutKind.Explicit, Size=2784 )]
    internal unsafe struct Material_fields {
        [FieldOffset(304)]  public IntPtr  PhysMaterial;
        [FieldOffset(440)] public ColorMaterialInput BaseColor;
        [FieldOffset(504)] public ScalarMaterialInput Metallic;
        [FieldOffset(568)] public ScalarMaterialInput Specular;
        [FieldOffset(632)] public ScalarMaterialInput Roughness;
        [FieldOffset(696)] public VectorMaterialInput Normal;
        [FieldOffset(768)] public ColorMaterialInput EmissiveColor;
        [FieldOffset(832)] public ScalarMaterialInput Opacity;
        [FieldOffset(896)] public ScalarMaterialInput OpacityMask;
        [FieldOffset(960)] public byte MaterialDomain;
        [FieldOffset(961)] public byte BlendMode;
        [FieldOffset(962)] public byte DecalBlendMode;
        [FieldOffset(963)] public byte MaterialDecalResponse;
        [FieldOffset(964)] public byte ShadingModel;
        [FieldOffset(968)] public float OpacityMaskClipValue;
        [FieldOffset(972)] public bool bCastDynamicShadowAsMasked;
        [FieldOffset(976)] public VectorMaterialInput WorldPositionOffset;
        [FieldOffset(1048)] public VectorMaterialInput WorldDisplacement;
        [FieldOffset(1120)] public ScalarMaterialInput TessellationMultiplier;
        [FieldOffset(1184)] public ColorMaterialInput SubsurfaceColor;
        [FieldOffset(1248)] public ScalarMaterialInput ClearCoat;
        [FieldOffset(1312)] public ScalarMaterialInput ClearCoatRoughness;
        [FieldOffset(1376)] public ScalarMaterialInput AmbientOcclusion;
        [FieldOffset(1440)] public ScalarMaterialInput Refraction;
        [FieldOffset(1504)] public Vector2MaterialInput CustomizedUVs;
        [FieldOffset(2080)] public MaterialAttributesInput MaterialAttributes;
        [FieldOffset(2144)] public ScalarMaterialInput PixelDepthOffset;
        [FieldOffset(2208)] public bool bEnableSeparateTranslucency;
        [FieldOffset(2208)] public bool bEnableMobileSeparateTranslucency;
        [FieldOffset(2208)] public bool bEnableResponsiveAA;
        [FieldOffset(2208)] public bool bScreenSpaceReflections;
        [FieldOffset(2208)] public bool bContactShadows;
        [FieldOffset(2208)] public bool TwoSided;
        [FieldOffset(2208)] public bool DitheredLODTransition;
        [FieldOffset(2208)] public bool DitherOpacityMask;
        [FieldOffset(2209)] public bool bAllowNegativeEmissiveColor;
        [FieldOffset(2212)] public int NumCustomizedUVs;
        [FieldOffset(2216)] public byte TranslucencyLightingMode;
        [FieldOffset(2220)] public float TranslucencyDirectionalLightingIntensity;
        [FieldOffset(2224)] public bool AllowTranslucentCustomDepthWrites;
        [FieldOffset(2228)] public float TranslucentShadowDensityScale;
        [FieldOffset(2232)] public float TranslucentSelfShadowDensityScale;
        [FieldOffset(2236)] public float TranslucentSelfShadowSecondDensityScale;
        [FieldOffset(2240)] public float TranslucentSelfShadowSecondOpacity;
        [FieldOffset(2244)] public float TranslucentBackscatteringExponent;
        [FieldOffset(2248)] public LinearColor TranslucentMultipleScatteringExtinction;
        [FieldOffset(2264)] public float TranslucentShadowStartOffset;
        [FieldOffset(2268)] public bool bDisableDepthTest;
        [FieldOffset(2268)] public bool bWriteOnlyAlpha;
        [FieldOffset(2268)] public bool bGenerateSphericalParticleNormals;
        [FieldOffset(2268)] public bool bTangentSpaceNormal;
        [FieldOffset(2268)] public bool bUseEmissiveForDynamicAreaLighting;
        [FieldOffset(2268)] public bool bBlockGI;
        [FieldOffset(2268)] public bool bUsedAsSpecialEngineMaterial;
        [FieldOffset(2268)] public bool bUsedWithSkeletalMesh;
        [FieldOffset(2269)] public bool bUsedWithEditorCompositing;
        [FieldOffset(2269)] public bool bUsedWithParticleSprites;
        [FieldOffset(2269)] public bool bUsedWithBeamTrails;
        [FieldOffset(2269)] public bool bUsedWithMeshParticles;
        [FieldOffset(2269)] public bool bUsedWithNiagaraSprites;
        [FieldOffset(2269)] public bool bUsedWithNiagaraRibbons;
        [FieldOffset(2269)] public bool bUsedWithNiagaraMeshParticles;
        [FieldOffset(2269)] public bool bUsedWithGeometryCache;
        [FieldOffset(2270)] public bool bUsedWithStaticLighting;
        [FieldOffset(2270)] public bool bUsedWithMorphTargets;
        [FieldOffset(2270)] public bool bUsedWithSplineMeshes;
        [FieldOffset(2270)] public bool bUsedWithInstancedStaticMeshes;
        [FieldOffset(2270)] public bool bUsesDistortion;
        [FieldOffset(2270)] public bool bUsedWithClothing;
        [FieldOffset(2270)] public bool bAutomaticallySetUsageInEditor;
        [FieldOffset(2271)] public bool bFullyRough;
        [FieldOffset(2271)] public bool bUseFullPrecision;
        [FieldOffset(2271)] public bool bUseLightmapDirectionality;
        [FieldOffset(2271)] public bool bUseHQForwardReflections;
        [FieldOffset(2271)] public bool bUsePlanarForwardReflections;
        [FieldOffset(2271)] public bool bNormalCurvatureToRoughness;
        [FieldOffset(2272)] public byte D3D11TessellationMode;
        [FieldOffset(2276)] public bool bEnableCrackFreeDisplacement;
        [FieldOffset(2276)] public bool bEnableAdaptiveTessellation;
        [FieldOffset(2280)] public float MaxDisplacement;
        [FieldOffset(2284)] public bool Wireframe;
        [FieldOffset(2284)] public bool bOutputVelocityOnBasePass;
        [FieldOffset(2288)] public int EditorX;
        [FieldOffset(2292)] public int EditorY;
        [FieldOffset(2296)] public int EditorPitch;
        [FieldOffset(2300)] public int EditorYaw;
        [FieldOffset(2304)] public NativeArray Expressions;
        [FieldOffset(2320)] public NativeArray EditorComments;
        [FieldOffset(2336)] public NativeArray ParameterGroupData;
        [FieldOffset(2352)] public NativeArray MaterialFunctionInfos;
        [FieldOffset(2368)] public NativeArray MaterialParameterCollectionInfos;
        [FieldOffset(2384)] public bool bCanMaskedBeAssumedOpaque;
        [FieldOffset(2384)] public bool bIsPreviewMaterial;
        [FieldOffset(2384)] public bool bIsFunctionPreviewMaterial;
        [FieldOffset(2384)] public bool bUseMaterialAttributes;
        [FieldOffset(2384)] public bool bUseTranslucencyVertexFog;
        [FieldOffset(2384)] public bool bComputeFogPerPixel;
        [FieldOffset(2384)] public bool bAllowDevelopmentShaderCompile;
        [FieldOffset(2385)] public bool bIsMaterialEditorStatsMaterial;
        [FieldOffset(2388)] byte UsageFlagWarnings; //TODO: numeric uint32 UsageFlagWarnings
        [FieldOffset(2392)] public byte BlendableLocation;
        [FieldOffset(2396)] public int BlendablePriority;
        [FieldOffset(2400)] public bool BlendableOutputAlpha;
        [FieldOffset(2401)] public byte RefractionMode;
        [FieldOffset(2404)] public float RefractionDepthBias;
        [FieldOffset(2408)] public FGuid StateId;
        [FieldOffset(2536)] public NativeArray CachedQualityLevelsUsed;
        [FieldOffset(2752)] public NativeArray ExpressionTextureReferences;
        [FieldOffset(2768)] public NativeArray ReferencedTextureGuids;
    }
    internal unsafe struct Material_methods {
    }
    internal unsafe struct Material_events {
    }
}
