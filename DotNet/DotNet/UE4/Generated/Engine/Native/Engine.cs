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
    [StructLayout( LayoutKind.Explicit, Size=4128 )]
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
        [FieldOffset(536)] public IntPtr NavigationSystemConfigClass;
        [FieldOffset(544)] public SoftClassPath AvoidanceManagerClassName;
        [FieldOffset(576)] public IntPtr AvoidanceManagerClass;
        [FieldOffset(584)] public IntPtr PhysicsCollisionHandlerClass;
        [FieldOffset(592)] public SoftClassPath PhysicsCollisionHandlerClassName;
        [FieldOffset(624)] public SoftClassPath GameUserSettingsClassName;
        [FieldOffset(656)] public IntPtr GameUserSettingsClass;
        [FieldOffset(664)] public SoftClassPath AIControllerClassName;
        [FieldOffset(696)]  public IntPtr  GameUserSettings;
        [FieldOffset(704)] public IntPtr LevelScriptActorClass;
        [FieldOffset(712)] public SoftClassPath LevelScriptActorClassName;
        [FieldOffset(744)] public SoftClassPath DefaultBlueprintBaseClassName;
        [FieldOffset(776)] public SoftClassPath GameSingletonClassName;
        [FieldOffset(808)]  public IntPtr  GameSingleton;
        [FieldOffset(816)] public SoftClassPath AssetManagerClassName;
        [FieldOffset(848)]  public IntPtr  AssetManager;
        [FieldOffset(856)]  public IntPtr  DefaultTexture;
        [FieldOffset(864)] public SoftObjectPath DefaultTextureName;
        [FieldOffset(896)]  public IntPtr  DefaultDiffuseTexture;
        [FieldOffset(904)] public SoftObjectPath DefaultDiffuseTextureName;
        [FieldOffset(936)]  public IntPtr  DefaultBSPVertexTexture;
        [FieldOffset(944)] public SoftObjectPath DefaultBSPVertexTextureName;
        [FieldOffset(976)]  public IntPtr  HighFrequencyNoiseTexture;
        [FieldOffset(984)] public SoftObjectPath HighFrequencyNoiseTextureName;
        [FieldOffset(1016)]  public IntPtr  DefaultBokehTexture;
        [FieldOffset(1024)] public SoftObjectPath DefaultBokehTextureName;
        [FieldOffset(1056)]  public IntPtr  DefaultBloomKernelTexture;
        [FieldOffset(1064)] public SoftObjectPath DefaultBloomKernelTextureName;
        [FieldOffset(1096)]  public IntPtr  WireframeMaterial;
        [FieldOffset(1104)] byte WireframeMaterialName; //TODO: string FString WireframeMaterialName
        [FieldOffset(1120)]  public IntPtr  GeomMaterial;
        [FieldOffset(1128)] public SoftObjectPath GeomMaterialName;
        [FieldOffset(1160)]  public IntPtr  DebugMeshMaterial;
        [FieldOffset(1168)] public SoftObjectPath DebugMeshMaterialName;
        [FieldOffset(1200)]  public IntPtr  LevelColorationLitMaterial;
        [FieldOffset(1208)] byte LevelColorationLitMaterialName; //TODO: string FString LevelColorationLitMaterialName
        [FieldOffset(1224)]  public IntPtr  LevelColorationUnlitMaterial;
        [FieldOffset(1232)] byte LevelColorationUnlitMaterialName; //TODO: string FString LevelColorationUnlitMaterialName
        [FieldOffset(1248)]  public IntPtr  LightingTexelDensityMaterial;
        [FieldOffset(1256)] byte LightingTexelDensityName; //TODO: string FString LightingTexelDensityName
        [FieldOffset(1272)]  public IntPtr  ShadedLevelColorationLitMaterial;
        [FieldOffset(1280)] byte ShadedLevelColorationLitMaterialName; //TODO: string FString ShadedLevelColorationLitMaterialName
        [FieldOffset(1296)]  public IntPtr  ShadedLevelColorationUnlitMaterial;
        [FieldOffset(1304)] byte ShadedLevelColorationUnlitMaterialName; //TODO: string FString ShadedLevelColorationUnlitMaterialName
        [FieldOffset(1320)]  public IntPtr  RemoveSurfaceMaterial;
        [FieldOffset(1328)] public SoftObjectPath RemoveSurfaceMaterialName;
        [FieldOffset(1360)]  public IntPtr  VertexColorMaterial;
        [FieldOffset(1368)] byte VertexColorMaterialName; //TODO: string FString VertexColorMaterialName
        [FieldOffset(1384)]  public IntPtr  VertexColorViewModeMaterial_ColorOnly;
        [FieldOffset(1392)] byte VertexColorViewModeMaterialName_ColorOnly; //TODO: string FString VertexColorViewModeMaterialName_ColorOnly
        [FieldOffset(1408)]  public IntPtr  VertexColorViewModeMaterial_AlphaAsColor;
        [FieldOffset(1416)] byte VertexColorViewModeMaterialName_AlphaAsColor; //TODO: string FString VertexColorViewModeMaterialName_AlphaAsColor
        [FieldOffset(1432)]  public IntPtr  VertexColorViewModeMaterial_RedOnly;
        [FieldOffset(1440)] byte VertexColorViewModeMaterialName_RedOnly; //TODO: string FString VertexColorViewModeMaterialName_RedOnly
        [FieldOffset(1456)]  public IntPtr  VertexColorViewModeMaterial_GreenOnly;
        [FieldOffset(1464)] byte VertexColorViewModeMaterialName_GreenOnly; //TODO: string FString VertexColorViewModeMaterialName_GreenOnly
        [FieldOffset(1480)]  public IntPtr  VertexColorViewModeMaterial_BlueOnly;
        [FieldOffset(1488)] byte VertexColorViewModeMaterialName_BlueOnly; //TODO: string FString VertexColorViewModeMaterialName_BlueOnly
        [FieldOffset(1504)]  public IntPtr  BoneWeightMaterial;
        [FieldOffset(1512)] public SoftObjectPath BoneWeightMaterialName;
        [FieldOffset(1544)]  public IntPtr  ClothPaintMaterial;
        [FieldOffset(1552)]  public IntPtr  ClothPaintMaterialWireframe;
        [FieldOffset(1560)]  public IntPtr  ClothPaintMaterialInstance;
        [FieldOffset(1568)]  public IntPtr  ClothPaintMaterialWireframeInstance;
        [FieldOffset(1576)] public SoftObjectPath ClothPaintMaterialName;
        [FieldOffset(1608)] public SoftObjectPath ClothPaintMaterialWireframeName;
        [FieldOffset(1640)]  public IntPtr  DebugEditorMaterial;
        [FieldOffset(1648)] public SoftObjectPath DebugEditorMaterialName;
        [FieldOffset(1680)]  public IntPtr  ConstraintLimitMaterial;
        [FieldOffset(1688)]  public IntPtr  ConstraintLimitMaterialX;
        [FieldOffset(1696)]  public IntPtr  ConstraintLimitMaterialXAxis;
        [FieldOffset(1704)]  public IntPtr  ConstraintLimitMaterialY;
        [FieldOffset(1712)]  public IntPtr  ConstraintLimitMaterialYAxis;
        [FieldOffset(1720)]  public IntPtr  ConstraintLimitMaterialZ;
        [FieldOffset(1728)]  public IntPtr  ConstraintLimitMaterialZAxis;
        [FieldOffset(1736)]  public IntPtr  ConstraintLimitMaterialPrismatic;
        [FieldOffset(1744)]  public IntPtr  InvalidLightmapSettingsMaterial;
        [FieldOffset(1752)] public SoftObjectPath InvalidLightmapSettingsMaterialName;
        [FieldOffset(1784)]  public IntPtr  PreviewShadowsIndicatorMaterial;
        [FieldOffset(1792)] public SoftObjectPath PreviewShadowsIndicatorMaterialName;
        [FieldOffset(1824)]  public IntPtr  ArrowMaterial;
        [FieldOffset(1832)] public SoftObjectPath ArrowMaterialName;
        [FieldOffset(1864)] public LinearColor LightingOnlyBrightness;
        [FieldOffset(1880)] public NativeArray ShaderComplexityColors;
        [FieldOffset(1896)] public NativeArray QuadComplexityColors;
        [FieldOffset(1912)] public NativeArray LightComplexityColors;
        [FieldOffset(1928)] public NativeArray StationaryLightOverlapColors;
        [FieldOffset(1944)] public NativeArray LODColorationColors;
        [FieldOffset(1960)] public NativeArray HLODColorationColors;
        [FieldOffset(1976)] public NativeArray StreamingAccuracyColors;
        [FieldOffset(1992)] public float MaxPixelShaderAdditiveComplexityCount;
        [FieldOffset(1996)] public float MaxES2PixelShaderAdditiveComplexityCount;
        [FieldOffset(2000)] public float MaxES3PixelShaderAdditiveComplexityCount;
        [FieldOffset(2004)] public float MinLightMapDensity;
        [FieldOffset(2008)] public float IdealLightMapDensity;
        [FieldOffset(2012)] public float MaxLightMapDensity;
        [FieldOffset(2016)] public bool bRenderLightMapDensityGrayscale;
        [FieldOffset(2020)] public float RenderLightMapDensityGrayscaleScale;
        [FieldOffset(2024)] public float RenderLightMapDensityColorScale;
        [FieldOffset(2028)] public LinearColor LightMapDensityVertexMappedColor;
        [FieldOffset(2044)] public LinearColor LightMapDensitySelectedColor;
        [FieldOffset(2064)] public NativeArray StatColorMappings;
        [FieldOffset(2080)]  public IntPtr  EditorBrushMaterial;
        [FieldOffset(2088)] public SoftObjectPath EditorBrushMaterialName;
        [FieldOffset(2120)]  public IntPtr  DefaultPhysMaterial;
        [FieldOffset(2128)] public SoftObjectPath DefaultPhysMaterialName;
        [FieldOffset(2160)] public NativeArray ActiveGameNameRedirects;
        [FieldOffset(2176)] public NativeArray ActiveClassRedirects;
        [FieldOffset(2192)] public NativeArray ActivePluginRedirects;
        [FieldOffset(2208)] public NativeArray ActiveStructRedirects;
        [FieldOffset(2224)]  public IntPtr  PreIntegratedSkinBRDFTexture;
        [FieldOffset(2232)] public SoftObjectPath PreIntegratedSkinBRDFTextureName;
        [FieldOffset(2264)]  public IntPtr  MiniFontTexture;
        [FieldOffset(2272)] public SoftObjectPath MiniFontTextureName;
        [FieldOffset(2304)]  public IntPtr  WeightMapPlaceholderTexture;
        [FieldOffset(2312)] public SoftObjectPath WeightMapPlaceholderTextureName;
        [FieldOffset(2344)]  public IntPtr  LightMapDensityTexture;
        [FieldOffset(2352)] public SoftObjectPath LightMapDensityTextureName;
        [FieldOffset(2392)]  public IntPtr  GameViewport;
        [FieldOffset(2400)] public NativeArray DeferredCommands;
        [FieldOffset(2416)] public int TickCycles;
        [FieldOffset(2420)] public int GameCycles;
        [FieldOffset(2424)] public int ClientCycles;
        [FieldOffset(2428)] public float NearClipPlane;
        [FieldOffset(2432)] public bool bSubtitlesEnabled;
        [FieldOffset(2432)] public bool bSubtitlesForcedOff;
        [FieldOffset(2436)] public int MaximumLoopIterationCount;
        [FieldOffset(2440)] public bool bCanBlueprintsTickByDefault;
        [FieldOffset(2440)] public bool bOptimizeAnimBlueprintMemberVariableAccess;
        [FieldOffset(2440)] public bool bAllowMultiThreadedAnimationUpdate;
        [FieldOffset(2440)] public bool bEnableEditorPSysRealtimeLOD;
        [FieldOffset(2440)] public bool bSmoothFrameRate;
        [FieldOffset(2440)] public bool bUseFixedFrameRate;
        [FieldOffset(2444)] public float FixedFrameRate;
        [FieldOffset(2448)] public FloatRange SmoothedFrameRateRange;
        [FieldOffset(2464)]  public IntPtr  DefaultCustomTimeStep;
        [FieldOffset(2472)]  public IntPtr  CurrentCustomTimeStep;
        [FieldOffset(2480)] public SoftClassPath CustomTimeStepClassName;
        [FieldOffset(2512)]  public IntPtr  DefaultTimecodeProvider;
        [FieldOffset(2520)]  public IntPtr  CustomTimecodeProvider;
        [FieldOffset(2528)] public SoftClassPath DefaultTimecodeProviderClassName;
        [FieldOffset(2560)] public SoftClassPath TimecodeProviderClassName;
        [FieldOffset(2592)] public FrameRate DefaultTimecodeFrameRate;
        [FieldOffset(2600)] public bool bCheckForMultiplePawnsSpawnedInAFrame;
        [FieldOffset(2604)] public int NumPawnsAllowedToBeSpawnedInAFrame;
        [FieldOffset(2612)] public Color C_WorldBox;
        [FieldOffset(2616)] public Color C_BrushWire;
        [FieldOffset(2620)] public Color C_AddWire;
        [FieldOffset(2624)] public Color C_SubtractWire;
        [FieldOffset(2628)] public Color C_SemiSolidWire;
        [FieldOffset(2632)] public Color C_NonSolidWire;
        [FieldOffset(2636)] public Color C_WireBackground;
        [FieldOffset(2640)] public Color C_ScaleBoxHi;
        [FieldOffset(2644)] public Color C_VolumeCollision;
        [FieldOffset(2648)] public Color C_BSPCollision;
        [FieldOffset(2652)] public Color C_OrthoBackground;
        [FieldOffset(2656)] public Color C_Volume;
        [FieldOffset(2660)] public Color C_BrushShape;
        [FieldOffset(2664)] public float StreamingDistanceFactor;
        [FieldOffset(2672)] public DirectoryPath GameScreenshotSaveDirectory;
        [FieldOffset(2688)] public byte TransitionType;
        [FieldOffset(2696)] byte TransitionDescription; //TODO: string FString TransitionDescription
        [FieldOffset(2712)] byte TransitionGameMode; //TODO: string FString TransitionGameMode
        [FieldOffset(2728)] public float MeshLODRange;
        [FieldOffset(2732)] public bool bAllowMatureLanguage;
        [FieldOffset(2736)] public float CameraRotationThreshold;
        [FieldOffset(2740)] public float CameraTranslationThreshold;
        [FieldOffset(2744)] public float PrimitiveProbablyVisibleTime;
        [FieldOffset(2748)] public float MaxOcclusionPixelsFraction;
        [FieldOffset(2752)] public bool bPauseOnLossOfFocus;
        [FieldOffset(2756)] public int MaxParticleResize;
        [FieldOffset(2760)] public int MaxParticleResizeWarn;
        [FieldOffset(2768)] public NativeArray PendingDroppedNotes;
        [FieldOffset(2784)] public float NetClientTicksPerSecond;
        [FieldOffset(2788)] public float DisplayGamma;
        [FieldOffset(2792)] public float MinDesiredFrameRate;
        [FieldOffset(2796)] public LinearColor DefaultSelectedMaterialColor;
        [FieldOffset(2812)] public LinearColor SelectedMaterialColor;
        [FieldOffset(2828)] public LinearColor SelectionOutlineColor;
        [FieldOffset(2844)] public LinearColor SubduedSelectionOutlineColor;
        [FieldOffset(2860)] public LinearColor SelectedMaterialColorOverride;
        [FieldOffset(2876)] public bool bIsOverridingSelectedColor;
        [FieldOffset(2880)] public bool bEnableOnScreenDebugMessages;
        [FieldOffset(2880)] public bool bEnableOnScreenDebugMessagesDisplay;
        [FieldOffset(2880)] public bool bSuppressMapWarnings;
        [FieldOffset(2880)] public bool bDisableAILogging;
        [FieldOffset(2884)] byte bEnableVisualLogRecordingOnStart; //TODO: numeric uint32 bEnableVisualLogRecordingOnStart
        [FieldOffset(2892)] public int ScreenSaverInhibitorSemaphore;
        [FieldOffset(2896)] public bool bLockReadOnlyLevels;
        [FieldOffset(2904)] byte ParticleEventManagerClassPath; //TODO: string FString ParticleEventManagerClassPath
        [FieldOffset(2936)] public float SelectionHighlightIntensity;
        [FieldOffset(2940)] public float SelectionMeshSectionHighlightIntensity;
        [FieldOffset(2944)] public float BSPSelectionHighlightIntensity;
        [FieldOffset(2948)] public float HoverHighlightIntensity;
        [FieldOffset(2952)] public float SelectionHighlightIntensityBillboards;
        [FieldOffset(3816)] public NativeArray NetDriverDefinitions;
        [FieldOffset(3832)] public NativeArray ServerActors;
        [FieldOffset(3848)] public NativeArray RuntimeServerActors;
        [FieldOffset(3864)] public bool bStartedLoadMapMovie;
        [FieldOffset(3920)] public int NextWorldContextHandle;
    }
    internal unsafe struct Engine_methods {
    }
    internal unsafe struct Engine_events {
    }
}
