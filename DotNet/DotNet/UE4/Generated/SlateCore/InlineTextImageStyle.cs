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
        ///<summary>Represents the appearance of an inline image used by rich text</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct InlineTextImageStyle {
            ///<summary>Image to use when the slider thumb is in its normal state</summary>
            [FieldOffset(8)] SlateBrush Image;

            [FieldOffset(168)] public short Baseline;

        }
}
