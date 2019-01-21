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
        ///<summary>Represents the appearance of an SEditableText</summary>
        [StructLayout( LayoutKind.Explicit, Size=640 )]
        public unsafe struct EditableTextStyle {
            ///<summary>Font family and size to be used when displaying this text.</summary>
            [FieldOffset(8)] SlateFontInfo Font;

            ///<summary>The color and opacity of this text</summary>
            [FieldOffset(120)] SlateColor ColorAndOpacity;

            ///<summary>Background image for the selected text</summary>
            [FieldOffset(160)] SlateBrush BackgroundImageSelected;

            ///<summary>Background image for the selected text</summary>
            [FieldOffset(320)] SlateBrush BackgroundImageComposing;

            ///<summary>Image brush used for the caret</summary>
            [FieldOffset(480)] SlateBrush CaretImage;

        }
}
