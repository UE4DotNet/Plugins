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


namespace UE4.VREditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct VRModeSettings_fields {
        [FieldOffset(64)] public bool bEnableAutoVREditMode;
        [FieldOffset(64)] public bool bAutokeySequences;
        [FieldOffset(68)] byte InteractorHand; //TODO: enum EInteractorHand InteractorHand
        [FieldOffset(72)] public bool bShowWorldMovementGrid;
        [FieldOffset(72)] public bool bShowWorldMovementPostProcess;
        [FieldOffset(72)] public bool bShowWorldScaleProgressBar;
        [FieldOffset(76)] public float UIBrightness;
        [FieldOffset(80)] public float GizmoScale;
        [FieldOffset(84)] public float DoubleClickTime;
        [FieldOffset(88)] public float TriggerPressedThreshold_Vive;
        [FieldOffset(92)] public float TriggerPressedThreshold_Rift;
    }
    internal unsafe struct VRModeSettings_methods {
    }
    internal unsafe struct VRModeSettings_events {
    }
}
