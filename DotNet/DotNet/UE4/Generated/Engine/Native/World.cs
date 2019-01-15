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
    [StructLayout( LayoutKind.Explicit, Size=2384 )]
    internal unsafe struct World_fields {
        [FieldOffset(64)] public NativeArray Layers;
        [FieldOffset(80)] public NativeArray ActiveGroupActors;
        [FieldOffset(96)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(104)]  public IntPtr  PersistentLevel;
        [FieldOffset(112)]  public IntPtr  NetDriver;
        [FieldOffset(120)]  public IntPtr  LineBatcher;
        [FieldOffset(128)]  public IntPtr  PersistentLineBatcher;
        [FieldOffset(136)]  public IntPtr  ForegroundLineBatcher;
        [FieldOffset(144)]  public IntPtr  NetworkManager;
        [FieldOffset(152)]  public IntPtr  PhysicsCollisionHandler;
        [FieldOffset(160)] public NativeArray ExtraReferencedObjects;
        [FieldOffset(176)] public NativeArray PerModuleDataObjects;
        [FieldOffset(192)] public NativeArray StreamingLevels;
        [FieldOffset(208)] byte StreamingLevelsToConsider; //TODO: set TSet StreamingLevelsToConsider
        [FieldOffset(288)] byte StreamingLevelsPrefix; //TODO: string FString StreamingLevelsPrefix
        [FieldOffset(304)]  public IntPtr  CurrentLevelPendingVisibility;
        [FieldOffset(312)]  public IntPtr  CurrentLevelPendingInvisibility;
        [FieldOffset(320)]  public IntPtr  DemoNetDriver;
        [FieldOffset(328)]  public IntPtr  MyParticleEventManager;
        [FieldOffset(336)]  public IntPtr  DefaultPhysicsVolume;
        [FieldOffset(368)]  public IntPtr  NavigationSystem;
        [FieldOffset(376)]  public IntPtr  AuthorityGameMode;
        [FieldOffset(384)]  public IntPtr  GameState;
        [FieldOffset(392)]  public IntPtr  AISystem;
        [FieldOffset(400)]  public IntPtr  AvoidanceManager;
        [FieldOffset(408)] public NativeArray Levels;
        [FieldOffset(424)] public NativeArray LevelCollections;
        [FieldOffset(456)]  public IntPtr  CurrentLevel;
        [FieldOffset(464)]  public IntPtr  OwningGameInstance;
        [FieldOffset(472)] public NativeArray ParameterCollectionInstances;
        [FieldOffset(488)]  public IntPtr  CanvasForRenderingToTarget;
        [FieldOffset(496)]  public IntPtr  CanvasForDrawMaterialToRenderTarget;
        [FieldOffset(520)] public NativeArray EditorViews;
        [FieldOffset(1480)] public NativeArray SelectedLevels;
        [FieldOffset(2160)]  public IntPtr  WorldComposition;
        [FieldOffset(2246)] public bool bAreConstraintsDirty;
        [FieldOffset(2296)] public WorldPSCPool PSCPool;
    }
    internal unsafe struct World_methods {
    }
    internal unsafe struct World_events {
    }
}
