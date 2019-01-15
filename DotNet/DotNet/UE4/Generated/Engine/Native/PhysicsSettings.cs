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
    [StructLayout( LayoutKind.Explicit, Size=288 )]
    internal unsafe struct PhysicsSettings_fields {
        [FieldOffset(80)] public float DefaultGravityZ;
        [FieldOffset(84)] public float DefaultTerminalVelocity;
        [FieldOffset(88)] public float DefaultFluidFriction;
        [FieldOffset(92)] public int SimulateScratchMemorySize;
        [FieldOffset(96)] public int RagdollAggregateThreshold;
        [FieldOffset(100)] public float TriangleMeshTriangleMinAreaThreshold;
        [FieldOffset(104)] public bool bEnableAsyncScene;
        [FieldOffset(105)] public bool bEnableShapeSharing;
        [FieldOffset(106)] public bool bEnablePCM;
        [FieldOffset(107)] public bool bEnableStabilization;
        [FieldOffset(108)] public bool bWarnMissingLocks;
        [FieldOffset(109)] public bool bEnable2DPhysics;
        [FieldOffset(112)] public RigidBodyErrorCorrection PhysicErrorCorrection;
        [FieldOffset(157)] public byte DefaultDegreesOfFreedom;
        [FieldOffset(160)] public float BounceThresholdVelocity;
        [FieldOffset(164)] public byte FrictionCombineMode;
        [FieldOffset(165)] public byte RestitutionCombineMode;
        [FieldOffset(168)] public float MaxAngularVelocity;
        [FieldOffset(172)] public float MaxDepenetrationVelocity;
        [FieldOffset(176)] public float ContactOffsetMultiplier;
        [FieldOffset(180)] public float MinContactOffset;
        [FieldOffset(184)] public float MaxContactOffset;
        [FieldOffset(188)] public bool bSimulateSkeletalMeshOnDedicatedServer;
        [FieldOffset(189)] public byte DefaultShapeComplexity;
        [FieldOffset(191)] public bool bSuppressFaceRemapTable;
        [FieldOffset(192)] public bool bSupportUVFromHitResults;
        [FieldOffset(193)] public bool bDisableActiveActors;
        [FieldOffset(194)] public bool bDisableKinematicStaticPairs;
        [FieldOffset(195)] public bool bDisableKinematicKinematicPairs;
        [FieldOffset(196)] public bool bDisableCCD;
        [FieldOffset(197)] public bool bEnableEnhancedDeterminism;
        [FieldOffset(200)] public float MaxPhysicsDeltaTime;
        [FieldOffset(204)] public bool bSubstepping;
        [FieldOffset(205)] public bool bSubsteppingAsync;
        [FieldOffset(208)] public float MaxSubstepDeltaTime;
        [FieldOffset(212)] public int MaxSubsteps;
        [FieldOffset(216)] public float SyncSceneSmoothingFactor;
        [FieldOffset(220)] public float AsyncSceneSmoothingFactor;
        [FieldOffset(224)] public float InitialAverageFrameRate;
        [FieldOffset(228)] public int PhysXTreeRebuildRate;
        [FieldOffset(232)] public NativeArray PhysicalSurfaces;
        [FieldOffset(248)] public BroadphaseSettings DefaultBroadphaseSettings;
    }
    internal unsafe struct PhysicsSettings_methods {
    }
    internal unsafe struct PhysicsSettings_events {
    }
}
