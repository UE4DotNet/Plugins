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
        ///<summary>Represents the appearance of an SSplitter</summary>
        [StructLayout( LayoutKind.Explicit, Size=328 )]
        public unsafe struct SplitterStyle {
            ///<summary>Brush used to draw the handle in its normal state</summary>
            [FieldOffset(8)] SlateBrush HandleNormalBrush;

            ///<summary>Brush used to draw the handle in its highlight state</summary>
            [FieldOffset(168)] SlateBrush HandleHighlightBrush;

        }
}
