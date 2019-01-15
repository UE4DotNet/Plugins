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
        ///<summary>Represents the appearance of an SEditableTextBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=2368 )]
        public unsafe struct EditableTextBoxStyle {
            ///<summary>Border background image when the box is not hovered or focused</summary>
            [FieldOffset(8)] SlateBrush BackgroundImageNormal;

            ///<summary>Border background image when the box is hovered</summary>
            [FieldOffset(168)] SlateBrush BackgroundImageHovered;

            ///<summary>Border background image when the box is focused</summary>
            [FieldOffset(328)] SlateBrush BackgroundImageFocused;

            ///<summary>Border background image when the box is read-only</summary>
            [FieldOffset(488)] SlateBrush BackgroundImageReadOnly;

            ///<summary>Padding</summary>
            [FieldOffset(648)] Margin Padding;

            ///<summary>Font family and size to be used when displaying this text.</summary>
            [FieldOffset(664)] SlateFontInfo Font;

            ///<summary>The foreground color of text.</summary>
            [FieldOffset(768)] SlateColor ForegroundColor;

            ///<summary>The background color applied to the active background image</summary>
            [FieldOffset(808)] SlateColor BackgroundColor;

            ///<summary>The read-only foreground color of text in read-only mode.</summary>
            [FieldOffset(848)] SlateColor ReadOnlyForegroundColor;

            ///<summary>Padding around the horizontal scrollbar</summary>
            [FieldOffset(888)] Margin HScrollBarPadding;

            ///<summary>Padding around the vertical scrollbar</summary>
            [FieldOffset(904)] Margin VScrollBarPadding;

            ///<summary>Style used for the scrollbars</summary>
            [FieldOffset(920)] ScrollBarStyle ScrollBarStyle;

        }
}
