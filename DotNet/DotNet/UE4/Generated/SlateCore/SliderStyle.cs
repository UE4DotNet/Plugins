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
        ///<summary>Represents the appearance of an SSlider</summary>
        [StructLayout( LayoutKind.Explicit, Size=656 )]
        public unsafe struct SliderStyle {
            ///<summary>Image to use when the slider bar is in its normal state</summary>
            [FieldOffset(8)] SlateBrush NormalBarImage;

            ///<summary>Image to use when the slider bar is in its disabled state</summary>
            [FieldOffset(168)] SlateBrush DisabledBarImage;

            ///<summary>Image to use when the slider thumb is in its normal state</summary>
            [FieldOffset(328)] SlateBrush NormalThumbImage;

            ///<summary>Image to use when the slider thumb is in its disabled state</summary>
            [FieldOffset(488)] SlateBrush DisabledThumbImage;

            [FieldOffset(648)] public float BarThickness;

        }
}
