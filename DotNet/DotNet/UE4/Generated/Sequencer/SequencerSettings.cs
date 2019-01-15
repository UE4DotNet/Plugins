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
using UE4.Sequencer.Native;

namespace UE4.Sequencer {
    ///<summary>Serializable options for sequencer.</summary>
    public unsafe partial class SequencerSettings : UObject  {
         //TODO: enum EAutoChangeMode AutoChangeMode
         //TODO: enum EAllowEditsMode AllowEditsMode
         //TODO: enum EKeyGroupMode KeyGroupMode
        public bool bKeyInterpPropertiesOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bKeyInterpPropertiesOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bKeyInterpPropertiesOnly", value); }
        }
         //TODO: enum EMovieSceneKeyInterpolation KeyInterpolation
        public bool bAutoSetTrackDefaults {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSetTrackDefaults"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoSetTrackDefaults", value); }
        }
        ///<summary>The default location of a spawnable when it is first dragged into the viewport from the content browser.</summary>
        public unsafe byte SpawnPosition {
            get {return SequencerSettings_ptr->SpawnPosition;}
            set {SequencerSettings_ptr->SpawnPosition = value;}
        }
        public bool bCreateSpawnableCameras {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateSpawnableCameras"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateSpawnableCameras", value); }
        }
        public bool bShowRangeSlider {
            get {return Main.GetGetBoolPropertyByName(this, "bShowRangeSlider"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowRangeSlider", value); }
        }
        public bool bIsSnapEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSnapEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSnapEnabled", value); }
        }
        public bool bSnapKeyTimesToInterval {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapKeyTimesToInterval"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapKeyTimesToInterval", value); }
        }
        public bool bSnapKeyTimesToKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapKeyTimesToKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapKeyTimesToKeys", value); }
        }
        public bool bSnapSectionTimesToInterval {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapSectionTimesToInterval"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapSectionTimesToInterval", value); }
        }
        public bool bSnapSectionTimesToSections {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapSectionTimesToSections"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapSectionTimesToSections", value); }
        }
        public bool bSnapPlayTimeToKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapPlayTimeToKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapPlayTimeToKeys", value); }
        }
        public bool bSnapPlayTimeToInterval {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapPlayTimeToInterval"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapPlayTimeToInterval", value); }
        }
        public bool bSnapPlayTimeToPressedKey {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapPlayTimeToPressedKey"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapPlayTimeToPressedKey", value); }
        }
        public bool bSnapPlayTimeToDraggedKey {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapPlayTimeToDraggedKey"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapPlayTimeToDraggedKey", value); }
        }
        public bool bSnapCurveValueToInterval {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapCurveValueToInterval"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapCurveValueToInterval", value); }
        }
        public bool bLabelBrowserVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bLabelBrowserVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bLabelBrowserVisible", value); }
        }
        public bool bShowSelectedNodesOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bShowSelectedNodesOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowSelectedNodesOnly", value); }
        }
        public bool bRewindOnRecord {
            get {return Main.GetGetBoolPropertyByName(this, "bRewindOnRecord"); }
            set {Main.SetGetBoolPropertyByName(this, "bRewindOnRecord", value); }
        }
        ///<summary>Whether to zoom in on the current position or the current time in the timeline.</summary>
        public unsafe byte ZoomPosition {
            get {return SequencerSettings_ptr->ZoomPosition;}
            set {SequencerSettings_ptr->ZoomPosition = value;}
        }
        public bool bAutoScrollEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoScrollEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoScrollEnabled", value); }
        }
        public bool bLinkCurveEditorTimeRange {
            get {return Main.GetGetBoolPropertyByName(this, "bLinkCurveEditorTimeRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bLinkCurveEditorTimeRange", value); }
        }
        ///<summary>The loop mode of the playback in timeline.</summary>
        public unsafe byte LoopMode {
            get {return SequencerSettings_ptr->LoopMode;}
            set {SequencerSettings_ptr->LoopMode = value;}
        }
        public bool bKeepCursorInPlayRangeWhileScrubbing {
            get {return Main.GetGetBoolPropertyByName(this, "bKeepCursorInPlayRangeWhileScrubbing"); }
            set {Main.SetGetBoolPropertyByName(this, "bKeepCursorInPlayRangeWhileScrubbing", value); }
        }
        public bool bKeepCursorInPlayRange {
            get {return Main.GetGetBoolPropertyByName(this, "bKeepCursorInPlayRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bKeepCursorInPlayRange", value); }
        }
        public bool bKeepPlayRangeInSectionBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bKeepPlayRangeInSectionBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bKeepPlayRangeInSectionBounds", value); }
        }
        ///<summary>The number of zeros to pad the frame numbers by.</summary>
        public unsafe byte ZeroPadFrames {
            get {return SequencerSettings_ptr->ZeroPadFrames;}
            set {SequencerSettings_ptr->ZeroPadFrames = value;}
        }
        public bool bShowCombinedKeyframes {
            get {return Main.GetGetBoolPropertyByName(this, "bShowCombinedKeyframes"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowCombinedKeyframes", value); }
        }
        public bool bInfiniteKeyAreas {
            get {return Main.GetGetBoolPropertyByName(this, "bInfiniteKeyAreas"); }
            set {Main.SetGetBoolPropertyByName(this, "bInfiniteKeyAreas", value); }
        }
        public bool bShowChannelColors {
            get {return Main.GetGetBoolPropertyByName(this, "bShowChannelColors"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowChannelColors", value); }
        }
        public bool bShowViewportTransportControls {
            get {return Main.GetGetBoolPropertyByName(this, "bShowViewportTransportControls"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowViewportTransportControls", value); }
        }
        public bool bAllowPossessionOfPIEViewports {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPossessionOfPIEViewports"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPossessionOfPIEViewports", value); }
        }
        public bool bActivateRealtimeViewports {
            get {return Main.GetGetBoolPropertyByName(this, "bActivateRealtimeViewports"); }
            set {Main.SetGetBoolPropertyByName(this, "bActivateRealtimeViewports", value); }
        }
        public bool bEvaluateSubSequencesInIsolation {
            get {return Main.GetGetBoolPropertyByName(this, "bEvaluateSubSequencesInIsolation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEvaluateSubSequencesInIsolation", value); }
        }
        public bool bRerunConstructionScripts {
            get {return Main.GetGetBoolPropertyByName(this, "bRerunConstructionScripts"); }
            set {Main.SetGetBoolPropertyByName(this, "bRerunConstructionScripts", value); }
        }
        public bool bShowDebugVisualization {
            get {return Main.GetGetBoolPropertyByName(this, "bShowDebugVisualization"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowDebugVisualization", value); }
        }
        public bool bVisualizePreAndPostRoll {
            get {return Main.GetGetBoolPropertyByName(this, "bVisualizePreAndPostRoll"); }
            set {Main.SetGetBoolPropertyByName(this, "bVisualizePreAndPostRoll", value); }
        }
         //TODO: numeric uint32 TrajectoryPathCap
         //TODO: enum EFrameNumberDisplayFormats FrameNumberDisplayFormat
         //TODO: enum ECurveEditorCurveVisibility CurveVisibility
        static SequencerSettings() {
            StaticClass = Main.GetClass("SequencerSettings");
        }
        internal unsafe SequencerSettings_fields* SequencerSettings_ptr => (SequencerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SequencerSettings(IntPtr p) => UObject.Make<SequencerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SequencerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SequencerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
