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


namespace UE4.Engine{
        ///<summary>Minimal View Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=1392 )]
        public unsafe struct MinimalViewInfo {
            ///<summary>Location</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>Rotation</summary>
            [FieldOffset(12)] Rotator Rotation;

            [FieldOffset(24)] public float FOV;

            [FieldOffset(28)] public float DesiredFOV;

            [FieldOffset(32)] public float OrthoWidth;

            [FieldOffset(36)] public float OrthoNearClipPlane;

            [FieldOffset(40)] public float OrthoFarClipPlane;

            [FieldOffset(44)] public float AspectRatio;

            [FieldOffset(48)] public bool bConstrainAspectRatio;

            [FieldOffset(48)] public bool bUseFieldOfViewForLOD;

            [FieldOffset(52)] public byte ProjectionMode;

            [FieldOffset(56)] public float PostProcessBlendWeight;

            ///<summary>Post-process settings to use if PostProcessBlendWeight is non-zero.</summary>
            [FieldOffset(64)] PostProcessSettings PostProcessSettings;

            ///<summary>Off-axis / off-center projection offset as proportion of screen dimensions</summary>
            [FieldOffset(1376)] Vector2D OffCenterProjectionOffset;

        }
}
