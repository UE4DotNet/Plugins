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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct PhysicsAssetEditorOptions_fields {
        [FieldOffset(56)] public float PhysicsBlend;
        [FieldOffset(60)] public bool bUpdateJointsFromAnimation;
        [FieldOffset(61)] public byte PhysicsUpdateMode;
        [FieldOffset(64)] public float PokePauseTime;
        [FieldOffset(68)] public float PokeBlendTime;
        [FieldOffset(72)] public float GravScale;
        [FieldOffset(76)] public float GravityOverrideZ;
        [FieldOffset(80)] public bool bUseGravityOverride;
        [FieldOffset(84)] public int MaxFPS;
        [FieldOffset(88)] public float HandleLinearDamping;
        [FieldOffset(92)] public float HandleLinearStiffness;
        [FieldOffset(96)] public float HandleAngularDamping;
        [FieldOffset(100)] public float HandleAngularStiffness;
        [FieldOffset(104)] public float InterpolationSpeed;
        [FieldOffset(108)] public float PokeStrength;
        [FieldOffset(112)] public bool bShowConstraintsAsPoints;
        [FieldOffset(112)] public bool bRenderOnlySelectedConstraints;
        [FieldOffset(116)] public float ConstraintDrawSize;
        [FieldOffset(120)] byte MeshViewMode; //TODO: enum EPhysicsAssetEditorRenderMode MeshViewMode
        [FieldOffset(121)] byte CollisionViewMode; //TODO: enum EPhysicsAssetEditorRenderMode CollisionViewMode
        [FieldOffset(122)] byte ConstraintViewMode; //TODO: enum EPhysicsAssetEditorConstraintViewMode ConstraintViewMode
        [FieldOffset(123)] byte SimulationMeshViewMode; //TODO: enum EPhysicsAssetEditorRenderMode SimulationMeshViewMode
        [FieldOffset(124)] byte SimulationCollisionViewMode; //TODO: enum EPhysicsAssetEditorRenderMode SimulationCollisionViewMode
        [FieldOffset(125)] byte SimulationConstraintViewMode; //TODO: enum EPhysicsAssetEditorConstraintViewMode SimulationConstraintViewMode
        [FieldOffset(128)] public float CollisionOpacity;
        [FieldOffset(132)] public bool bSolidRenderingForSelectedOnly;
        [FieldOffset(133)] public bool bResetClothWhenSimulating;
    }
    internal unsafe struct PhysicsAssetEditorOptions_methods {
    }
    internal unsafe struct PhysicsAssetEditorOptions_events {
    }
}
