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
        ///<summary>Represents the appearance of an STextBlock</summary>
        [StructLayout( LayoutKind.Explicit, Size=560 )]
        public unsafe struct TextBlockStyle {
            ///<summary>Font family and size to be used when displaying this text.</summary>
            [FieldOffset(8)] SlateFontInfo Font;

            ///<summary>The color and opacity of this text</summary>
            [FieldOffset(120)] SlateColor ColorAndOpacity;

            ///<summary>How much should the shadow be offset? An offset of 0 implies no shadow.</summary>
            [FieldOffset(160)] Vector2D ShadowOffset;

            ///<summary>The color and opacity of the shadow</summary>
            [FieldOffset(168)] LinearColor ShadowColorAndOpacity;

            ///<summary>The background color of selected text</summary>
            [FieldOffset(184)] SlateColor SelectedBackgroundColor;

            ///<summary>The color of highlighted text</summary>
            [FieldOffset(224)] LinearColor HighlightColor;

            ///<summary>The shape of highlighted text</summary>
            [FieldOffset(240)] SlateBrush HighlightShape;

            ///<summary>The brush used to draw an underline under the text (if any)</summary>
            [FieldOffset(400)] SlateBrush UnderlineBrush;

        }
}
