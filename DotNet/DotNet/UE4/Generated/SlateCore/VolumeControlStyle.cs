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
        ///<summary>Represents the appearance of an SVolumeControl</summary>
        [StructLayout( LayoutKind.Explicit, Size=1784 )]
        public unsafe struct VolumeControlStyle {
            ///<summary>The style of the volume control slider</summary>
            [FieldOffset(8)] SliderStyle SliderStyle;

            ///<summary>Image to use when the volume is set to high</summary>
            [FieldOffset(984)] SlateBrush HighVolumeImage;

            ///<summary>Image to use when the volume is set to mid-range</summary>
            [FieldOffset(1144)] SlateBrush MidVolumeImage;

            ///<summary>Image to use when the volume is set to low</summary>
            [FieldOffset(1304)] SlateBrush LowVolumeImage;

            ///<summary>Image to use when the volume is set to off</summary>
            [FieldOffset(1464)] SlateBrush NoVolumeImage;

            ///<summary>Image to use when the volume is muted</summary>
            [FieldOffset(1624)] SlateBrush MutedImage;

        }
}
