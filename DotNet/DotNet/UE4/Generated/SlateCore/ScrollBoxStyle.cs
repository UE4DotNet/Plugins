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
        ///<summary>Represents the appearance of an SScrollBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=648 )]
        public unsafe struct ScrollBoxStyle {
            ///<summary>Brush used to draw the top shadow of a scrollbox</summary>
            [FieldOffset(8)] SlateBrush TopShadowBrush;

            ///<summary>Brush used to draw the bottom shadow of a scrollbox</summary>
            [FieldOffset(168)] SlateBrush BottomShadowBrush;

            ///<summary>Brush used to draw the left shadow of a scrollbox</summary>
            [FieldOffset(328)] SlateBrush LeftShadowBrush;

            ///<summary>Brush used to draw the right shadow of a scrollbox</summary>
            [FieldOffset(488)] SlateBrush RightShadowBrush;

        }
}
