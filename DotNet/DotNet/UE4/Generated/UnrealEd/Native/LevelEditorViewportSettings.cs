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
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct LevelEditorViewportSettings_fields {
        [FieldOffset(56)] public byte FlightCameraControlType;
        [FieldOffset(57)] byte LandscapeEditorControlType; //TODO: enum ELandscapeFoliageEditorControlType LandscapeEditorControlType
        [FieldOffset(58)] byte FoliageEditorControlType; //TODO: enum ELandscapeFoliageEditorControlType FoliageEditorControlType
        [FieldOffset(60)] public bool bPanMovesCanvas;
        [FieldOffset(60)] public bool bCenterZoomAroundCursor;
        [FieldOffset(60)] public bool bAllowTranslateRotateZWidget;
        [FieldOffset(60)] public bool bClickBSPSelectsBrush;
        [FieldOffset(64)] public int CameraSpeed;
        [FieldOffset(68)] public float CameraSpeedScalar;
        [FieldOffset(72)] public int MouseScrollCameraSpeed;
        [FieldOffset(76)] public float MouseSensitivty;
        [FieldOffset(80)] public bool bInvertMouseLookYAxis;
        [FieldOffset(81)] public bool bInvertOrbitYAxis;
        [FieldOffset(82)] public bool bInvertMiddleMousePan;
        [FieldOffset(84)] public bool bUseAbsoluteTranslation;
        [FieldOffset(88)] public bool bLevelStreamingVolumePrevis;
        [FieldOffset(89)] public bool bUseUE3OrbitControls;
        [FieldOffset(90)] byte ScrollGestureDirectionFor3DViewports; //TODO: enum EScrollGestureDirection ScrollGestureDirectionFor3DViewports
        [FieldOffset(91)] byte ScrollGestureDirectionForOrthoViewports; //TODO: enum EScrollGestureDirection ScrollGestureDirectionForOrthoViewports
        [FieldOffset(92)] public bool bLevelEditorJoystickControls;
        [FieldOffset(93)] public bool bUsePowerOf2SnapSize;
        [FieldOffset(96)] public NativeArray DecimalGridSizes;
        [FieldOffset(112)] public NativeArray DecimalGridIntervals;
        [FieldOffset(128)] public NativeArray Pow2GridSizes;
        [FieldOffset(144)] public NativeArray Pow2GridIntervals;
        [FieldOffset(160)] public NativeArray CommonRotGridSizes;
        [FieldOffset(176)] public NativeArray DivisionsOf360RotGridSizes;
        [FieldOffset(192)] public NativeArray ScalingGridSizes;
        [FieldOffset(208)] public bool GridEnabled;
        [FieldOffset(208)] public bool RotGridEnabled;
        [FieldOffset(208)] public bool SnapScaleEnabled;
        [FieldOffset(212)] public SnapToSurfaceSettings SnapToSurface;
        [FieldOffset(224)] public bool bUsePercentageBasedScaling;
        [FieldOffset(224)] public bool bEnableLayerSnap;
        [FieldOffset(228)] public int ActiveSnapLayerIndex;
        [FieldOffset(232)] public bool bEnableActorSnap;
        [FieldOffset(236)] public float ActorSnapScale;
        [FieldOffset(240)] public float ActorSnapDistance;
        [FieldOffset(244)] public bool bSnapVertices;
        [FieldOffset(248)] public float SnapDistance;
        [FieldOffset(252)] public int CurrentPosGridSize;
        [FieldOffset(256)] public int CurrentRotGridSize;
        [FieldOffset(260)] public int CurrentScalingGridSize;
        [FieldOffset(264)] public bool PreserveNonUniformScale;
        [FieldOffset(265)] public byte CurrentRotGridMode;
        [FieldOffset(266)] public byte AspectRatioAxisConstraint;
        [FieldOffset(268)] public bool bEnableViewportHoverFeedback;
        [FieldOffset(268)] public bool bHighlightWithBrackets;
        [FieldOffset(268)] public bool bUseLinkedOrthographicViewports;
        [FieldOffset(268)] public bool bStrictBoxSelection;
        [FieldOffset(268)] public bool bTransparentBoxSelection;
        [FieldOffset(268)] public bool bUseSelectionOutline;
        [FieldOffset(272)] public float SelectionHighlightIntensity;
        [FieldOffset(276)] public float BSPSelectionHighlightIntensity;
        [FieldOffset(280)] public float HoverHighlightIntensity;
        [FieldOffset(284)] public bool bEnableViewportCameraToUpdateFromPIV;
        [FieldOffset(284)] public bool bPreviewSelectedCameras;
        [FieldOffset(288)] public float CameraPreviewSize;
        [FieldOffset(292)] public float BackgroundDropDistance;
        [FieldOffset(296)] public NativeArray PreviewMeshes;
        [FieldOffset(312)] public float BillboardScale;
        [FieldOffset(316)] public int TransformWidgetSizeAdjustment;
        [FieldOffset(320)] public bool bSaveEngineStats;
        [FieldOffset(324)] public byte MeasuringToolUnits;
        [FieldOffset(328)] public NativeArray PerInstanceSettings;
    }
    internal unsafe struct LevelEditorViewportSettings_methods {
    }
    internal unsafe struct LevelEditorViewportSettings_events {
    }
}
