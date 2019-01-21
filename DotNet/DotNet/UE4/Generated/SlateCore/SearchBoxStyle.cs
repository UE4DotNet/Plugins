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
        ///<summary>Represents the appearance of an SSearchBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=3160 )]
        public unsafe struct SearchBoxStyle {
            ///<summary>Style to use for the text box part of the search box</summary>
            [FieldOffset(8)] EditableTextBoxStyle TextBoxStyle;

            ///<summary>Font to use for the text box part of the search box when a search term is entered</summary>
            [FieldOffset(2384)] SlateFontInfo ActiveFontInfo;

            ///<summary>Image to use for the search "up" arrow</summary>
            [FieldOffset(2496)] SlateBrush UpArrowImage;

            ///<summary>Image to use for the search "down" arrow</summary>
            [FieldOffset(2656)] SlateBrush DownArrowImage;

            ///<summary>Image to use for the search "glass"</summary>
            [FieldOffset(2816)] SlateBrush GlassImage;

            ///<summary>Image to use for the search "clear" button</summary>
            [FieldOffset(2976)] SlateBrush ClearImage;

            ///<summary>Padding to use around the images</summary>
            [FieldOffset(3136)] Margin ImagePadding;

            [FieldOffset(3152)] public bool bLeftAlignButtons;

        }
}
