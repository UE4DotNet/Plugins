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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct VRModeSettings_fields {
        [FieldOffset(56)] public bool bEnableAutoVREditMode;
        [FieldOffset(60)] byte InteractorHand; //TODO: enum EInteractorHand InteractorHand
        [FieldOffset(64)] public bool bShowWorldMovementGrid;
        [FieldOffset(64)] public bool bShowWorldMovementPostProcess;
        [FieldOffset(64)] public bool bShowWorldScaleProgressBar;
        [FieldOffset(68)] public float UIBrightness;
        [FieldOffset(72)] public float GizmoScale;
        [FieldOffset(76)] public float DoubleClickTime;
        [FieldOffset(80)] public float TriggerPressedThreshold_Vive;
        [FieldOffset(84)] public float TriggerPressedThreshold_Rift;
    }
    internal unsafe struct VRModeSettings_methods {
    }
    internal unsafe struct VRModeSettings_events {
    }
}
