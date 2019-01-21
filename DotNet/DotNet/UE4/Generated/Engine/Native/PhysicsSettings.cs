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
    [StructLayout( LayoutKind.Explicit, Size=296 )]
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
        [FieldOffset(165)] public byte DefaultDegreesOfFreedom;
        [FieldOffset(168)] public float BounceThresholdVelocity;
        [FieldOffset(172)] public byte FrictionCombineMode;
        [FieldOffset(173)] public byte RestitutionCombineMode;
        [FieldOffset(176)] public float MaxAngularVelocity;
        [FieldOffset(180)] public float MaxDepenetrationVelocity;
        [FieldOffset(184)] public float ContactOffsetMultiplier;
        [FieldOffset(188)] public float MinContactOffset;
        [FieldOffset(192)] public float MaxContactOffset;
        [FieldOffset(196)] public bool bSimulateSkeletalMeshOnDedicatedServer;
        [FieldOffset(197)] public byte DefaultShapeComplexity;
        [FieldOffset(199)] public bool bSuppressFaceRemapTable;
        [FieldOffset(200)] public bool bSupportUVFromHitResults;
        [FieldOffset(201)] public bool bDisableActiveActors;
        [FieldOffset(202)] public bool bDisableKinematicStaticPairs;
        [FieldOffset(203)] public bool bDisableKinematicKinematicPairs;
        [FieldOffset(204)] public bool bDisableCCD;
        [FieldOffset(205)] public bool bEnableEnhancedDeterminism;
        [FieldOffset(208)] public float MaxPhysicsDeltaTime;
        [FieldOffset(212)] public bool bSubstepping;
        [FieldOffset(213)] public bool bSubsteppingAsync;
        [FieldOffset(216)] public float MaxSubstepDeltaTime;
        [FieldOffset(220)] public int MaxSubsteps;
        [FieldOffset(224)] public float SyncSceneSmoothingFactor;
        [FieldOffset(228)] public float AsyncSceneSmoothingFactor;
        [FieldOffset(232)] public float InitialAverageFrameRate;
        [FieldOffset(236)] public int PhysXTreeRebuildRate;
        [FieldOffset(240)] public NativeArray PhysicalSurfaces;
        [FieldOffset(256)] public BroadphaseSettings DefaultBroadphaseSettings;
    }
    internal unsafe struct PhysicsSettings_methods {
    }
    internal unsafe struct PhysicsSettings_events {
    }
}
