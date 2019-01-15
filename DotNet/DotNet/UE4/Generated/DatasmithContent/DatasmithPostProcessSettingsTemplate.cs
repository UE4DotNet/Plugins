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


namespace UE4.DatasmithContent{
        ///<summary>Datasmith Post Process Settings Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct DatasmithPostProcessSettingsTemplate {
            [FieldOffset(0)] public bool bOverride_WhiteTemp;

            [FieldOffset(0)] public bool bOverride_ColorSaturation;

            [FieldOffset(0)] public bool bOverride_VignetteIntensity;

            [FieldOffset(0)] public bool bOverride_FilmWhitePoint;

            [FieldOffset(0)] public bool bOverride_AutoExposureMethod;

            [FieldOffset(0)] public bool bOverride_CameraISO;

            [FieldOffset(4)] public float WhiteTemp;

            [FieldOffset(8)] public float VignetteIntensity;

            ///<summary>Film White Point</summary>
            [FieldOffset(12)] LinearColor FilmWhitePoint;

            ///<summary>Color Saturation</summary>
            [FieldOffset(32)] Vector4 ColorSaturation;

            [FieldOffset(48)] public byte AutoExposureMethod;

            [FieldOffset(52)] public float CameraISO;

        }
}
