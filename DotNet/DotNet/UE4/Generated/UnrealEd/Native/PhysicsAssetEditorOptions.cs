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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct PhysicsAssetEditorOptions_fields {
        [FieldOffset(56)] public float PhysicsBlend;
        [FieldOffset(60)] public bool bUpdateJointsFromAnimation;
        [FieldOffset(61)] public byte PhysicsUpdateMode;
        [FieldOffset(64)] public float PokePauseTime;
        [FieldOffset(68)] public float PokeBlendTime;
        [FieldOffset(72)] public float GravScale;
        [FieldOffset(76)] public int MaxFPS;
        [FieldOffset(80)] public float HandleLinearDamping;
        [FieldOffset(84)] public float HandleLinearStiffness;
        [FieldOffset(88)] public float HandleAngularDamping;
        [FieldOffset(92)] public float HandleAngularStiffness;
        [FieldOffset(96)] public float InterpolationSpeed;
        [FieldOffset(100)] public float PokeStrength;
        [FieldOffset(104)] public bool bShowConstraintsAsPoints;
        [FieldOffset(104)] public bool bRenderOnlySelectedConstraints;
        [FieldOffset(108)] public float ConstraintDrawSize;
        [FieldOffset(112)] byte MeshViewMode; //TODO: enum EPhysicsAssetEditorRenderMode MeshViewMode
        [FieldOffset(113)] byte CollisionViewMode; //TODO: enum EPhysicsAssetEditorRenderMode CollisionViewMode
        [FieldOffset(114)] byte ConstraintViewMode; //TODO: enum EPhysicsAssetEditorConstraintViewMode ConstraintViewMode
        [FieldOffset(115)] byte SimulationMeshViewMode; //TODO: enum EPhysicsAssetEditorRenderMode SimulationMeshViewMode
        [FieldOffset(116)] byte SimulationCollisionViewMode; //TODO: enum EPhysicsAssetEditorRenderMode SimulationCollisionViewMode
        [FieldOffset(117)] byte SimulationConstraintViewMode; //TODO: enum EPhysicsAssetEditorConstraintViewMode SimulationConstraintViewMode
        [FieldOffset(120)] public float CollisionOpacity;
        [FieldOffset(124)] public bool bSolidRenderingForSelectedOnly;
        [FieldOffset(125)] public bool bResetClothWhenSimulating;
    }
    internal unsafe struct PhysicsAssetEditorOptions_methods {
    }
    internal unsafe struct PhysicsAssetEditorOptions_events {
    }
}
