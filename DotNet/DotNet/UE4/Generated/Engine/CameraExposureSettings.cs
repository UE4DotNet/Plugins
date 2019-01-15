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
        ///<summary>Camera Exposure Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct CameraExposureSettings {
            [FieldOffset(0)] public byte Method;

            [FieldOffset(4)] public float LowPercent;

            [FieldOffset(8)] public float HighPercent;

            [FieldOffset(12)] public float MinBrightness;

            [FieldOffset(16)] public float MaxBrightness;

            [FieldOffset(20)] public float SpeedUp;

            [FieldOffset(24)] public float SpeedDown;

            [FieldOffset(28)] public float Bias;

            [FieldOffset(32)] public float HistogramLogMin;

            [FieldOffset(36)] public float HistogramLogMax;

            [FieldOffset(40)] public float CalibrationConstant;

        }
}
