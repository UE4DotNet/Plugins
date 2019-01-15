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
        ///<summary>Widget Carousel Navigation Bar Style</summary>
        [StructLayout( LayoutKind.Explicit, Size=2472 )]
        public unsafe struct WidgetCarouselNavigationBarStyle {
            ///<summary>Highlight Brush</summary>
            [FieldOffset(8)] SlateBrush HighlightBrush;

            ///<summary>Left Button Style</summary>
            [FieldOffset(168)] ButtonStyle LeftButtonStyle;

            ///<summary>Center Button Style</summary>
            [FieldOffset(936)] ButtonStyle CenterButtonStyle;

            ///<summary>Right Button Style</summary>
            [FieldOffset(1704)] ButtonStyle RightButtonStyle;

        }
}
