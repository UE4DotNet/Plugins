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

using UE4.SlateCore;

namespace UE4.WidgetCarousel{
        ///<summary>Widget Carousel Navigation Button Style</summary>
        [StructLayout( LayoutKind.Explicit, Size=1096 )]
        public unsafe struct WidgetCarouselNavigationButtonStyle {
            ///<summary>Inner Button Style</summary>
            [FieldOffset(8)] ButtonStyle InnerButtonStyle;

            ///<summary>Navigation Button Left Image</summary>
            [FieldOffset(776)] SlateBrush NavigationButtonLeftImage;

            ///<summary>Navigation Button Right Image</summary>
            [FieldOffset(936)] SlateBrush NavigationButtonRightImage;

        }
}
