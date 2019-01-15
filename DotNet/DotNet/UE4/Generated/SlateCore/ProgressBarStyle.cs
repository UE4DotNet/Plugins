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
        ///<summary>Represents the appearance of an SProgressBar</summary>
        [StructLayout( LayoutKind.Explicit, Size=488 )]
        public unsafe struct ProgressBarStyle {
            ///<summary>Background image to use for the progress bar</summary>
            [FieldOffset(8)] SlateBrush BackgroundImage;

            ///<summary>Foreground image to use for the progress bar</summary>
            [FieldOffset(168)] SlateBrush FillImage;

            ///<summary>Image to use for marquee mode</summary>
            [FieldOffset(328)] SlateBrush MarqueeImage;

        }
}
