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
        ///<summary>Represents the appearance of an SScrollBar</summary>
        [StructLayout( LayoutKind.Explicit, Size=1448 )]
        public unsafe struct ScrollBarStyle {
            ///<summary>Background image to use when the scrollbar is oriented horizontally</summary>
            [FieldOffset(8)] SlateBrush HorizontalBackgroundImage;

            ///<summary>Background image to use when the scrollbar is oriented vertically</summary>
            [FieldOffset(168)] SlateBrush VerticalBackgroundImage;

            ///<summary>The image to use to represent the track above the thumb when the scrollbar is oriented vertically</summary>
            [FieldOffset(328)] SlateBrush VerticalTopSlotImage;

            ///<summary>The image to use to represent the track above the thumb when the scrollbar is oriented horizontally</summary>
            [FieldOffset(488)] SlateBrush HorizontalTopSlotImage;

            ///<summary>The image to use to represent the track below the thumb when the scrollbar is oriented vertically</summary>
            [FieldOffset(648)] SlateBrush VerticalBottomSlotImage;

            ///<summary>The image to use to represent the track below the thumb when the scrollbar is oriented horizontally</summary>
            [FieldOffset(808)] SlateBrush HorizontalBottomSlotImage;

            ///<summary>Image to use when the scrollbar thumb is in its normal state</summary>
            [FieldOffset(968)] SlateBrush NormalThumbImage;

            ///<summary>Image to use when the scrollbar thumb is in its hovered state</summary>
            [FieldOffset(1128)] SlateBrush HoveredThumbImage;

            ///<summary>Image to use when the scrollbar thumb is in its dragged state</summary>
            [FieldOffset(1288)] SlateBrush DraggedThumbImage;

        }
}
