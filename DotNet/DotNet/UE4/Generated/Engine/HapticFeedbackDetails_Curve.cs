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
        ///<summary>Haptic Feedback Details Curve</summary>
        [StructLayout( LayoutKind.Explicit, Size=240 )]
        public unsafe struct HapticFeedbackDetails_Curve {
            ///<summary>The frequency to vibrate the haptic device at.  Frequency ranges vary by device!</summary>
            [FieldOffset(0)] RuntimeFloatCurve Frequency;

            ///<summary>The amplitude to vibrate the haptic device at.  Amplitudes are normalized over the range [0.0, 1.0], with 1.0 being the max setting of the device</summary>
            [FieldOffset(120)] RuntimeFloatCurve Amplitude;

        }
}
