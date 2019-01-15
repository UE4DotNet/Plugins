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
    [StructLayout( LayoutKind.Explicit, Size=264 )]
    internal unsafe struct CascadeOptions_fields {
        [FieldOffset(56)] public bool bShowModuleDump;
        [FieldOffset(60)] public Color BackgroundColor;
        [FieldOffset(64)] public bool bUseSubMenus;
        [FieldOffset(64)] public bool bUseSpaceBarReset;
        [FieldOffset(64)] public bool bUseSpaceBarResetInLevel;
        [FieldOffset(68)] public Color Empty_Background;
        [FieldOffset(72)] public Color Emitter_Background;
        [FieldOffset(76)] public Color Emitter_Unselected;
        [FieldOffset(80)] public Color Emitter_Selected;
        [FieldOffset(84)] public Color ModuleColor_General_Unselected;
        [FieldOffset(88)] public Color ModuleColor_General_Selected;
        [FieldOffset(92)] public Color ModuleColor_TypeData_Unselected;
        [FieldOffset(96)] public Color ModuleColor_TypeData_Selected;
        [FieldOffset(100)] public Color ModuleColor_Beam_Unselected;
        [FieldOffset(104)] public Color ModuleColor_Beam_Selected;
        [FieldOffset(108)] public Color ModuleColor_Trail_Unselected;
        [FieldOffset(112)] public Color ModuleColor_Trail_Selected;
        [FieldOffset(116)] public Color ModuleColor_Spawn_Unselected;
        [FieldOffset(120)] public Color ModuleColor_Spawn_Selected;
        [FieldOffset(124)] public Color ModuleColor_Light_Unselected;
        [FieldOffset(128)] public Color ModuleColor_Light_Selected;
        [FieldOffset(132)] public Color ModuleColor_SubUV_Unselected;
        [FieldOffset(136)] public Color ModuleColor_SubUV_Selected;
        [FieldOffset(140)] public Color ModuleColor_Required_Unselected;
        [FieldOffset(144)] public Color ModuleColor_Required_Selected;
        [FieldOffset(148)] public Color ModuleColor_Event_Unselected;
        [FieldOffset(152)] public Color ModuleColor_Event_Selected;
        [FieldOffset(156)] public bool bShowGrid;
        [FieldOffset(160)] public Color GridColor_Hi;
        [FieldOffset(164)] public Color GridColor_Low;
        [FieldOffset(168)] public float GridPerspectiveSize;
        [FieldOffset(172)] public bool bShowParticleCounts;
        [FieldOffset(172)] public bool bShowParticleEvents;
        [FieldOffset(172)] public bool bShowParticleTimes;
        [FieldOffset(172)] public bool bShowParticleDistance;
        [FieldOffset(172)] public bool bShowParticleMemory;
        [FieldOffset(176)] public float ParticleMemoryUpdateTime;
        [FieldOffset(180)] public bool bShowFloor;
        [FieldOffset(184)] byte FloorMesh; //TODO: string FString FloorMesh
        [FieldOffset(200)] public Vector FloorPosition;
        [FieldOffset(212)] public Rotator FloorRotation;
        [FieldOffset(224)] public float FloorScale;
        [FieldOffset(228)] public Vector FloorScale3D;
        [FieldOffset(240)] public int ShowPPFlags;
        [FieldOffset(244)] public bool bUseSlimCascadeDraw;
        [FieldOffset(248)] public int SlimCascadeDrawHeight;
        [FieldOffset(252)] public bool bCenterCascadeModuleText;
        [FieldOffset(256)] public int Cascade_MouseMoveThreshold;
        [FieldOffset(260)] public float MotionModeRadius;
    }
    internal unsafe struct CascadeOptions_methods {
    }
    internal unsafe struct CascadeOptions_events {
    }
}
