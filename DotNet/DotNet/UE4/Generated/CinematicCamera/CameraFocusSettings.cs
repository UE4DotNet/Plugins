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


namespace UE4.CinematicCamera{
        ///<summary>Settings to control camera focus</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct CameraFocusSettings {
            [FieldOffset(0)] byte FocusMethod; //TODO: enum ECameraFocusMethod FocusMethod

            [FieldOffset(4)] public float ManualFocusDistance;

            ///<summary>Settings to control tracking focus (tracking focus mode only)</summary>
            [FieldOffset(8)] CameraTrackingFocusSettings TrackingFocusSettings;

            [FieldOffset(32)] public bool bDrawDebugFocusPlane;

            ///<summary>For customizing the focus plane color, in case the default doesn't show up well in your scene.</summary>
            [FieldOffset(36)] Color DebugFocusPlaneColor;

            [FieldOffset(40)] public bool bSmoothFocusChanges;

            [FieldOffset(44)] public float FocusSmoothingInterpSpeed;

            [FieldOffset(48)] public float FocusOffset;

        }
}
