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
        ///<summary>Represents the appearance of an SExpandableArea</summary>
        [StructLayout( LayoutKind.Explicit, Size=336 )]
        public unsafe struct ExpandableAreaStyle {
            ///<summary>Image to use when the area is collapsed</summary>
            [FieldOffset(8)] SlateBrush CollapsedImage;

            ///<summary>Image to use when the area is expanded</summary>
            [FieldOffset(168)] SlateBrush ExpandedImage;

            [FieldOffset(328)] public float RolloutAnimationSeconds;

        }
}
