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


namespace UE4.SlateCore{
        ///<summary>Represents the appearance of an SSpinBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=864 )]
        public unsafe struct SpinBoxStyle {
            ///<summary>Brush used to draw the background of the spinbox</summary>
            [FieldOffset(8)] SlateBrush BackgroundBrush;

            ///<summary>Brush used to draw the background of the spinbox when it's hovered over</summary>
            [FieldOffset(168)] SlateBrush HoveredBackgroundBrush;

            ///<summary>Brush used to fill the spinbox when it's active</summary>
            [FieldOffset(328)] SlateBrush ActiveFillBrush;

            ///<summary>Brush used to fill the spinbox when it's inactive</summary>
            [FieldOffset(488)] SlateBrush InactiveFillBrush;

            ///<summary>Image used to draw the spinbox arrows</summary>
            [FieldOffset(648)] SlateBrush ArrowsImage;

            ///<summary>Color used to draw the spinbox foreground elements</summary>
            [FieldOffset(808)] SlateColor ForegroundColor;

            ///<summary>Padding to add around the spinbox and its text</summary>
            [FieldOffset(848)] Margin TextPadding;

        }
}
