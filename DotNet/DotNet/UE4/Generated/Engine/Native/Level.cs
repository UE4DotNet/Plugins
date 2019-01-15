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
    [StructLayout( LayoutKind.Explicit, Size=1944 )]
    internal unsafe struct Level_fields {
        [FieldOffset(208)]  public IntPtr  OwningWorld;
        [FieldOffset(216)]  public IntPtr  Model;
        [FieldOffset(224)] public NativeArray ModelComponents;
        [FieldOffset(240)]  public IntPtr  ActorCluster;
        [FieldOffset(248)]  public IntPtr  LevelScriptBlueprint;
        [FieldOffset(256)] public NativeArray TextureStreamingResourceGuids;
        [FieldOffset(272)] public int NumTextureStreamingUnbuiltComponents;
        [FieldOffset(276)] public int NumTextureStreamingDirtyResources;
        [FieldOffset(280)]  public IntPtr  LevelScriptActor;
        [FieldOffset(288)]  public IntPtr  NavListStart;
        [FieldOffset(296)]  public IntPtr  NavListEnd;
        [FieldOffset(304)] public NativeArray NavDataChunks;
        [FieldOffset(320)] public float LightmapTotalSize;
        [FieldOffset(324)] public float ShadowmapTotalSize;
        [FieldOffset(328)] public NativeArray StaticNavigableGeometry;
        [FieldOffset(344)] public NativeArray StreamingTextureGuids;
        [FieldOffset(504)] public bool bIsLightingScenario;
        [FieldOffset(508)] public FGuid LevelBuildDataId;
        [FieldOffset(528)]  public IntPtr  MapBuildData;
        [FieldOffset(536)] public IntVector LightBuildLevelOffset;
        [FieldOffset(548)] public bool bTextureStreamingRotationChanged;
        [FieldOffset(548)] public bool bStaticComponentsRegisteredInStreamingManager;
        [FieldOffset(548)] public bool bIsVisible;
        [FieldOffset(548)] public bool bLocked;
        [FieldOffset(584)] public LevelSimplificationDetails LevelSimplification;
        [FieldOffset(1816)] public LinearColor LevelColor;
        [FieldOffset(1880)]  public IntPtr  WorldSettings;
        [FieldOffset(1896)] public NativeArray AssetUserData;
        [FieldOffset(1928)] public NativeArray DestroyedReplicatedStaticActors;
    }
    internal unsafe struct Level_methods {
    }
    internal unsafe struct Level_events {
    }
}
