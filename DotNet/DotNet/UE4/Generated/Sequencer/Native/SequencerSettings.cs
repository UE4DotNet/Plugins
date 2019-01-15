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


namespace UE4.Sequencer.Native {
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct SequencerSettings_fields {
        [FieldOffset(56)] byte AutoChangeMode; //TODO: enum EAutoChangeMode AutoChangeMode
        [FieldOffset(57)] byte AllowEditsMode; //TODO: enum EAllowEditsMode AllowEditsMode
        [FieldOffset(58)] byte KeyGroupMode; //TODO: enum EKeyGroupMode KeyGroupMode
        [FieldOffset(59)] public bool bKeyInterpPropertiesOnly;
        [FieldOffset(60)] byte KeyInterpolation; //TODO: enum EMovieSceneKeyInterpolation KeyInterpolation
        [FieldOffset(61)] public bool bAutoSetTrackDefaults;
        [FieldOffset(62)] public byte SpawnPosition;
        [FieldOffset(63)] public bool bCreateSpawnableCameras;
        [FieldOffset(64)] public bool bShowRangeSlider;
        [FieldOffset(65)] public bool bIsSnapEnabled;
        [FieldOffset(66)] public bool bSnapKeyTimesToInterval;
        [FieldOffset(67)] public bool bSnapKeyTimesToKeys;
        [FieldOffset(68)] public bool bSnapSectionTimesToInterval;
        [FieldOffset(69)] public bool bSnapSectionTimesToSections;
        [FieldOffset(70)] public bool bSnapPlayTimeToKeys;
        [FieldOffset(71)] public bool bSnapPlayTimeToInterval;
        [FieldOffset(72)] public bool bSnapPlayTimeToPressedKey;
        [FieldOffset(73)] public bool bSnapPlayTimeToDraggedKey;
        [FieldOffset(80)] public bool bSnapCurveValueToInterval;
        [FieldOffset(81)] public bool bLabelBrowserVisible;
        [FieldOffset(82)] public bool bShowSelectedNodesOnly;
        [FieldOffset(83)] public bool bRewindOnRecord;
        [FieldOffset(84)] public byte ZoomPosition;
        [FieldOffset(85)] public bool bAutoScrollEnabled;
        [FieldOffset(86)] public bool bLinkCurveEditorTimeRange;
        [FieldOffset(87)] public byte LoopMode;
        [FieldOffset(88)] public bool bKeepCursorInPlayRangeWhileScrubbing;
        [FieldOffset(89)] public bool bKeepCursorInPlayRange;
        [FieldOffset(90)] public bool bKeepPlayRangeInSectionBounds;
        [FieldOffset(91)] public byte ZeroPadFrames;
        [FieldOffset(92)] public bool bShowCombinedKeyframes;
        [FieldOffset(93)] public bool bInfiniteKeyAreas;
        [FieldOffset(94)] public bool bShowChannelColors;
        [FieldOffset(95)] public bool bShowViewportTransportControls;
        [FieldOffset(96)] public bool bAllowPossessionOfPIEViewports;
        [FieldOffset(97)] public bool bActivateRealtimeViewports;
        [FieldOffset(98)] public bool bEvaluateSubSequencesInIsolation;
        [FieldOffset(99)] public bool bRerunConstructionScripts;
        [FieldOffset(100)] public bool bShowDebugVisualization;
        [FieldOffset(101)] public bool bVisualizePreAndPostRoll;
        [FieldOffset(104)] byte TrajectoryPathCap; //TODO: numeric uint32 TrajectoryPathCap
        [FieldOffset(108)] byte FrameNumberDisplayFormat; //TODO: enum EFrameNumberDisplayFormats FrameNumberDisplayFormat
        [FieldOffset(109)] byte CurveVisibility; //TODO: enum ECurveEditorCurveVisibility CurveVisibility
    }
    internal unsafe struct SequencerSettings_methods {
    }
    internal unsafe struct SequencerSettings_events {
    }
}
