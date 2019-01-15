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
    [StructLayout( LayoutKind.Explicit, Size=1648 )]
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
        [FieldOffset(1040)] public float KillZ;
        [FieldOffset(1048)] public IntPtr KillZDamageType;
        [FieldOffset(1056)] public float WorldGravityZ;
        [FieldOffset(1060)] public float GlobalGravityZ;
        [FieldOffset(1064)] public IntPtr DefaultPhysicsVolumeClass;
        [FieldOffset(1072)] public IntPtr PhysicsCollisionHandlerClass;
        [FieldOffset(1080)] public IntPtr DefaultGameMode;
        [FieldOffset(1088)] public IntPtr GameNetworkManagerClass;
        [FieldOffset(1096)] public int PackedLightAndShadowMapTextureSize;
        [FieldOffset(1100)] public bool bMinimizeBSPSections;
        [FieldOffset(1104)] public Vector DefaultColorScale;
        [FieldOffset(1116)] public float DefaultMaxDistanceFieldOcclusionDistance;
        [FieldOffset(1120)] public float GlobalDistanceFieldViewDistance;
        [FieldOffset(1124)] public float DynamicIndirectShadowsSelfShadowingIntensity;
        [FieldOffset(1128)] public bool bPrecomputeVisibility;
        [FieldOffset(1128)] public bool bPlaceCellsOnlyAlongCameraTracks;
        [FieldOffset(1132)] public int VisibilityCellSize;
        [FieldOffset(1136)] public byte VisibilityAggressiveness;
        [FieldOffset(1140)] public bool bForceNoPrecomputedLighting;
        [FieldOffset(1144)] public LightmassWorldInfoSettings LightmassSettings;
        [FieldOffset(1232)] public ReverbSettings DefaultReverbSettings;
        [FieldOffset(1264)] public InteriorSettings DefaultAmbientZoneSettings;
        [FieldOffset(1304)]  public IntPtr  DefaultBaseSoundMix;
        [FieldOffset(1312)] public bool bEnableHierarchicalLODSystem;
        [FieldOffset(1320)] byte HLODSetupAsset; //TODO: soft class TSoftClassPtr<UHierarchicalLODSetup>  HLODSetupAsset
        [FieldOffset(1368)] byte OverrideBaseMaterial; //TODO: soft object TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial
        [FieldOffset(1416)] public NativeArray HierarchicalLODSetup;
        [FieldOffset(1432)] public int NumHLODLevels;
        [FieldOffset(1436)] public bool bGenerateSingleClusterForLevel;
        [FieldOffset(1440)] public float WorldToMeters;
        [FieldOffset(1444)] public float MonoCullingDistance;
        [FieldOffset(1448)]  public IntPtr  BookMarks;
        [FieldOffset(1528)] public float TimeDilation;
        [FieldOffset(1532)] public float MatineeTimeDilation;
        [FieldOffset(1536)] public float DemoPlayTimeDilation;
        [FieldOffset(1540)] public float MinGlobalTimeDilation;
        [FieldOffset(1544)] public float MaxGlobalTimeDilation;
        [FieldOffset(1548)] public float MinUndilatedFrameTime;
        [FieldOffset(1552)] public float MaxUndilatedFrameTime;
        [FieldOffset(1560)]  public IntPtr  Pauser;
        [FieldOffset(1568)] public bool bHighPriorityLoading;
        [FieldOffset(1568)] public bool bHighPriorityLoadingLocal;
        [FieldOffset(1576)] public NativeArray ReplicationViewers;
        [FieldOffset(1592)] public bool bOverrideDefaultBroadphaseSettings;
        [FieldOffset(1596)] public BroadphaseSettings BroadphaseSettings;
        [FieldOffset(1632)] public NativeArray AssetUserData;
    }
    internal unsafe struct WorldSettings_methods {
    }
    internal unsafe struct WorldSettings_events {
    }
}
