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
    [StructLayout( LayoutKind.Explicit, Size=5680 )]
    internal unsafe struct EditorEngine_fields {
        [FieldOffset(4048)]  public IntPtr  TempModel;
        [FieldOffset(4056)]  public IntPtr  ConversionTempModel;
        [FieldOffset(4064)]  public IntPtr  Trans;
        [FieldOffset(4072)]  public IntPtr  Bad;
        [FieldOffset(4080)]  public IntPtr  EditorFont;
        [FieldOffset(4088)]  public IntPtr  PreviewSoundCue;
        [FieldOffset(4096)]  public IntPtr  PreviewAudioComponent;
        [FieldOffset(4104)]  public IntPtr  EditorCube;
        [FieldOffset(4112)]  public IntPtr  EditorSphere;
        [FieldOffset(4120)]  public IntPtr  EditorPlane;
        [FieldOffset(4128)]  public IntPtr  EditorCylinder;
        [FieldOffset(4136)] public bool bFastRebuild;
        [FieldOffset(4136)] public bool IsImportingT3D;
        [FieldOffset(4140)] byte ClickFlags; //TODO: numeric uint32 ClickFlags
        [FieldOffset(4144)]  public IntPtr  ParentContext;
        [FieldOffset(4152)] public Vector UnsnappedClickLocation;
        [FieldOffset(4164)] public Vector ClickLocation;
        [FieldOffset(4176)] public Plane ClickPlane;
        [FieldOffset(4192)] public Vector MouseMovement;
        [FieldOffset(4204)] public byte DetailMode;
        [FieldOffset(4208)] public bool UseSizingBox;
        [FieldOffset(4208)] public bool UseAxisIndicator;
        [FieldOffset(4208)] public bool GodMode;
        [FieldOffset(4216)] byte GameCommandLine; //TODO: string FString GameCommandLine
        [FieldOffset(4232)] public bool bShowBrushMarkerPolys;
        [FieldOffset(4232)] public bool bEnableSocketSnapping;
        [FieldOffset(4232)] public bool bEnableLODLocking;
        [FieldOffset(4240)] byte HeightMapExportClassName; //TODO: string FString HeightMapExportClassName
        [FieldOffset(4256)] public NativeArray ActorFactories;
        [FieldOffset(4272)] byte UserOpenedFile; //TODO: string FString UserOpenedFile
        [FieldOffset(4288)] byte InEditorGameURLOptions; //TODO: string FString InEditorGameURLOptions
        [FieldOffset(4304)]  public IntPtr  PlayWorld;
        [FieldOffset(4312)] public Vector PlayWorldLocation;
        [FieldOffset(4324)] public Rotator PlayWorldRotation;
        [FieldOffset(4336)] public bool bIsPlayWorldQueued;
        [FieldOffset(4336)] public bool bIsToggleBetweenPIEandSIEQueued;
        [FieldOffset(4336)] public bool bIsSimulateInEditorQueued;
        [FieldOffset(4336)] public bool bAllowMultiplePIEWorlds;
        [FieldOffset(4336)] public bool bRequestEndPlayMapQueued;
        [FieldOffset(4336)] public bool bHasPlayWorldPlacement;
        [FieldOffset(4336)] public bool bUseMobilePreviewForPlayWorld;
        [FieldOffset(4336)] public bool bUseVRPreviewForPlayWorld;
        [FieldOffset(4337)] public bool bIsSimulatingInEditor;
        [FieldOffset(4337)] public bool bSquelchTransactionNotification;
        [FieldOffset(4344)] public IntPtr PlayFromHerePlayerStartClass;
        [FieldOffset(4352)]  public IntPtr  EditorWorld;
        [FieldOffset(4360)] public NativeArray ActorsThatWereSelected;
        [FieldOffset(4376)] public int PlayWorldDestination;
        [FieldOffset(4380)] public int CurrentPlayWorldDestination;
        [FieldOffset(4384)] public bool bMobilePreviewPortrait;
        [FieldOffset(4388)] public int BuildPlayDevice;
        [FieldOffset(4488)] public int PlayInEditorViewportIndex;
        [FieldOffset(4496)] byte UserEditedPlayWorldURL; //TODO: string FString UserEditedPlayWorldURL
        [FieldOffset(4512)]  public IntPtr  ScratchRenderTarget2048;
        [FieldOffset(4520)]  public IntPtr  ScratchRenderTarget1024;
        [FieldOffset(4528)]  public IntPtr  ScratchRenderTarget512;
        [FieldOffset(4536)]  public IntPtr  ScratchRenderTarget256;
        [FieldOffset(4544)]  public IntPtr  PreviewMeshComp;
        [FieldOffset(4552)] public int PreviewMeshIndex;
        [FieldOffset(4556)] public bool bShowPreviewMesh;
        [FieldOffset(4556)] public bool bCustomCameraAlignEmitter;
        [FieldOffset(4560)] public float CustomCameraAlignEmitterDistance;
        [FieldOffset(4564)] public bool bDrawSocketsInGMode;
        [FieldOffset(4564)] public bool bDrawParticleHelpers;
        [FieldOffset(4568)] public NativeArray BrushBuilders;
        [FieldOffset(4600)]  public IntPtr  EditorWorldExtensionsManager;
        [FieldOffset(5624)] public SoftClassPath ActorGroupingUtilsClassName;
        [FieldOffset(5656)]  public IntPtr  ActorGroupingUtils;
    }
    internal unsafe struct EditorEngine_methods {
    }
    internal unsafe struct EditorEngine_events {
    }
}
