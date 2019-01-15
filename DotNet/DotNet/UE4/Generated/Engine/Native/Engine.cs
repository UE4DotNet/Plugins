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
    [StructLayout( LayoutKind.Explicit, Size=4048 )]
    internal unsafe struct Engine_fields {
        [FieldOffset(64)]  public IntPtr  TinyFont;
        [FieldOffset(72)] public SoftObjectPath TinyFontName;
        [FieldOffset(104)]  public IntPtr  SmallFont;
        [FieldOffset(112)] public SoftObjectPath SmallFontName;
        [FieldOffset(144)]  public IntPtr  MediumFont;
        [FieldOffset(152)] public SoftObjectPath MediumFontName;
        [FieldOffset(184)]  public IntPtr  LargeFont;
        [FieldOffset(192)] public SoftObjectPath LargeFontName;
        [FieldOffset(224)]  public IntPtr  SubtitleFont;
        [FieldOffset(232)] public SoftObjectPath SubtitleFontName;
        [FieldOffset(264)] public NativeArray AdditionalFonts;
        [FieldOffset(288)] public NativeArray AdditionalFontNames;
        [FieldOffset(304)] public IntPtr ConsoleClass;
        [FieldOffset(312)] public SoftClassPath ConsoleClassName;
        [FieldOffset(344)] public IntPtr GameViewportClientClass;
        [FieldOffset(352)] public SoftClassPath GameViewportClientClassName;
        [FieldOffset(384)] public IntPtr LocalPlayerClass;
        [FieldOffset(392)] public SoftClassPath LocalPlayerClassName;
        [FieldOffset(424)] public IntPtr WorldSettingsClass;
        [FieldOffset(432)] public SoftClassPath WorldSettingsClassName;
        [FieldOffset(464)] public SoftClassPath NavigationSystemClassName;
        [FieldOffset(496)] public IntPtr NavigationSystemClass;
        [FieldOffset(504)] public SoftClassPath NavigationSystemConfigClassName;
        [FieldOffset(536)] public SoftClassPath AvoidanceManagerClassName;
        [FieldOffset(568)] public IntPtr AvoidanceManagerClass;
        [FieldOffset(576)] public IntPtr PhysicsCollisionHandlerClass;
        [FieldOffset(584)] public SoftClassPath PhysicsCollisionHandlerClassName;
        [FieldOffset(616)] public SoftClassPath GameUserSettingsClassName;
        [FieldOffset(648)] public IntPtr GameUserSettingsClass;
        [FieldOffset(656)] public SoftClassPath AIControllerClassName;
        [FieldOffset(688)]  public IntPtr  GameUserSettings;
        [FieldOffset(696)] public IntPtr LevelScriptActorClass;
        [FieldOffset(704)] public SoftClassPath LevelScriptActorClassName;
        [FieldOffset(736)] public SoftClassPath DefaultBlueprintBaseClassName;
        [FieldOffset(768)] public SoftClassPath GameSingletonClassName;
        [FieldOffset(800)]  public IntPtr  GameSingleton;
        [FieldOffset(808)] public SoftClassPath AssetManagerClassName;
        [FieldOffset(840)]  public IntPtr  AssetManager;
        [FieldOffset(848)]  public IntPtr  DefaultTexture;
        [FieldOffset(856)] public SoftObjectPath DefaultTextureName;
        [FieldOffset(888)]  public IntPtr  DefaultDiffuseTexture;
        [FieldOffset(896)] public SoftObjectPath DefaultDiffuseTextureName;
        [FieldOffset(928)]  public IntPtr  DefaultBSPVertexTexture;
        [FieldOffset(936)] public SoftObjectPath DefaultBSPVertexTextureName;
        [FieldOffset(968)]  public IntPtr  HighFrequencyNoiseTexture;
        [FieldOffset(976)] public SoftObjectPath HighFrequencyNoiseTextureName;
        [FieldOffset(1008)]  public IntPtr  DefaultBokehTexture;
        [FieldOffset(1016)] public SoftObjectPath DefaultBokehTextureName;
        [FieldOffset(1048)]  public IntPtr  DefaultBloomKernelTexture;
        [FieldOffset(1056)] public SoftObjectPath DefaultBloomKernelTextureName;
        [FieldOffset(1088)]  public IntPtr  WireframeMaterial;
        [FieldOffset(1096)] byte WireframeMaterialName; //TODO: string FString WireframeMaterialName
        [FieldOffset(1112)]  public IntPtr  GeomMaterial;
        [FieldOffset(1120)] public SoftObjectPath GeomMaterialName;
        [FieldOffset(1152)]  public IntPtr  DebugMeshMaterial;
        [FieldOffset(1160)] public SoftObjectPath DebugMeshMaterialName;
        [FieldOffset(1192)]  public IntPtr  LevelColorationLitMaterial;
        [FieldOffset(1200)] byte LevelColorationLitMaterialName; //TODO: string FString LevelColorationLitMaterialName
        [FieldOffset(1216)]  public IntPtr  LevelColorationUnlitMaterial;
        [FieldOffset(1224)] byte LevelColorationUnlitMaterialName; //TODO: string FString LevelColorationUnlitMaterialName
        [FieldOffset(1240)]  public IntPtr  LightingTexelDensityMaterial;
        [FieldOffset(1248)] byte LightingTexelDensityName; //TODO: string FString LightingTexelDensityName
        [FieldOffset(1264)]  public IntPtr  ShadedLevelColorationLitMaterial;
        [FieldOffset(1272)] byte ShadedLevelColorationLitMaterialName; //TODO: string FString ShadedLevelColorationLitMaterialName
        [FieldOffset(1288)]  public IntPtr  ShadedLevelColorationUnlitMaterial;
        [FieldOffset(1296)] byte ShadedLevelColorationUnlitMaterialName; //TODO: string FString ShadedLevelColorationUnlitMaterialName
        [FieldOffset(1312)]  public IntPtr  RemoveSurfaceMaterial;
        [FieldOffset(1320)] public SoftObjectPath RemoveSurfaceMaterialName;
        [FieldOffset(1352)]  public IntPtr  VertexColorMaterial;
        [FieldOffset(1360)] byte VertexColorMaterialName; //TODO: string FString VertexColorMaterialName
        [FieldOffset(1376)]  public IntPtr  VertexColorViewModeMaterial_ColorOnly;
        [FieldOffset(1384)] byte VertexColorViewModeMaterialName_ColorOnly; //TODO: string FString VertexColorViewModeMaterialName_ColorOnly
        [FieldOffset(1400)]  public IntPtr  VertexColorViewModeMaterial_AlphaAsColor;
        [FieldOffset(1408)] byte VertexColorViewModeMaterialName_AlphaAsColor; //TODO: string FString VertexColorViewModeMaterialName_AlphaAsColor
        [FieldOffset(1424)]  public IntPtr  VertexColorViewModeMaterial_RedOnly;
        [FieldOffset(1432)] byte VertexColorViewModeMaterialName_RedOnly; //TODO: string FString VertexColorViewModeMaterialName_RedOnly
        [FieldOffset(1448)]  public IntPtr  VertexColorViewModeMaterial_GreenOnly;
        [FieldOffset(1456)] byte VertexColorViewModeMaterialName_GreenOnly; //TODO: string FString VertexColorViewModeMaterialName_GreenOnly
        [FieldOffset(1472)]  public IntPtr  VertexColorViewModeMaterial_BlueOnly;
        [FieldOffset(1480)] byte VertexColorViewModeMaterialName_BlueOnly; //TODO: string FString VertexColorViewModeMaterialName_BlueOnly
        [FieldOffset(1496)]  public IntPtr  BoneWeightMaterial;
        [FieldOffset(1504)] public SoftObjectPath BoneWeightMaterialName;
        [FieldOffset(1536)]  public IntPtr  ClothPaintMaterial;
        [FieldOffset(1544)]  public IntPtr  ClothPaintMaterialWireframe;
        [FieldOffset(1552)]  public IntPtr  ClothPaintMaterialInstance;
        [FieldOffset(1560)]  public IntPtr  ClothPaintMaterialWireframeInstance;
        [FieldOffset(1568)] public SoftObjectPath ClothPaintMaterialName;
        [FieldOffset(1600)] public SoftObjectPath ClothPaintMaterialWireframeName;
        [FieldOffset(1632)]  public IntPtr  DebugEditorMaterial;
        [FieldOffset(1640)] public SoftObjectPath DebugEditorMaterialName;
        [FieldOffset(1672)]  public IntPtr  ConstraintLimitMaterial;
        [FieldOffset(1680)]  public IntPtr  ConstraintLimitMaterialX;
        [FieldOffset(1688)]  public IntPtr  ConstraintLimitMaterialXAxis;
        [FieldOffset(1696)]  public IntPtr  ConstraintLimitMaterialY;
        [FieldOffset(1704)]  public IntPtr  ConstraintLimitMaterialYAxis;
        [FieldOffset(1712)]  public IntPtr  ConstraintLimitMaterialZ;
        [FieldOffset(1720)]  public IntPtr  ConstraintLimitMaterialZAxis;
        [FieldOffset(1728)]  public IntPtr  ConstraintLimitMaterialPrismatic;
        [FieldOffset(1736)]  public IntPtr  InvalidLightmapSettingsMaterial;
        [FieldOffset(1744)] public SoftObjectPath InvalidLightmapSettingsMaterialName;
        [FieldOffset(1776)]  public IntPtr  PreviewShadowsIndicatorMaterial;
        [FieldOffset(1784)] public SoftObjectPath PreviewShadowsIndicatorMaterialName;
        [FieldOffset(1816)]  public IntPtr  ArrowMaterial;
        [FieldOffset(1824)] public SoftObjectPath ArrowMaterialName;
        [FieldOffset(1856)] public LinearColor LightingOnlyBrightness;
        [FieldOffset(1872)] public NativeArray ShaderComplexityColors;
        [FieldOffset(1888)] public NativeArray QuadComplexityColors;
        [FieldOffset(1904)] public NativeArray LightComplexityColors;
        [FieldOffset(1920)] public NativeArray StationaryLightOverlapColors;
        [FieldOffset(1936)] public NativeArray LODColorationColors;
        [FieldOffset(1952)] public NativeArray HLODColorationColors;
        [FieldOffset(1968)] public NativeArray StreamingAccuracyColors;
        [FieldOffset(1984)] public float MaxPixelShaderAdditiveComplexityCount;
        [FieldOffset(1988)] public float MaxES2PixelShaderAdditiveComplexityCount;
        [FieldOffset(1992)] public float MaxES3PixelShaderAdditiveComplexityCount;
        [FieldOffset(1996)] public float MinLightMapDensity;
        [FieldOffset(2000)] public float IdealLightMapDensity;
        [FieldOffset(2004)] public float MaxLightMapDensity;
        [FieldOffset(2008)] public bool bRenderLightMapDensityGrayscale;
        [FieldOffset(2012)] public float RenderLightMapDensityGrayscaleScale;
        [FieldOffset(2016)] public float RenderLightMapDensityColorScale;
        [FieldOffset(2020)] public LinearColor LightMapDensityVertexMappedColor;
        [FieldOffset(2036)] public LinearColor LightMapDensitySelectedColor;
        [FieldOffset(2056)] public NativeArray StatColorMappings;
        [FieldOffset(2072)]  public IntPtr  EditorBrushMaterial;
        [FieldOffset(2080)] public SoftObjectPath EditorBrushMaterialName;
        [FieldOffset(2112)]  public IntPtr  DefaultPhysMaterial;
        [FieldOffset(2120)] public SoftObjectPath DefaultPhysMaterialName;
        [FieldOffset(2152)] public NativeArray ActiveGameNameRedirects;
        [FieldOffset(2168)] public NativeArray ActiveClassRedirects;
        [FieldOffset(2184)] public NativeArray ActivePluginRedirects;
        [FieldOffset(2200)] public NativeArray ActiveStructRedirects;
        [FieldOffset(2216)]  public IntPtr  PreIntegratedSkinBRDFTexture;
        [FieldOffset(2224)] public SoftObjectPath PreIntegratedSkinBRDFTextureName;
        [FieldOffset(2256)]  public IntPtr  MiniFontTexture;
        [FieldOffset(2264)] public SoftObjectPath MiniFontTextureName;
        [FieldOffset(2296)]  public IntPtr  WeightMapPlaceholderTexture;
        [FieldOffset(2304)] public SoftObjectPath WeightMapPlaceholderTextureName;
        [FieldOffset(2336)]  public IntPtr  LightMapDensityTexture;
        [FieldOffset(2344)] public SoftObjectPath LightMapDensityTextureName;
        [FieldOffset(2384)]  public IntPtr  GameViewport;
        [FieldOffset(2392)] public NativeArray DeferredCommands;
        [FieldOffset(2408)] public int TickCycles;
        [FieldOffset(2412)] public int GameCycles;
        [FieldOffset(2416)] public int ClientCycles;
        [FieldOffset(2420)] public float NearClipPlane;
        [FieldOffset(2424)] public bool bSubtitlesEnabled;
        [FieldOffset(2424)] public bool bSubtitlesForcedOff;
        [FieldOffset(2428)] public int MaximumLoopIterationCount;
        [FieldOffset(2432)] public bool bCanBlueprintsTickByDefault;
        [FieldOffset(2432)] public bool bOptimizeAnimBlueprintMemberVariableAccess;
        [FieldOffset(2432)] public bool bAllowMultiThreadedAnimationUpdate;
        [FieldOffset(2432)] public bool bEnableEditorPSysRealtimeLOD;
        [FieldOffset(2432)] public bool bSmoothFrameRate;
        [FieldOffset(2432)] public bool bUseFixedFrameRate;
        [FieldOffset(2436)] public float FixedFrameRate;
        [FieldOffset(2440)] public FloatRange SmoothedFrameRateRange;
        [FieldOffset(2456)]  public IntPtr  CustomTimeStep;
        [FieldOffset(2464)] public SoftClassPath CustomTimeStepClassName;
        [FieldOffset(2496)]  public IntPtr  TimecodeProvider;
        [FieldOffset(2504)] public SoftClassPath TimecodeFrameRateClassName;
        [FieldOffset(2536)] public FrameRate DefaultTimecodeFrameRate;
        [FieldOffset(2544)] public bool bCheckForMultiplePawnsSpawnedInAFrame;
        [FieldOffset(2548)] public int NumPawnsAllowedToBeSpawnedInAFrame;
        [FieldOffset(2556)] public Color C_WorldBox;
        [FieldOffset(2560)] public Color C_BrushWire;
        [FieldOffset(2564)] public Color C_AddWire;
        [FieldOffset(2568)] public Color C_SubtractWire;
        [FieldOffset(2572)] public Color C_SemiSolidWire;
        [FieldOffset(2576)] public Color C_NonSolidWire;
        [FieldOffset(2580)] public Color C_WireBackground;
        [FieldOffset(2584)] public Color C_ScaleBoxHi;
        [FieldOffset(2588)] public Color C_VolumeCollision;
        [FieldOffset(2592)] public Color C_BSPCollision;
        [FieldOffset(2596)] public Color C_OrthoBackground;
        [FieldOffset(2600)] public Color C_Volume;
        [FieldOffset(2604)] public Color C_BrushShape;
        [FieldOffset(2608)] public float StreamingDistanceFactor;
        [FieldOffset(2616)] public DirectoryPath GameScreenshotSaveDirectory;
        [FieldOffset(2632)] public byte TransitionType;
        [FieldOffset(2640)] byte TransitionDescription; //TODO: string FString TransitionDescription
        [FieldOffset(2656)] byte TransitionGameMode; //TODO: string FString TransitionGameMode
        [FieldOffset(2672)] public float MeshLODRange;
        [FieldOffset(2676)] public bool bAllowMatureLanguage;
        [FieldOffset(2680)] public float CameraRotationThreshold;
        [FieldOffset(2684)] public float CameraTranslationThreshold;
        [FieldOffset(2688)] public float PrimitiveProbablyVisibleTime;
        [FieldOffset(2692)] public float MaxOcclusionPixelsFraction;
        [FieldOffset(2696)] public bool bPauseOnLossOfFocus;
        [FieldOffset(2700)] public int MaxParticleResize;
        [FieldOffset(2704)] public int MaxParticleResizeWarn;
        [FieldOffset(2712)] public NativeArray PendingDroppedNotes;
        [FieldOffset(2728)] public float NetClientTicksPerSecond;
        [FieldOffset(2732)] public float DisplayGamma;
        [FieldOffset(2736)] public float MinDesiredFrameRate;
        [FieldOffset(2740)] public LinearColor DefaultSelectedMaterialColor;
        [FieldOffset(2756)] public LinearColor SelectedMaterialColor;
        [FieldOffset(2772)] public LinearColor SelectionOutlineColor;
        [FieldOffset(2788)] public LinearColor SubduedSelectionOutlineColor;
        [FieldOffset(2804)] public LinearColor SelectedMaterialColorOverride;
        [FieldOffset(2820)] public bool bIsOverridingSelectedColor;
        [FieldOffset(2824)] public bool bEnableOnScreenDebugMessages;
        [FieldOffset(2824)] public bool bEnableOnScreenDebugMessagesDisplay;
        [FieldOffset(2824)] public bool bSuppressMapWarnings;
        [FieldOffset(2824)] public bool bDisableAILogging;
        [FieldOffset(2828)] byte bEnableVisualLogRecordingOnStart; //TODO: numeric uint32 bEnableVisualLogRecordingOnStart
        [FieldOffset(2836)] public int ScreenSaverInhibitorSemaphore;
        [FieldOffset(2840)] public bool bLockReadOnlyLevels;
        [FieldOffset(2848)] byte ParticleEventManagerClassPath; //TODO: string FString ParticleEventManagerClassPath
        [FieldOffset(2880)] public float SelectionHighlightIntensity;
        [FieldOffset(2884)] public float SelectionMeshSectionHighlightIntensity;
        [FieldOffset(2888)] public float BSPSelectionHighlightIntensity;
        [FieldOffset(2892)] public float HoverHighlightIntensity;
        [FieldOffset(2896)] public float SelectionHighlightIntensityBillboards;
        [FieldOffset(3736)] public NativeArray NetDriverDefinitions;
        [FieldOffset(3752)] public NativeArray ServerActors;
        [FieldOffset(3768)] public NativeArray RuntimeServerActors;
        [FieldOffset(3784)] public bool bStartedLoadMapMovie;
        [FieldOffset(3840)] public int NextWorldContextHandle;
    }
    internal unsafe struct Engine_methods {
    }
    internal unsafe struct Engine_events {
    }
}
