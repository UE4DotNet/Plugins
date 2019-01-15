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
        ///<summary>#note, this struct has a details customization in CameraLensSettingsCustomization.cpp/h</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct CameraLensSettings {
            [FieldOffset(0)] public float MinFocalLength;

            [FieldOffset(4)] public float MaxFocalLength;

            [FieldOffset(8)] public float MinFStop;

            [FieldOffset(12)] public float MaxFStop;

            [FieldOffset(16)] public float MinimumFocusDistance;

            [FieldOffset(20)] public int DiaphragmBladeCount;

        }
}
