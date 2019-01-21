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
        ///<summary>Represents the appearance of an SWindow</summary>
        [StructLayout( LayoutKind.Explicit, Size=4840 )]
        public unsafe struct WindowStyle {
            ///<summary>Style used to draw the window minimize button</summary>
            [FieldOffset(8)] ButtonStyle MinimizeButtonStyle;

            ///<summary>Style used to draw the window maximize button</summary>
            [FieldOffset(776)] ButtonStyle MaximizeButtonStyle;

            ///<summary>Style used to draw the window restore button</summary>
            [FieldOffset(1544)] ButtonStyle RestoreButtonStyle;

            ///<summary>Style used to draw the window close button</summary>
            [FieldOffset(2312)] ButtonStyle CloseButtonStyle;

            ///<summary>Style used to draw the window title text</summary>
            [FieldOffset(3080)] TextBlockStyle TitleTextStyle;

            ///<summary>Brush used to draw the window title area when the window is active</summary>
            [FieldOffset(3640)] SlateBrush ActiveTitleBrush;

            ///<summary>Brush used to draw the window title area when the window is inactive</summary>
            [FieldOffset(3800)] SlateBrush InactiveTitleBrush;

            ///<summary>Brush used to draw the window title area when the window is flashing</summary>
            [FieldOffset(3960)] SlateBrush FlashTitleBrush;

            ///<summary>Color used to draw the window background</summary>
            [FieldOffset(4120)] SlateColor BackgroundColor;

            ///<summary>Brush used to draw the window outline</summary>
            [FieldOffset(4160)] SlateBrush OutlineBrush;

            ///<summary>Color used to draw the window outline</summary>
            [FieldOffset(4320)] SlateColor OutlineColor;

            ///<summary>Brush used to draw the window border</summary>
            [FieldOffset(4360)] SlateBrush BorderBrush;

            ///<summary>Brush used to draw the window background</summary>
            [FieldOffset(4520)] SlateBrush BackgroundBrush;

            ///<summary>Brush used to draw the background of child windows</summary>
            [FieldOffset(4680)] SlateBrush ChildBackgroundBrush;

        }
}
