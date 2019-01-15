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
        ///<summary>Represents the appearance of an SHeaderRow</summary>
        [StructLayout( LayoutKind.Explicit, Size=3432 )]
        public unsafe struct HeaderRowStyle {
            ///<summary>Style of the normal header row columns</summary>
            [FieldOffset(8)] TableColumnHeaderStyle ColumnStyle;

            ///<summary>Style of the last header row column</summary>
            [FieldOffset(1456)] TableColumnHeaderStyle LastColumnStyle;

            ///<summary>Style of the splitter used between the columns</summary>
            [FieldOffset(2904)] SplitterStyle ColumnSplitterStyle;

            ///<summary>Brush used to draw the header row background</summary>
            [FieldOffset(3232)] SlateBrush BackgroundBrush;

            ///<summary>Color used to draw the header row foreground</summary>
            [FieldOffset(3392)] SlateColor ForegroundColor;

        }
}
