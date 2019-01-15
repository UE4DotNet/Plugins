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

using UE4.SlateCore;

namespace UE4.PIEPreviewDeviceProfileSelector{
        ///<summary>Represents the appearance of an SPIEWindow</summary>
        [StructLayout( LayoutKind.Explicit, Size=3080 )]
        public unsafe struct PIEPreviewWindowStyle {
            ///<summary>Style used to draw the window ScreenRotationButton button</summary>
            [FieldOffset(8)] ButtonStyle ScreenRotationButtonStyle;

            ///<summary>Style used to draw the window 0.25x button</summary>
            [FieldOffset(776)] ButtonStyle QuarterMobileContentScaleFactorButtonStyle;

            ///<summary>Style used to draw the window 0.5x button</summary>
            [FieldOffset(1544)] ButtonStyle HalfMobileContentScaleFactorButtonStyle;

            ///<summary>Style used to draw the window 1X button</summary>
            [FieldOffset(2312)] ButtonStyle FullMobileContentScaleFactorButtonStyle;

        }
}
