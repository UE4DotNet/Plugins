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
        ///<summary>Represents the appearance of an SComboButton</summary>
        [StructLayout( LayoutKind.Explicit, Size=1112 )]
        public unsafe struct ComboButtonStyle {
            ///<summary>The style to use for our SButton</summary>
            [FieldOffset(8)] ButtonStyle ButtonStyle;

            ///<summary>Image to use for the down arrow</summary>
            [FieldOffset(776)] SlateBrush DownArrowImage;

            ///<summary>Brush to use to add a "menu border" around the drop-down content</summary>
            [FieldOffset(936)] SlateBrush MenuBorderBrush;

            ///<summary>Padding to use to add a "menu border" around the drop-down content</summary>
            [FieldOffset(1096)] Margin MenuBorderPadding;

        }
}
