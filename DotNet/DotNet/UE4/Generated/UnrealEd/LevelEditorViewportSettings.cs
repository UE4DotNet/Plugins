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

#pragma warning disable CS0108
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Implements the Level Editor's view port settings.</summary>
    public unsafe partial class LevelEditorViewportSettings : UObject  {
        ///<summary>Enable the use of flight camera controls under various circumstances.</summary>
        public unsafe byte FlightCameraControlType {
            get {return LevelEditorViewportSettings_ptr->FlightCameraControlType;}
            set {LevelEditorViewportSettings_ptr->FlightCameraControlType = value;}
        }
         //TODO: enum ELandscapeFoliageEditorControlType LandscapeEditorControlType
         //TODO: enum ELandscapeFoliageEditorControlType FoliageEditorControlType
        public bool bPanMovesCanvas {
            get {return Main.GetGetBoolPropertyByName(this, "bPanMovesCanvas"); }
            set {Main.SetGetBoolPropertyByName(this, "bPanMovesCanvas", value); }
        }
        public bool bCenterZoomAroundCursor {
            get {return Main.GetGetBoolPropertyByName(this, "bCenterZoomAroundCursor"); }
            set {Main.SetGetBoolPropertyByName(this, "bCenterZoomAroundCursor", value); }
        }
        public bool bAllowTranslateRotateZWidget {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowTranslateRotateZWidget"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowTranslateRotateZWidget", value); }
        }
        public bool bClickBSPSelectsBrush {
            get {return Main.GetGetBoolPropertyByName(this, "bClickBSPSelectsBrush"); }
            set {Main.SetGetBoolPropertyByName(this, "bClickBSPSelectsBrush", value); }
        }
        ///<summary>How fast the perspective camera moves when flying through the world.</summary>
        public unsafe int CameraSpeed {
            get {return LevelEditorViewportSettings_ptr->CameraSpeed;}
            set {LevelEditorViewportSettings_ptr->CameraSpeed = value;}
        }
        ///<summary>Scalar applied to perspective camera movement to increase movement range.</summary>
        public unsafe float CameraSpeedScalar {
            get {return LevelEditorViewportSettings_ptr->CameraSpeedScalar;}
            set {LevelEditorViewportSettings_ptr->CameraSpeedScalar = value;}
        }
        ///<summary>How fast the perspective camera moves through the world when using mouse scroll.</summary>
        public unsafe int MouseScrollCameraSpeed {
            get {return LevelEditorViewportSettings_ptr->MouseScrollCameraSpeed;}
            set {LevelEditorViewportSettings_ptr->MouseScrollCameraSpeed = value;}
        }
        ///<summary>The sensitivity of mouse movement when rotating the camera.</summary>
        public unsafe float MouseSensitivty {
            get {return LevelEditorViewportSettings_ptr->MouseSensitivty;}
            set {LevelEditorViewportSettings_ptr->MouseSensitivty = value;}
        }
        public bool bInvertMouseLookYAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bInvertMouseLookYAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvertMouseLookYAxis", value); }
        }
        public bool bInvertOrbitYAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bInvertOrbitYAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvertOrbitYAxis", value); }
        }
        public bool bInvertMiddleMousePan {
            get {return Main.GetGetBoolPropertyByName(this, "bInvertMiddleMousePan"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvertMiddleMousePan", value); }
        }
        public bool bUseAbsoluteTranslation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAbsoluteTranslation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAbsoluteTranslation", value); }
        }
        public bool bLevelStreamingVolumePrevis {
            get {return Main.GetGetBoolPropertyByName(this, "bLevelStreamingVolumePrevis"); }
            set {Main.SetGetBoolPropertyByName(this, "bLevelStreamingVolumePrevis", value); }
        }
        public bool bUseUE3OrbitControls {
            get {return Main.GetGetBoolPropertyByName(this, "bUseUE3OrbitControls"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseUE3OrbitControls", value); }
        }
         //TODO: enum EScrollGestureDirection ScrollGestureDirectionFor3DViewports
         //TODO: enum EScrollGestureDirection ScrollGestureDirectionForOrthoViewports
        public bool bLevelEditorJoystickControls {
            get {return Main.GetGetBoolPropertyByName(this, "bLevelEditorJoystickControls"); }
            set {Main.SetGetBoolPropertyByName(this, "bLevelEditorJoystickControls", value); }
        }
        public bool bUsePowerOf2SnapSize {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePowerOf2SnapSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePowerOf2SnapSize", value); }
        }
         //TODO: array not UObject TArray DecimalGridSizes
         //TODO: array not UObject TArray DecimalGridIntervals
         //TODO: array not UObject TArray Pow2GridSizes
         //TODO: array not UObject TArray Pow2GridIntervals
         //TODO: array not UObject TArray CommonRotGridSizes
         //TODO: array not UObject TArray DivisionsOf360RotGridSizes
         //TODO: array not UObject TArray ScalingGridSizes
        public bool GridEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "GridEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "GridEnabled", value); }
        }
        public bool RotGridEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "RotGridEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "RotGridEnabled", value); }
        }
        public bool SnapScaleEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "SnapScaleEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "SnapScaleEnabled", value); }
        }
        ///<summary>If enabled, actors will snap to surfaces in the viewport when dragged around</summary>
        public unsafe SnapToSurfaceSettings SnapToSurface {
            get {return LevelEditorViewportSettings_ptr->SnapToSurface;}
            set {LevelEditorViewportSettings_ptr->SnapToSurface = value;}
        }
        public bool bUsePercentageBasedScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePercentageBasedScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePercentageBasedScaling", value); }
        }
        public bool bEnableLayerSnap {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLayerSnap"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLayerSnap", value); }
        }
        ///<summary>The index of the snap plane to use when bEnableLayerSnap is true (from the project SnapLayers array)</summary>
        public unsafe int ActiveSnapLayerIndex {
            get {return LevelEditorViewportSettings_ptr->ActiveSnapLayerIndex;}
            set {LevelEditorViewportSettings_ptr->ActiveSnapLayerIndex = value;}
        }
        public bool bEnableActorSnap {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableActorSnap"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableActorSnap", value); }
        }
        ///<summary>Global actor snap scale for the editor</summary>
        public unsafe float ActorSnapScale {
            get {return LevelEditorViewportSettings_ptr->ActorSnapScale;}
            set {LevelEditorViewportSettings_ptr->ActorSnapScale = value;}
        }
        ///<summary>Global actor snap distance setting for the editor</summary>
        public unsafe float ActorSnapDistance {
            get {return LevelEditorViewportSettings_ptr->ActorSnapDistance;}
            set {LevelEditorViewportSettings_ptr->ActorSnapDistance = value;}
        }
        public bool bSnapVertices {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapVertices"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapVertices", value); }
        }
        ///<summary>Snap Distance</summary>
        public unsafe float SnapDistance {
            get {return LevelEditorViewportSettings_ptr->SnapDistance;}
            set {LevelEditorViewportSettings_ptr->SnapDistance = value;}
        }
        ///<summary>Current Pos Grid Size</summary>
        public unsafe int CurrentPosGridSize {
            get {return LevelEditorViewportSettings_ptr->CurrentPosGridSize;}
            set {LevelEditorViewportSettings_ptr->CurrentPosGridSize = value;}
        }
        ///<summary>Current Rot Grid Size</summary>
        public unsafe int CurrentRotGridSize {
            get {return LevelEditorViewportSettings_ptr->CurrentRotGridSize;}
            set {LevelEditorViewportSettings_ptr->CurrentRotGridSize = value;}
        }
        ///<summary>Current Scaling Grid Size</summary>
        public unsafe int CurrentScalingGridSize {
            get {return LevelEditorViewportSettings_ptr->CurrentScalingGridSize;}
            set {LevelEditorViewportSettings_ptr->CurrentScalingGridSize = value;}
        }
        public bool PreserveNonUniformScale {
            get {return Main.GetGetBoolPropertyByName(this, "PreserveNonUniformScale"); }
            set {Main.SetGetBoolPropertyByName(this, "PreserveNonUniformScale", value); }
        }
        ///<summary>Controls which array of rotation grid values we are using</summary>
        public unsafe byte CurrentRotGridMode {
            get {return LevelEditorViewportSettings_ptr->CurrentRotGridMode;}
            set {LevelEditorViewportSettings_ptr->CurrentRotGridMode = value;}
        }
        ///<summary>How to constrain perspective view port FOV</summary>
        public unsafe byte AspectRatioAxisConstraint {
            get {return LevelEditorViewportSettings_ptr->AspectRatioAxisConstraint;}
            set {LevelEditorViewportSettings_ptr->AspectRatioAxisConstraint = value;}
        }
        public bool bEnableViewportHoverFeedback {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableViewportHoverFeedback"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableViewportHoverFeedback", value); }
        }
        public bool bHighlightWithBrackets {
            get {return Main.GetGetBoolPropertyByName(this, "bHighlightWithBrackets"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighlightWithBrackets", value); }
        }
        public bool bUseLinkedOrthographicViewports {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLinkedOrthographicViewports"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLinkedOrthographicViewports", value); }
        }
        public bool bStrictBoxSelection {
            get {return Main.GetGetBoolPropertyByName(this, "bStrictBoxSelection"); }
            set {Main.SetGetBoolPropertyByName(this, "bStrictBoxSelection", value); }
        }
        public bool bTransparentBoxSelection {
            get {return Main.GetGetBoolPropertyByName(this, "bTransparentBoxSelection"); }
            set {Main.SetGetBoolPropertyByName(this, "bTransparentBoxSelection", value); }
        }
        public bool bUseSelectionOutline {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSelectionOutline"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSelectionOutline", value); }
        }
        ///<summary>Sets the intensity of the overlay displayed when an object is selected</summary>
        public unsafe float SelectionHighlightIntensity {
            get {return LevelEditorViewportSettings_ptr->SelectionHighlightIntensity;}
            set {LevelEditorViewportSettings_ptr->SelectionHighlightIntensity = value;}
        }
        ///<summary>Sets the intensity of the overlay displayed when an object is selected</summary>
        public unsafe float BSPSelectionHighlightIntensity {
            get {return LevelEditorViewportSettings_ptr->BSPSelectionHighlightIntensity;}
            set {LevelEditorViewportSettings_ptr->BSPSelectionHighlightIntensity = value;}
        }
        ///<summary>Sets the intensity of the overlay displayed when an object is hovered</summary>
        public unsafe float HoverHighlightIntensity {
            get {return LevelEditorViewportSettings_ptr->HoverHighlightIntensity;}
            set {LevelEditorViewportSettings_ptr->HoverHighlightIntensity = value;}
        }
        public bool bEnableViewportCameraToUpdateFromPIV {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableViewportCameraToUpdateFromPIV"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableViewportCameraToUpdateFromPIV", value); }
        }
        public bool bPreviewSelectedCameras {
            get {return Main.GetGetBoolPropertyByName(this, "bPreviewSelectedCameras"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreviewSelectedCameras", value); }
        }
        ///<summary>Affects the size of 'picture in picture' previews if they are enabled</summary>
        public unsafe float CameraPreviewSize {
            get {return LevelEditorViewportSettings_ptr->CameraPreviewSize;}
            set {LevelEditorViewportSettings_ptr->CameraPreviewSize = value;}
        }
        ///<summary>Distance from the camera to place actors which are dropped on nothing in the view port.</summary>
        public unsafe float BackgroundDropDistance {
            get {return LevelEditorViewportSettings_ptr->BackgroundDropDistance;}
            set {LevelEditorViewportSettings_ptr->BackgroundDropDistance = value;}
        }
         //TODO: array not UObject TArray PreviewMeshes
        ///<summary>Billboard Scale</summary>
        public unsafe float BillboardScale {
            get {return LevelEditorViewportSettings_ptr->BillboardScale;}
            set {LevelEditorViewportSettings_ptr->BillboardScale = value;}
        }
        ///<summary>The size adjustment to apply to the translate/rotate/scale widgets (in Unreal units).</summary>
        public unsafe int TransformWidgetSizeAdjustment {
            get {return LevelEditorViewportSettings_ptr->TransformWidgetSizeAdjustment;}
            set {LevelEditorViewportSettings_ptr->TransformWidgetSizeAdjustment = value;}
        }
        public bool bSaveEngineStats {
            get {return Main.GetGetBoolPropertyByName(this, "bSaveEngineStats"); }
            set {Main.SetGetBoolPropertyByName(this, "bSaveEngineStats", value); }
        }
        ///<summary>Specify the units used by the measuring tool</summary>
        public unsafe byte MeasuringToolUnits {
            get {return LevelEditorViewportSettings_ptr->MeasuringToolUnits;}
            set {LevelEditorViewportSettings_ptr->MeasuringToolUnits = value;}
        }
         //TODO: array not UObject TArray PerInstanceSettings
        static LevelEditorViewportSettings() {
            StaticClass = Main.GetClass("LevelEditorViewportSettings");
        }
        internal unsafe LevelEditorViewportSettings_fields* LevelEditorViewportSettings_ptr => (LevelEditorViewportSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelEditorViewportSettings(IntPtr p) => UObject.Make<LevelEditorViewportSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelEditorViewportSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelEditorViewportSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
