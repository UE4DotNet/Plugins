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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct InterpTrackMove_fields {
        [FieldOffset(176)] public InterpCurveVector PosTrack;
        [FieldOffset(200)] public InterpCurveVector EulerTrack;
        [FieldOffset(224)] public InterpLookupTrack LookupTrack;
        [FieldOffset(240)] public Name LookAtGroupName;
        [FieldOffset(252)] public float LinCurveTension;
        [FieldOffset(256)] public float AngCurveTension;
        [FieldOffset(260)] public bool bUseQuatInterpolation;
        [FieldOffset(260)] public bool bShowArrowAtKeys;
        [FieldOffset(260)] public bool bDisableMovement;
        [FieldOffset(260)] public bool bShowTranslationOnCurveEd;
        [FieldOffset(260)] public bool bShowRotationOnCurveEd;
        [FieldOffset(260)] public bool bHide3DTrack;
        [FieldOffset(264)] public byte RotMode;
    }
    internal unsafe struct InterpTrackMove_methods {
    }
    internal unsafe struct InterpTrackMove_events {
    }
}
