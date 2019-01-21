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
    [StructLayout( LayoutKind.Explicit, Size=1696 )]
    internal unsafe struct WorldSettings_fields {
        [FieldOffset(1024)] public bool bEnableWorldBoundsChecks;
        [FieldOffset(1024)] public bool bEnableNavigationSystem;
        [FieldOffset(1024)] public bool bEnableAISystem;
        [FieldOffset(1024)] public bool bEnableWorldComposition;
        [FieldOffset(1024)] public bool bUseClientSideLevelStreamingVolumes;
        [FieldOffset(1024)] public bool bEnableWorldOriginRebasing;
        [FieldOffset(1024)] public bool bWorldGravitySet;
        [FieldOffset(1024)] public bool bGlobalGravitySet;
        [FieldOffset(1032)]  public IntPtr  NavigationSystemConfig;
        [FieldOffset(1040)]  public IntPtr  NavigationSystemConfigOverride;
        [FieldOffset(1048)] public float KillZ;
        [FieldOffset(1056)] public IntPtr KillZDamageType;
        [FieldOffset(1064)] public float WorldGravityZ;
        [FieldOffset(1068)] public float GlobalGravityZ;
        [FieldOffset(1072)] public IntPtr DefaultPhysicsVolumeClass;
        [FieldOffset(1080)] public IntPtr PhysicsCollisionHandlerClass;
        [FieldOffset(1088)] public IntPtr DefaultGameMode;
        [FieldOffset(1096)] public IntPtr GameNetworkManagerClass;
        [FieldOffset(1104)] public int PackedLightAndShadowMapTextureSize;
        [FieldOffset(1108)] public bool bMinimizeBSPSections;
        [FieldOffset(1112)] public Vector DefaultColorScale;
        [FieldOffset(1124)] public float DefaultMaxDistanceFieldOcclusionDistance;
        [FieldOffset(1128)] public float GlobalDistanceFieldViewDistance;
        [FieldOffset(1132)] public float DynamicIndirectShadowsSelfShadowingIntensity;
        [FieldOffset(1136)] public bool bPrecomputeVisibility;
        [FieldOffset(1136)] public bool bPlaceCellsOnlyAlongCameraTracks;
        [FieldOffset(1140)] public int VisibilityCellSize;
        [FieldOffset(1144)] public byte VisibilityAggressiveness;
        [FieldOffset(1148)] public bool bForceNoPrecomputedLighting;
        [FieldOffset(1152)] public LightmassWorldInfoSettings LightmassSettings;
        [FieldOffset(1240)] public ReverbSettings DefaultReverbSettings;
        [FieldOffset(1272)] public InteriorSettings DefaultAmbientZoneSettings;
        [FieldOffset(1312)]  public IntPtr  DefaultBaseSoundMix;
        [FieldOffset(1320)] public bool bEnableHierarchicalLODSystem;
        [FieldOffset(1328)] byte HLODSetupAsset; //TODO: soft class TSoftClassPtr<UHierarchicalLODSetup>  HLODSetupAsset
        [FieldOffset(1376)] byte OverrideBaseMaterial; //TODO: soft object TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial
        [FieldOffset(1424)] public NativeArray HierarchicalLODSetup;
        [FieldOffset(1440)] public int NumHLODLevels;
        [FieldOffset(1444)] public bool bGenerateSingleClusterForLevel;
        [FieldOffset(1448)] public float WorldToMeters;
        [FieldOffset(1452)] public float MonoCullingDistance;
        [FieldOffset(1456)]  public IntPtr  BookMarks;
        [FieldOffset(1536)] public float TimeDilation;
        [FieldOffset(1540)] public float MatineeTimeDilation;
        [FieldOffset(1544)] public float DemoPlayTimeDilation;
        [FieldOffset(1548)] public float MinGlobalTimeDilation;
        [FieldOffset(1552)] public float MaxGlobalTimeDilation;
        [FieldOffset(1556)] public float MinUndilatedFrameTime;
        [FieldOffset(1560)] public float MaxUndilatedFrameTime;
        [FieldOffset(1568)]  public IntPtr  Pauser;
        [FieldOffset(1576)] public bool bHighPriorityLoading;
        [FieldOffset(1576)] public bool bHighPriorityLoadingLocal;
        [FieldOffset(1584)] public NativeArray ReplicationViewers;
        [FieldOffset(1600)] public bool bOverrideDefaultBroadphaseSettings;
        [FieldOffset(1604)] public BroadphaseSettings BroadphaseSettings;
        [FieldOffset(1640)] public NativeArray AssetUserData;
        [FieldOffset(1656)] public int MaxNumberOfBookmarks;
        [FieldOffset(1664)] public IntPtr DefaultBookmarkClass;
        [FieldOffset(1672)] public NativeArray BookmarkArray;
        [FieldOffset(1688)] public IntPtr LastBookmarkClass;
    }
    internal unsafe struct WorldSettings_methods {
    }
    internal unsafe struct WorldSettings_events {
    }
}
