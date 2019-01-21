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
    [StructLayout( LayoutKind.Explicit, Size=5808 )]
    internal unsafe struct EditorEngine_fields {
        [FieldOffset(4128)]  public IntPtr  TempModel;
        [FieldOffset(4136)]  public IntPtr  ConversionTempModel;
        [FieldOffset(4144)]  public IntPtr  Trans;
        [FieldOffset(4152)]  public IntPtr  Bad;
        [FieldOffset(4160)]  public IntPtr  EditorFont;
        [FieldOffset(4168)]  public IntPtr  PreviewSoundCue;
        [FieldOffset(4176)]  public IntPtr  PreviewAudioComponent;
        [FieldOffset(4184)]  public IntPtr  EditorCube;
        [FieldOffset(4192)]  public IntPtr  EditorSphere;
        [FieldOffset(4200)]  public IntPtr  EditorPlane;
        [FieldOffset(4208)]  public IntPtr  EditorCylinder;
        [FieldOffset(4216)] public bool bFastRebuild;
        [FieldOffset(4216)] public bool IsImportingT3D;
        [FieldOffset(4220)] byte ClickFlags; //TODO: numeric uint32 ClickFlags
        [FieldOffset(4224)]  public IntPtr  ParentContext;
        [FieldOffset(4232)] public Vector UnsnappedClickLocation;
        [FieldOffset(4244)] public Vector ClickLocation;
        [FieldOffset(4256)] public Plane ClickPlane;
        [FieldOffset(4272)] public Vector MouseMovement;
        [FieldOffset(4284)] public byte DetailMode;
        [FieldOffset(4288)] public bool UseSizingBox;
        [FieldOffset(4288)] public bool UseAxisIndicator;
        [FieldOffset(4288)] public bool GodMode;
        [FieldOffset(4296)] byte GameCommandLine; //TODO: string FString GameCommandLine
        [FieldOffset(4312)] public bool bShowBrushMarkerPolys;
        [FieldOffset(4312)] public bool bEnableSocketSnapping;
        [FieldOffset(4312)] public bool bEnableLODLocking;
        [FieldOffset(4320)] byte HeightMapExportClassName; //TODO: string FString HeightMapExportClassName
        [FieldOffset(4336)] public NativeArray ActorFactories;
        [FieldOffset(4352)] byte UserOpenedFile; //TODO: string FString UserOpenedFile
        [FieldOffset(4368)] byte InEditorGameURLOptions; //TODO: string FString InEditorGameURLOptions
        [FieldOffset(4384)]  public IntPtr  PlayWorld;
        [FieldOffset(4392)] public Vector PlayWorldLocation;
        [FieldOffset(4404)] public Rotator PlayWorldRotation;
        [FieldOffset(4416)] public bool bIsPlayWorldQueued;
        [FieldOffset(4416)] public bool bIsToggleBetweenPIEandSIEQueued;
        [FieldOffset(4416)] public bool bIsSimulateInEditorQueued;
        [FieldOffset(4416)] public bool bAllowMultiplePIEWorlds;
        [FieldOffset(4416)] public bool bRequestEndPlayMapQueued;
        [FieldOffset(4416)] public bool bHasPlayWorldPlacement;
        [FieldOffset(4416)] public bool bUseMobilePreviewForPlayWorld;
        [FieldOffset(4416)] public bool bUseVRPreviewForPlayWorld;
        [FieldOffset(4417)] public bool bIsSimulatingInEditor;
        [FieldOffset(4417)] public bool bSquelchTransactionNotification;
        [FieldOffset(4417)] public bool bNotifyUndoRedoSelectionChange;
        [FieldOffset(4424)] public IntPtr PlayFromHerePlayerStartClass;
        [FieldOffset(4432)]  public IntPtr  EditorWorld;
        [FieldOffset(4440)] public NativeArray ActorsThatWereSelected;
        [FieldOffset(4456)] public int PlayWorldDestination;
        [FieldOffset(4460)] public int CurrentPlayWorldDestination;
        [FieldOffset(4464)] public bool bMobilePreviewPortrait;
        [FieldOffset(4468)] public int BuildPlayDevice;
        [FieldOffset(4568)] public int PlayInEditorViewportIndex;
        [FieldOffset(4576)] byte UserEditedPlayWorldURL; //TODO: string FString UserEditedPlayWorldURL
        [FieldOffset(4592)]  public IntPtr  ScratchRenderTarget2048;
        [FieldOffset(4600)]  public IntPtr  ScratchRenderTarget1024;
        [FieldOffset(4608)]  public IntPtr  ScratchRenderTarget512;
        [FieldOffset(4616)]  public IntPtr  ScratchRenderTarget256;
        [FieldOffset(4624)]  public IntPtr  PreviewMeshComp;
        [FieldOffset(4632)] public int PreviewMeshIndex;
        [FieldOffset(4636)] public bool bShowPreviewMesh;
        [FieldOffset(4636)] public bool bCustomCameraAlignEmitter;
        [FieldOffset(4640)] public float CustomCameraAlignEmitterDistance;
        [FieldOffset(4644)] public bool bDrawSocketsInGMode;
        [FieldOffset(4644)] public bool bDrawParticleHelpers;
        [FieldOffset(4648)] public NativeArray BrushBuilders;
        [FieldOffset(4680)]  public IntPtr  EditorWorldExtensionsManager;
        [FieldOffset(5744)] public SoftClassPath ActorGroupingUtilsClassName;
        [FieldOffset(5776)]  public IntPtr  ActorGroupingUtils;
    }
    internal unsafe struct EditorEngine_methods {
    }
    internal unsafe struct EditorEngine_events {
    }
}
